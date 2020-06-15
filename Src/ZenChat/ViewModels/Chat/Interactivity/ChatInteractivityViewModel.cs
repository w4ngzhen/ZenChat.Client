using System.ComponentModel.Composition;
using ZenChat.ViewModels.Chat.Interactivity.Header;
using ZenChat.ViewModels.Chat.Interactivity.MsgDisplay;
using ZenChat.ViewModels.Chat.Interactivity.MsgSend;

namespace ZenChat.ViewModels.Chat.Interactivity
{
    [Export]
    public class ChatInteractivityViewModel
    {
        public ChatHeaderViewModel ChatHeader { get; set; }
        public ChatMsgDisplayViewModel ChatMsgDisplay { get; set; }
        public ChatMsgSendViewModel ChatMsgSend { get; set; }

        [ImportingConstructor]
        public ChatInteractivityViewModel(
            ChatHeaderViewModel chatHeader, 
            ChatMsgDisplayViewModel chatMsgDisplay, 
            ChatMsgSendViewModel chatMsgSend)
        {
            ChatHeader = chatHeader;
            ChatMsgDisplay = chatMsgDisplay;
            ChatMsgSend = chatMsgSend;
        }
    }
}