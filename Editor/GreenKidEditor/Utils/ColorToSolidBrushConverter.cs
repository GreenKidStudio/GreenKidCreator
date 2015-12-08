﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace GreenKidEditor.Utils
{
    public class ColorToSolidBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null == value ? null : new SolidColorBrush((Color)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((SolidColorBrush)value)?.Color;
        }
    }
}