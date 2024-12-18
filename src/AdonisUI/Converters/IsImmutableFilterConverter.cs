using System;
using System.Globalization;
using System.Windows.Data;

namespace AdonisUI.Converters
{
    public class IsImmutableFilterConverter
        : IValueConverter
    {
        public static IsImmutableFilterConverter Instance = new IsImmutableFilterConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)IsImmutableToBoolConverter.Instance.Convert(value, targetType, parameter, culture))
                return value;
                
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
