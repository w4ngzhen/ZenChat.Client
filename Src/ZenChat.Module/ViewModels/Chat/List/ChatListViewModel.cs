using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using ZenChat.Module.Tests;

namespace ZenChat.Module.ViewModels.Chat.List
{
    [Export]
    public class ChatListViewModel
    {
        public BindableCollection<ChatListItemViewModel> ChatListItems { get; }

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