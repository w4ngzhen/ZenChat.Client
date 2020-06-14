using System.ComponentModel.Composition;
using ZenChat.ViewModels.Chat.Interactivity;
using ZenChat.ViewModels.Chat.List;

namespace ZenChat.ViewModels.Chat
{
    public class ChatModuleViewModel : Module
    {
        public override string Name
        {
            get { return "ChatModule"; }
        }

        public override string Desc
        {
            get { return "聊天"; }
        }

        public ChatListViewModel ChatList { get; private set; }

        public ChatInteractivityViewModel ChatInteractivity { get; private set; }

        [ImportingConstructor]
        public ChatModuleViewModel(
            ChatListViewModel chatList, 
            ChatInteractivityViewModel chatInteractivity)
        {
            this.ChatList = chatList;
            this.ChatInteractivity = chatInteractivity;
        }


    }
}