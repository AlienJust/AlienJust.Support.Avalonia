using System;
using Avalonia.Data.Converters;

namespace AlienJust.Support.Wpf.Converters
{
    public class DoubleAdditiveConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double addition;
            double.TryParse(parameter.ToString(), out addition);

            var incomingDouble = (double)value;
            return incomingDouble + addition;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}