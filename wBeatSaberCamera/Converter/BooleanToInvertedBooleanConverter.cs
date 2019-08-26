﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace wBeatSaberCamera.Converter
{
    public class BooleanToInvertedBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !System.Convert.ToBoolean(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !System.Convert.ToBoolean(value);
        }
    }
}