using System.Globalization;

namespace Educial.Converters
{
    public class IsNullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool returnedValue = string.IsNullOrEmpty(value?.ToString()) && value == null;
            return !returnedValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
