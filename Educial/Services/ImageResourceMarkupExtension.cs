using System.Reflection;

namespace Educial.Services
{
    public class ImageResourceMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            ImageSource imageSrc = ImageSource.FromResource(Source, typeof(ImageResourceMarkupExtension).GetTypeInfo().Assembly);
            return imageSrc;
        }
    }
}
