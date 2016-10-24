using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MahApps.Metro.IconPacks.UWP.Converter
{
    public class NullToUnsetValueConverter : IValueConverter
    {
//        private static NullToUnsetValueConverter _instance;
//
//        // Explicit static constructor to tell C# compiler
//        // not to mark type as beforefieldinit
//        static NullToUnsetValueConverter()
//        {
//        }
//
//        public NullToUnsetValueConverter Instance { get { return _instance ?? (_instance = new NullToUnsetValueConverter()); } }

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