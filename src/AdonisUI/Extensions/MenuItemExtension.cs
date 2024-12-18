using System.Windows;

namespace AdonisUI.Extensions
{
    public class MenuItemExtension
    {
        public static DataTemplate GetIconTemplate(DependencyObject obj)
        {
            return (DataTemplate)obj.GetValue(IconTemplateProperty);
        }

        public static void SetIconTemplate(DependencyObject obj, DataTemplate value)
        {
            obj.SetValue(IconTemplateProperty, value);
        }

        public static readonly DependencyProperty IconTemplateProperty = DependencyProperty.RegisterAttached("IconTemplate", typeof(DataTemplate), typeof(MenuItemExtension), new PropertyMetadata(null));
    }
}
