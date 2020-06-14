using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using ZenChat.Tests;

namespace ZenChat.ViewModels.Chat.List
{
    [Export]
    public class ChatListViewModel
    {
        public BindableCollection<ChatListItemViewModel> ChatListItems { get; private set; }

        public ChatListViewModel()
        {
            this.ChatListItems = new BindableCollection<ChatListItemViewModel>();
            this.AddItems(DataGenerator.GetChatListItems().AsEnumerable());
        }

        public void AddItem(ChatListItemViewModel item)
        {
            this.ChatListItems.Add(item);
        }

        public void AddItems(IEnumerable<ChatListItemViewModel> items)
        {
            this.ChatListItems.AddRange(items);
        }
    }
}