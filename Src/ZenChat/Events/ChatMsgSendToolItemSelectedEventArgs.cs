using ZenChat.ViewModels.Chat.Interactivity.MsgSend;

namespace ZenChat.Events
{
    public class ChatMsgSendToolItemSelectedEventArgs
    {
        public ChatMsgSendToolItemViewModel ChatMsgSendToolItem { get; private set; }

        public ChatMsgSendToolItemSelectedEventArgs(ChatMsgSendToolItemViewModel item)
        {
            this.ChatMsgSendToolItem = item;
        }
    }
}