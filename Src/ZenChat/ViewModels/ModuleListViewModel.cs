using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using ZenChat.Events;

namespace ZenChat.ViewModels
{
    [Export]
    public class ModuleListViewModel: IHandle<ModuleListItemSelectedEventArgs>
    {
        public BindableCollection<ModuleListItemViewModel> ModuleListItems { get; private set; }

        public IEventAggregator EventAggregator { get; set; }

        [ImportingConstructor]
        public ModuleListViewModel([ImportMany] IEnumerable<Module> modules, IEventAggregator eventAggregator)
        {
            this.ModuleListItems = new BindableCollection<ModuleListItemViewModel>();
            this.EventAggregator = eventAggregator;
            this.EventAggregator.Subscribe(this);
            this.ModuleListItems.AddRange(modules.ToList().Select(module => new ModuleListItemViewModel(module)
            {
                EventAggregator = this.EventAggregator
            }));
        }

        public void Handle(ModuleListItemSelectedEventArgs message)
        {
            this.ModuleListItems.ToList().ForEach(item =>
            {
                if (item != message.Sender)
                {
                    item.IsSelected = false;
                }
            });
            this.EventAggregator.PublishOnUIThread(new ModuleActivateEventArgs(message.Sender.RefModule));
        }
    }
}