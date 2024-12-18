using System;
using System.Globalization;
using System.Windows.Data;

namespace AdonisUI.Converters
{
    public class IsNullToBoolConverter
        : IValueConverter
    {
        public static IsNullToBoolConverter Instance = new IsNullToBoolConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
