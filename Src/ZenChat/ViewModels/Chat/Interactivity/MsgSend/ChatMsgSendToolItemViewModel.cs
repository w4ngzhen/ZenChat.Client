using System.Collections.Generic;
using System.Security.RightsManagement;
using Caliburn.Micro;

namespace ZenChat.ViewModels.Chat.Interactivity.MsgSend
{
    public class ChatMsgSendToolItemViewModel
    {
        public static Dictionary<string, string> IconDictionary = new Dictionary<string, string>()
        {
            { "Emotion", "\ue68c" },
            { "ScreenShot", "\ue600" },
            { "ImageSend", "\uec0c" },
            { "FileSend", "\ue601" },
            { "HistoryMsg", "\ue630" }
        };

        public static List<ChatMsgSendToolItemViewModel> GetChatMsgSendToolItems()
        {
            return new List<ChatMsgSendToolItemViewModel>()
            {
                new ChatMsgSendToolItemViewModel() {Name = "Emotion", Desc = "表情"},
                new ChatMsgSendToolItemViewModel() {Name = "ScreenShot", Desc = "截图"},
                new ChatMsgSendToolItemViewModel() {Name = "ImageSend", Desc = "发送图片"},
                new ChatMsgSendToolItemViewModel() {Name = "FileSend", Desc = "发送文件"},
                new ChatMsgSendToolItemViewModel() {Name = "HistoryMsg", Desc = "历史消息"},
            };
        }

        public string Name { get; set; }

        public string Desc { get; set; }

        public string Icon {
            get { return IconDictionary.GetValueOrDefault(this.Name); }
        }

        public void SelectItem()
        {

        }
    }
}