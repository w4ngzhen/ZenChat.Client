using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Documents;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ZenChat.Module.ViewModels.Chat.List;

namespace ZenChat.Module.Tests
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
            return JsonConvert.DeserializeObject<List<ChatListItemViewModel>>(ReadChatListItemTestData());
        }

        public static string ReadChatListItemTestData()
        {
            return File.ReadAllText(Path.Combine(TestDataDir, "ChatListItems.json"));
        }
    }
}