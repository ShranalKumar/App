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
            await CrossMedia.Current.Initialize();

            MediaFile carPic = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                PhotoSize = PhotoSize.Small,
                Directory = "sample",
                Name = $"{DateTime.UtcNow}.jpg"
            });

            if (carPic != null)
            {
                car.Source = ImageSource.FromStream(() => { return carPic.GetStream(); });
            }

            carTag.Text = "worked";
        }
    }
}
