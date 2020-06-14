using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using ZenChat;
using ZenChat.Events;
using ZenChat.ViewModels;
using ZenChat.Views;

namespace ZenChat.ViewModels
{
    [Export]
    public class MainWindowViewModel : Conductor<Module>.Collection.OneActive, IHandle<ModuleActivateEventArgs>
    {
        public ModuleListViewModel ModuleList { get; private set; }

        public IEventAggregator EventAggregator { get; set; }

        [ImportingConstructor]
        public MainWindowViewModel(ModuleListViewModel moduleList, IEventAggregator eventAggregator)
        {
            this.ModuleList = moduleList;
            this.EventAggregator = eventAggregator;
            this.EventAggregator.Subscribe(this);
        }

        public void Handle(ModuleActivateEventArgs message)
        {
            if (message.TheModule != this.ActiveItem)
            {
                this.ActivateItem(message.TheModule);
            }
        }
    }
}