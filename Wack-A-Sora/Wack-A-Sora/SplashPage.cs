using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Wack_A_Sora 
{
    public class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage(int score_1)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();

            splashImage = new Image
            {
                Source = "Crunchyroll_1.png",
                WidthRequest = 200,
                HeightRequest = 200
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#F47521");
            this.Content = sub;
        }

        public int score_1 { get; private set; }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new Page1(score_1));
        }
    }
}
