using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Documents;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ZenChat.ViewModels.Chat.List;

namespace ZenChat.Tests
{
    public static class DataGenerator
    {
        public static string TestDataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tests", "Data");

        static DataGenerator()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;
            JsonConvert.DefaultSettings = () => settings;
        }

        public static List<ChatListItemViewModel> GetChatListItems()
        {
            List<ChatListItemViewModel> chatListItemViewModels = 
                JsonConvert.DeserializeObject<List<ChatListItemViewModel>>(ReadChatListItemTestData());
            if (chatListItemViewModels.Count > 0)
            {
                chatListItemViewModels[0].UpdateTime = DateTime.Now;
            }
            return chatListItemViewModels;
        }

        public static string ReadChatListItemTestData()
        {
            return File.ReadAllText(Path.Combine(TestDataDir, "ChatListItems.json"));
        }
    }
}