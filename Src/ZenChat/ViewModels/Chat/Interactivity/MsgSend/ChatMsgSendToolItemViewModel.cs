using System.Collections.Generic;
using System.Security.RightsManagement;
using Caliburn.Micro;
using ZenChat.Events;

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

        public static List<ChatMsgSendToolItemViewModel> GetChatMsgSendToolItems(IEventAggregator eventAggregator)
        {
            List<ChatMsgSendToolItemViewModel> items = new List<ChatMsgSendToolItemViewModel>()
            {
                new ChatMsgSendToolItemViewModel() {Name = "Emotion", Desc = "表情"},
                new ChatMsgSendToolItemViewModel() {Name = "ScreenShot", Desc = "截图"},
                new ChatMsgSendToolItemViewModel() {Name = "ImageSend", Desc = "发送图片"},
                new ChatMsgSendToolItemViewModel() {Name = "FileSend", Desc = "发送文件"},
                new ChatMsgSendToolItemViewModel() {Name = "HistoryMsg", Desc = "历史消息"},
            };
            items.ForEach(item => item.EventAggregator = eventAggregator);
            return items;
        }

        public IEventAggregator EventAggregator { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public string Icon
        {
            get { return IconDictionary.GetValueOrDefault(this.Name); }
        }

        public void SelectItem()
        {
            if (EventAggregator != null)
            {
                EventAggregator.PublishOnUIThread(new ChatMsgSendToolItemSelectedEventArgs(this));
            }
        }
    }
}