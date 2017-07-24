using System;
using Xamarin.Forms;

namespace MyApp
{
    public partial class MyAppPage : ContentPage
    {
        public MyAppPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("button", "it worked", "close");
        }
    }
}
