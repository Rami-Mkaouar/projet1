using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace hhh
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            //im1.TranslateTo(0, 20, 2000, Easing.BounceIn);
            //im2.ScaleTo(360, 280, Easing.CubicIn);

        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            //DisplayAlert("LogIn", "welcome", "ok");
          /*  var answer = await DisplayAlert("question", "would you like to go to page 2", "yes", "no");
            if (answer == true)
            {
                await this.Navigation.PushAsync(new Page3());
            }*/
            if (e1.Text != "0000" && e2.Text != "0000")
            {
                DisplayAlert("alert", "wrong", "ok");
                wrong.TextColor = Color.Red;
                await Task.Delay(2000);
                wrong.TextColor = Color.White;

            }
            else
            {
                await Navigation.PushAsync(new Page3());
                wrong.TextColor = Color.Red;

            }
        }
    }
}
