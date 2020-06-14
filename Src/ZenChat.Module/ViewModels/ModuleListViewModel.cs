using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;

namespace ZenChat.Module.ViewModels
{
    [Export]
    public class ModuleListViewModel
    {
        public BindableCollection<ModuleListItemViewModel> ModuleListItems { get; private set; }

        [ImportingConstructor]
        public ModuleListViewModel([ImportMany] IEnumerable<Module> modules)
        {
            this.ModuleListItems = new BindableCollection<ModuleListItemViewModel>();
            this.ModuleListItems.AddRange(modules.ToList().Select(module => new ModuleListItemViewModel(module)));
        }
    }
}