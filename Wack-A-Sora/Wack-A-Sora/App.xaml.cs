using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wack_A_Sora
{
    public partial class App : Application
    {
        public int Score_1 { get; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage(Score_1));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
