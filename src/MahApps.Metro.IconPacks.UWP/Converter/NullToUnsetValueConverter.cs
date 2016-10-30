using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MahApps.Metro.IconPacks.Converter
{
    public class NullToUnsetValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value ?? DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}