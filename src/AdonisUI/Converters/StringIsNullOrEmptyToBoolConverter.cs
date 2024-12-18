﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace AdonisUI.Converters
{
    public class StringIsNullOrEmptyToBoolConverter
        : IValueConverter
    {
        public static StringIsNullOrEmptyToBoolConverter Instance = new StringIsNullOrEmptyToBoolConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null || value.ToString() == String.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
