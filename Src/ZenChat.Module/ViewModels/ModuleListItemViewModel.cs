using Caliburn.Micro;

namespace ZenChat.Module.ViewModels
{
    public class ModuleListItemViewModel : PropertyChangedBase
    {
        private bool _isChosen;

        public Module RefModule { get; private set; }

        public bool IsChosen
        {
            get { return _isChosen; }
            set
            {
                _isChosen = value; 
                this.NotifyOfPropertyChange(() => IsChosen);
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

        public ModuleListItemViewModel(Module refModule)
        {
            this.RefModule = refModule;
        }
    }
}