using System;
using System.Globalization;
using System.Windows.Data;

namespace AdonisUI.Converters
{
    public class IsImmutableToBoolConverter
        : IValueConverter
    {
        public static IsImmutableToBoolConverter Instance = new IsImmutableToBoolConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return true;

            Type type = value.GetType();

            return type.IsValueType
                || type.IsEnum
                || value is string
                || value is Delegate;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
