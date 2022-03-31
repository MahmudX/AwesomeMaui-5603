using Educial.Resources.Themes;

namespace Educial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            OSAppTheme currentTheme = Current.RequestedTheme;
            SetTheme(currentTheme);
            Current.RequestedThemeChanged += (s, a) =>
            {
                SetTheme(a.RequestedTheme);
            };
            MainPage = new AppShell();
        }
        private static void SetTheme(OSAppTheme theme)
        {

            ICollection<ResourceDictionary> mergedDictionaries = Current.Resources.MergedDictionaries;
            if (mergedDictionaries == null) return;
            mergedDictionaries.Clear();

            switch (theme)
            {
                case OSAppTheme.Dark:
                    //mergedDictionaries.Add(new DarkTheme());
                    //break;
                case OSAppTheme.Light:
                case OSAppTheme.Unspecified:
                default:
                    mergedDictionaries.Add(new LightTheme());
                    break;
            }
        }
    }
}