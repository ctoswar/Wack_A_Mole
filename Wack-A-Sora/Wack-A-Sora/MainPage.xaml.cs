using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Wack_A_Sora
{
    public partial class MainPage : ContentPage
    {
        //Variable call out
        public Random r = new Random();
        public int Score_1 = 0;
        public int moleRand, nMoleRand;
        public int counter = 1;
        public Boolean strt = true;
        public int TimerTime = 20;
        bool Stoptimer = false;

        
        public string mole1,mole2,mole3,mole4,mole5,mole6,mole7,mole8,mole9;
        //ends here--^
        public MainPage(int score_1)
        {
            InitializeComponent();
            if(TimerTime != 0)
            {
             
                Device.StartTimer(TimeSpan.FromSeconds(1),  () =>
                {
                  
                    TimerTime--;
                    Timer1.Text = "Time: " + TimerTime.ToString();
                    if (Stoptimer) return false;
                    if (TimerTime > 0) return true;
                    
                    else
                    {
                        DisplayAlert("Run Out of Time","","Try Again");
                        Task.Delay(1500);
                        Navigation.PushModalAsync(new Page1(Score_1));
                        return false;
                    }
                });
            }

            
            Score_1 = score_1;
            score.Text = $"{score_1.ToString() }/{ score.Text.ToString()}";
            

            Tmole1.Source = "";
            Tmole2.Source = "";
            Tmole3.Source = "";

            Mmole1.Source = "";
            Mmole2.Source = "";
            Mmole3.Source = "";

            Bmole1.Source = "";
            Bmole2.Source = "";
            Bmole3.Source = "";
            showPics();
        }
       
        public async void showPics()
        {
            counter = 1;
            do
            {
                moleRand = r.Next(1, 3);
                nMoleRand = r.Next(1, 10);

                switch (counter)
                {
                    case 1:
                        if (moleRand == 1)
                        {
                            Tmole1.Source = "shiro.png";
                            
                            counter++;
                        }
                        else
                        {
                            Tmole1.Source = "sora.png";
                            counter++;
                        }
                        break;
                    case 2:
                        if (moleRand == 1)
                        {
                            Tmole2.Source = "shiro.png";
                            counter++;
                        }
                        else
                        {
                            Tmole2.Source = "sora.png";
                          
                            counter++;
                        }
                        break;
                    case 3:
                        if (moleRand == 1)
                        {
                            Tmole3.Source = "shiro.png";
                            counter++;
                        }
                        else
                        {
                            Tmole3.Source = "sora.png";
                           
                            counter++;
                        }
                        break;
                    case 4:
                        if (moleRand == 1)
                        {
                            Mmole1.Source = "shiro.png";
                            counter++;
                        }
                        else
                        {
                            Mmole1.Source = "sora.png";
                           
                            counter++;
                        }
                        break;
                    case 5:
                        if (moleRand == 1)
                        {
                            Mmole2.Source = "shiro.png";
                          
                            counter++;
                        }
                        else
                        {
                            Mmole2.Source = "sora.png";
                            counter++;
                        }
                        break;
                    case 6:
                        if (moleRand == 1)
                        {
                            Mmole3.Source = "shiro.png";
                            
                            counter++;
                        }
                        else
                        {
                            Mmole3.Source = "sora.png";
                            counter++;
                        }
                        break;
                    case 7:
                        if (moleRand == 1)
                        {
                            Bmole1.Source = "shiro.png";
                           
                            counter++;
                        }
                        else
                        {
                            Bmole1.Source = "sora.png";
                            counter++;
                        }
                        break;
                    case 8:
                        if (moleRand == 1)
                        {
                            Bmole2.Source = "shiro.png";
                            counter++;
                        }
                        else
                        {
                            Bmole2.Source = "sora.png";
                            
                            counter++;
                        }
                        break;
                    case 9:
                        if (moleRand == 1)
                        {
                            Bmole3.Source = "shiro.png";
                           
                            counter++;
                        }
                        else
                        {
                            Bmole3.Source = "sora.png";
                            counter++;
                        }
                        break;
                }
            } while (counter < 10);
            gridMoleCheck();
            if (mole1 == "File: sora.png" && mole2 == "File: sora.png" && mole3 == "File: sora.png"
                && mole4 == "File: sora.png" && mole5 == "File: sora.png" && mole6 == "File: sora.png"
                && mole7 == "File: sora.png" && mole8 == "File: sora.png" && mole9 == "File: sora.png"
                )
            {
                counter = 1;
                showPics();
            }
        }

        private void gridMoleCheck()
        {
            mole1 = Tmole1.Source.ToString();
            mole2 = Tmole2.Source.ToString();
            mole3 = Tmole3.Source.ToString();

            mole4 = Mmole1.Source.ToString();
            mole5 = Mmole2.Source.ToString();
            mole6 = Mmole3.Source.ToString();

            mole7 = Bmole1.Source.ToString();
            mole8 = Bmole2.Source.ToString();
            mole9 = Bmole3.Source.ToString();
            
        }
        private async void Clicked(object sender, EventArgs e)
        {
            ImageButton imgbtn = (ImageButton)sender;
            string moleHolder = imgbtn.Source.ToString();
            if (moleHolder == "File: sora.png")
            {
                Score_1++;
                score.Text = "Score: " + Score_1.ToString();
                showPics();

            }
          

            else
            {
                if (Score_1 == 0)
                {
                    showPics();
                }
                else
                {
                    Score_1--;
                    score.Text = "Score: " + Score_1.ToString();
                    showPics();
                }
            }

            if (Score_1 == 10)
            {
                Stoptimer = true;
                Score_1 = 0;
                score.Text = "Score: " + Score_1.ToString();
                Task.Delay(1500);
                await Navigation.PushModalAsync(new Page1(Score_1));
                winMessage();
            }
            else if (Score_1 <= 0)
            {
                Stoptimer = true;
                Score_1 = 0;
                score.Text = "Score: " + Score_1.ToString();
                Task.Delay(1500);
                await Navigation.PushModalAsync(new Page1(Score_1));
                loseMessage();
            }

           
           
        }
        private async void winMessage()
        {
            await DisplayAlert("You win", "", "Thank you for playing");
        }
        private async void loseMessage()
        {
            await DisplayAlert("You Lose!", "", "Better luck next Time!");
        }
    }
}
