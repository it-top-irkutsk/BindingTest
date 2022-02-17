using System;
using System.Globalization;
using System.Windows.Data;

namespace BindingTest.App
{
    public class DataConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is DateTime date ? date : default).ToString("d");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToDateTime((string)value);
        }
    }
}