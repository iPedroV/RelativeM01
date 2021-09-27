using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RelativeM01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void T1(object sender, EventArgs e)
        {
            img1.Opacity = 0.5;
            await Task.Delay(200);
            img1.Opacity = 1;
            await DisplayAlert("SALVE", "SALVE", "OK");
        }
    }
}
