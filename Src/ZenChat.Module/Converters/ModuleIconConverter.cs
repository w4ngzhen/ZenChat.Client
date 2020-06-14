using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace ZenChat.Module.Converters
{
    public class ModuleIconConverter: IValueConverter
    {
        public readonly Dictionary<string, string> ModuleIconDictionary = new Dictionary<string, string>()
        {
            { "ChatModule", "\\ue6c0"},
            { "AddressBookModule", "\\ue690"},
            { "NotifyModule", "\\ue683"},
            { "ToolModule", "\\ue607"},
            { "NetDiskModule", "\\ue600"},
        };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is string))
            {
                return "";
            }

            string icon;
            return ModuleIconDictionary.TryGetValue((string)value, out icon) ? icon : "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}