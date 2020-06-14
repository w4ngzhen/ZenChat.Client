using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using ZenChat.Module;
using ZenChat.Module.ViewModels;
using ZenChat.Module.Views;

namespace ZenChat.ViewModels
{
    [Export]
    public class MainWindowViewModel : Conductor<Module.Module>.Collection.OneActive
    {
        public ModuleListViewModel ModuleList { get; private set; }

        [ImportingConstructor]
        public MainWindowViewModel(ModuleListViewModel moduleList)
        {
            this.ModuleList = moduleList;
        }

        protected override void OnActivate()
        {
            base.OnActivate();
        }
    }
}