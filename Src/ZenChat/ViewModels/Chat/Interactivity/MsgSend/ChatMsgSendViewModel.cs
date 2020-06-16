using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace ZenChat.ViewModels.Chat.Interactivity.MsgSend
{
    [Export]
    public class ChatMsgSendViewModel
    {
        public ChatMsgSendToolBarViewModel ChatMsgSendToolBar { get; set; }

        public IEventAggregator EventAggregator { get; set; }

        [ImportingConstructor]
        public ChatMsgSendViewModel(
            ChatMsgSendToolBarViewModel chatMsgSendToolBar, 
            IEventAggregator eventAggregator)
        {
            ChatMsgSendToolBar = chatMsgSendToolBar;
            this.EventAggregator = eventAggregator;
            this.ChatMsgSendToolBar.AddItems(
                ChatMsgSendToolItemViewModel.GetChatMsgSendToolItems(this.EventAggregator));
        }
    }
}