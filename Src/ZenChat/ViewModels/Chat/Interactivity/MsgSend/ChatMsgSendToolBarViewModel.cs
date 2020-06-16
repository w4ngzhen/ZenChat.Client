using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using ZenChat.Events;

namespace ZenChat.ViewModels.Chat.Interactivity.MsgSend
{
    [Export]
    public class ChatMsgSendToolBarViewModel : IHandle<ChatMsgSendToolItemSelectedEventArgs>
    {
        public BindableCollection<ChatMsgSendToolItemViewModel> ChatMsgSendToolItems { get; set; }

        public IEventAggregator EventAggregator { get; set; }

        [ImportingConstructor]
        public ChatMsgSendToolBarViewModel(IEventAggregator eventAggregator)
        {
            ChatMsgSendToolItems = new BindableCollection<ChatMsgSendToolItemViewModel>();
            this.EventAggregator = eventAggregator;
            this.EventAggregator.Subscribe(this);
        }

        public void AddItem(ChatMsgSendToolItemViewModel item)
        {
            this.ChatMsgSendToolItems.Add(item);
        }

        public void AddItems(IEnumerable<ChatMsgSendToolItemViewModel> items)
        {
            this.ChatMsgSendToolItems.AddRange(items);
        }

        public void Handle(ChatMsgSendToolItemSelectedEventArgs message)
        {

        }
    }
}