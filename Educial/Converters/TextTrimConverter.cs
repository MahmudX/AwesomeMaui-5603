using System.Globalization;

namespace Educial.Converters
{
    public class TextTrimConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string source = value.ToString().Trim();
            const int length = 22;
            if (source.Length > 25)
                return source.PadRight(length).Substring(0, length).Trim() + "...";
            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
