using System;

namespace ZenChat.ViewModels.Chat.List
{
    public class ChatListItemViewModel
    {
        public string Id { get; set; }

        public string Avatar { get; set; }

        public string Name { get; set; }

        public DateTime UpDateTime { get; set; }

        public string Abstract { get; set; }
    }
}