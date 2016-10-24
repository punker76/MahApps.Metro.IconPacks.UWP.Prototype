using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MahApps.Metro.IconPacks.UWP.Converter
{
    /// <summary>
    /// ValueConverter which converts the PackIconFlipOrientation enumeration value to ScaleX value of a ScaleTransformation.
    /// </summary>
    /// <seealso cref="MahApps.Metro.IconPacks.Converter.MarkupConverter" />
    public class FlipToScaleXValueConverter : IValueConverter
    {
//        private static FlipToScaleXValueConverter _instance;
//
//        // Explicit static constructor to tell C# compiler
//        // not to mark type as beforefieldinit
//        static FlipToScaleXValueConverter()
//        {
//        }
//
//        public FlipToScaleXValueConverter Instance { get { return _instance ?? (_instance = new FlipToScaleXValueConverter()); } }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is PackIconFlipOrientation)
            {
                var flip = (PackIconFlipOrientation)value;
                var scaleX = flip == PackIconFlipOrientation.Horizontal || flip == PackIconFlipOrientation.Both ? -1 : 1;
                return scaleX;
            }
            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return DependencyProperty.UnsetValue;
        }
    }

    /// <summary>
    /// ValueConverter which converts the PackIconFlipOrientation enumeration value to ScaleY value of a ScaleTransformation.
    /// </summary>
    /// <seealso cref="MahApps.Metro.IconPacks.Converter.MarkupConverter" />
    public class FlipToScaleYValueConverter : IValueConverter
    {
//        private static FlipToScaleYValueConverter _instance;
//
//        // Explicit static constructor to tell C# compiler
//        // not to mark type as beforefieldinit
//        static FlipToScaleYValueConverter()
//        {
//        }
//
//        public FlipToScaleYValueConverter Instance { get { return _instance ?? (_instance = new FlipToScaleYValueConverter()); } }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is PackIconFlipOrientation)
            {
                var flip = (PackIconFlipOrientation)value;
                var scaleY = flip == PackIconFlipOrientation.Vertical || flip == PackIconFlipOrientation.Both ? -1 : 1;
                return scaleY;
            }
            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}