namespace Educial
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("HelveticaNowText-Medium.ttf", "Helvetica");
                    fonts.AddFont("HelveticaNowText-Bold.ttf", "Helvetica Bold");
                    fonts.AddFont("SFUIText-Medium.ttf", "SF Pro Text");
                    fonts.AddFont("SFUIText-Bold.ttf", "SF Pro Text Bold");
                    fonts.AddFont("SFUIText-Semibold.ttf", "SF Pro Text Semibold");
                    fonts.AddFont("Segoe Fluent Icons.ttf", "Segoe Fluent Icons");
                    fonts.AddFont("NotoSansBengali-Bold.ttf", "Noto Sans Bengali Bold");
                    fonts.AddFont("NotoSansBengali-Medium.ttf", "Noto Sans Bengali");
                });
            return builder.Build();
        }
    }
}