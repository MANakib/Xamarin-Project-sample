using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DefuseBomb
{
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        static int Scores = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == bomb)
            {
                await DisplayAlert("Bomb Exploded", "Game Over", "Retry");
                bomb = new Random().Next(1, 4).ToString();
            }
            else
            {
                Scores += 1;
                await DisplayAlert("Bomb Defused", "Scores: " + Scores, "Continue");
                bomb = new Random().Next(1, 4).ToString();
            }
        }
    }
}
