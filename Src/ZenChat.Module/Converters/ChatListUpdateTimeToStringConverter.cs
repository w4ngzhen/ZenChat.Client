using System;
using System.Globalization;
using System.Windows.Data;

namespace ZenChat.Module.Converters
{
    public class ChatListUpdateTimeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is DateTime))
            {
                return "未知日期";
            }

            DateTime updateTime = (DateTime) value;
            DateTime now = DateTime.Now;
            TimeSpan span = now.Subtract(updateTime);
            if (span.TotalSeconds > 24 * 60 * 60) 
            {
                return updateTime.ToString("MM-dd"); // 超过1天，只显示日期
            }
            else
            {
                return updateTime.ToString("HH:mm"); // 否则显示时刻
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}