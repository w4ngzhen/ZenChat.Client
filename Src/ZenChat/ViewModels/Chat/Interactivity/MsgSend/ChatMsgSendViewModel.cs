using System.ComponentModel.Composition;

namespace ZenChat.ViewModels.Chat.Interactivity.MsgSend
{
    [Export]
    public class ChatMsgSendViewModel
    {
        public ChatMsgSendToolBarViewModel ChatMsgSendToolBar { get; set; }

        [ImportingConstructor]
        public ChatMsgSendViewModel(ChatMsgSendToolBarViewModel chatMsgSendToolBar)
        {
            ChatMsgSendToolBar = chatMsgSendToolBar;
            this.ChatMsgSendToolBar.AddItems(ChatMsgSendToolItemViewModel.GetChatMsgSendToolItems());
        }
    }
}