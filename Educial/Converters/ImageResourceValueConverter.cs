using System.Globalization;
using System.Reflection;

namespace Educial.Converters
{
    public class ImageResourceValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is string))
                return null;

            ImageSource imageSrc = ImageSource.FromResource($"FreeChat.Resources.Images.{value.ToString()}", typeof(ImageResourceValueConverter).GetTypeInfo().Assembly);
            return imageSrc;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
