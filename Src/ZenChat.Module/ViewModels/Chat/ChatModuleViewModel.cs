using System.ComponentModel.Composition;
using ZenChat.Module.ViewModels.Chat.Interactivity;
using ZenChat.Module.ViewModels.Chat.List;

namespace ZenChat.Module.ViewModels.Chat
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