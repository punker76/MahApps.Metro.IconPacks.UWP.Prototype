using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MahApps.Metro.IconPacks.Converter
{
    /// <summary>
    /// ValueConverter which converts the PackIconFlipOrientation enumeration value to ScaleX value of a ScaleTransformation.
    /// </summary>
    public class FlipToScaleXValueConverter : IValueConverter
    {
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
    public class FlipToScaleYValueConverter : IValueConverter
    {
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