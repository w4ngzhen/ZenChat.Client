using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace ZenChat.ViewModels.Chat.Interactivity.MsgSend
{
    [Export]
    public class ChatMsgSendToolBarViewModel
    {
        public BindableCollection<ChatMsgSendToolItemViewModel> ChatMsgSendToolItems { get; set; }

        public ChatMsgSendToolBarViewModel()
        {
            ChatMsgSendToolItems = new BindableCollection<ChatMsgSendToolItemViewModel>();
        }

        public void AddItem(ChatMsgSendToolItemViewModel item)
        {
            this.ChatMsgSendToolItems.Add(item);
        }

        public void AddItems(IEnumerable<ChatMsgSendToolItemViewModel> items)
        {
            this.ChatMsgSendToolItems.AddRange(items);
        }
    }
}