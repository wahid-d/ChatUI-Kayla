using System;
using System.Globalization;
using Xamarin.Forms;

namespace ChatUI.Tools.Converters
{
    public class LastSeenToRelativeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var lastSeen = (DateTime)value;
            var diff = DateTime.Now - lastSeen;

            if ((int)diff.TotalDays > 0)
            {
                return $"{(int)diff.TotalDays}d";
            }
            else if ((int)diff.TotalHours > 0)
            {
                return $"{(int)diff.TotalHours}h";
            }
            else if ((int)diff.TotalMinutes > 0)
            {
                return $"{(int)diff.TotalMinutes}m";
            }
            else
            {
                return $"{(int)diff.TotalSeconds}s";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
