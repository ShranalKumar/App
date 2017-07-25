using System;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace MyApp
{
    public partial class MyAppPage : ContentPage
    {
        public MyAppPage()
        {
            InitializeComponent();
        }

        async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            MediaFile carPic = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                PhotoSize = PhotoSize.Medium,
                Directory = "sample",
                Name = $"{DateTime.UtcNow}.jpg"
            });

            car.Source = ImageSource.FromStream(() => { return carPic.GetStream(); });
        }
    }
}
