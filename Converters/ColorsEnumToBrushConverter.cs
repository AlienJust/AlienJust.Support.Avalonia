﻿using System;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace AlienJust.Support.Avalonia.Converters
{
    public class ColorsEnumToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is AlienJust.Support.UI.Contracts.Colors color)
            {
                return new SolidColorBrush(ColorsConverter.Convert(color));
            }
            throw new Exception("Wrong type: value is not Colors");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
