using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wack_A_Sora.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
[assembly:Dependency(typeof(StatusBarHiddenMode))]
[assembly: ExportFont("no_game.ttf", Alias = "nogame")]
namespace Wack_A_Sora
{
     
    [XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page1 : ContentPage
{
        public Page1(int Score_1)
        {
           
            InitializeComponent();
            
        }

        public Page1()
        {
        }

        public int score_1 { get; private set; }

        private async void Start_Clicked(object sender, EventArgs e)
        {
            //clickEffect
            //Application.Current.Properties["Start"] = Start.Text;
            // MainPage page = new MainPage();
            
            await Navigation.PushModalAsync(new MainPage(score_1));
        }

        private async void Medium_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page2(score_1));
        }

        private async void Hard_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3(score_1));
        }
    }
}