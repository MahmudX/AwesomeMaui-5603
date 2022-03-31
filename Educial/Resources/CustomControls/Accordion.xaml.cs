using System;
using System.Threading.Tasks;

using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace Educial.Resources.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accordion : ContentView
    {
        public static readonly BindableProperty IndicatorViewProperty = BindableProperty.Create(nameof(IndicatorView), typeof(View), typeof(Accordion));
        public View IndicatorView
        {
            get => (View)GetValue(IndicatorViewProperty);
            set => SetValue(IndicatorViewProperty, value);
        }

        public static readonly BindableProperty ContentViewProperty = BindableProperty.Create(nameof(AccordionContentView), typeof(View), typeof(Accordion));
        public View AccordionContentView
        {
            get => (View)GetValue(ContentViewProperty);
            set => SetValue(ContentViewProperty, value);
        }
 
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(Accordion));
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }



        public static readonly BindableProperty IsOpenBindablePropertyProperty = BindableProperty.Create(nameof(IsOpen), typeof(bool), typeof(Accordion), false, propertyChanged: IsOpenChanged);
        public bool IsOpen
        {
            get => (bool)GetValue(IsOpenBindablePropertyProperty);
            set => SetValue(IsOpenBindablePropertyProperty, value);
        }

        public static readonly BindableProperty HeaderBackgroundColorProperty = BindableProperty.Create(nameof(HeaderBackgroundColor), typeof(Color), typeof(Accordion), Color.FromArgb("#00FFFFFF"));
        public Color HeaderBackgroundColor
        {
            get => (Color)GetValue(HeaderBackgroundColorProperty);
            set => SetValue(HeaderBackgroundColorProperty, value);
        }

        private static void IsOpenChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null || newValue == null) return;
            var control = (Accordion)bindable;

            if (control.IsOpen == false)
            {
                VisualStateManager.GoToState(control, "Open");
                control.Close();
            }
            else
            {
                VisualStateManager.GoToState(control, "Closed");
                control.Open();
            }
        }

        public uint AnimationDuration { get; set; }

        public Accordion()
        {
            InitializeComponent();
            Close();
            AnimationDuration = 250;
            IsOpen = false;
        }

        private async void Close()
        {
            await Task.WhenAll(
                AccordionContent.TranslateTo(0, -10, AnimationDuration),
                IndicatorContainer.RotateTo(0, AnimationDuration),
                AccordionContent.FadeTo(0, 50)
                );
            AccordionContent.IsVisible = false;
        }

        private async void Open()
        {
            AccordionContent.IsVisible = true;
            await Task.WhenAll(
                AccordionContent.TranslateTo(0, 10, AnimationDuration),
                IndicatorContainer.RotateTo(180, AnimationDuration),
                AccordionContent.FadeTo(30, 50, Easing.SinIn)
            );
        }

        private void TitleTapped(object sender, EventArgs e)
        {
            IsOpen = !IsOpen;
        }
    }
}