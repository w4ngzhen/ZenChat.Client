using System.CodeDom;
using System.Collections.Generic;
using System.Windows.Media.Animation;
using Caliburn.Micro;
using ZenChat.Events;

namespace ZenChat.ViewModels
{
    public class ModuleListItemViewModel : PropertyChangedBase
    {
        public static Dictionary<string, string> IconDictionary = new Dictionary<string, string>()
        {
            { "ChatModule", "\ue6c0"},
            { "AddressBookModule", "\ue690"},
            { "NotifyModule", "\ue683"},
            { "ToolModule", "\ue607"},
            { "NetDiskModule", "\ue600"},
        };

        private bool _isSelected;

        public Module RefModule { get; private set; }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value; 
                this.NotifyOfPropertyChange(() => IsSelected);
            }
        }

        public string Name
        {
            get { return this.RefModule.Name; }
        }

        public string Desc
        {
            get { return this.RefModule.Desc; }
        }

        public string Icon
        {
            get
            {
                return IconDictionary.GetValueOrDefault(this.Name);
            }
        }

        public IEventAggregator EventAggregator { get; set; }

        public ModuleListItemViewModel(Module refModule)
        {
            this.RefModule = refModule;
        }

        public void SelectItem()
        {
            if (this.IsSelected)
            {
                return;
            }
            this.IsSelected = true;
            if (this.EventAggregator != null)
            {
                this.EventAggregator.PublishOnUIThread(new ModuleListItemSelectedEventArgs(this));
            }
        }
    }
}