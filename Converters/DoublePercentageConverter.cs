using System;
using Avalonia.Data.Converters;

namespace AlienJust.Support.Avalonia.Converters
{
    public class DoublePercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double percentage;
            double.TryParse(parameter.ToString(), out percentage);

            var incomingDouble = (double)value;
            return incomingDouble * (percentage / 100);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}