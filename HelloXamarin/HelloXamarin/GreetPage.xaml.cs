using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;
            /*Content = new Label()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Hello world!"
            };*/
            /*if (Device.OS == TargetPlatform.Windows)
                Padding = new Thickness(0, 20, 0, 0);

            Padding = Device.OnPlatform(
                iOS: new Thickness(0, 20, 0, 0),
                Android: new Thickness(0, 20, 0, 0),
                WinPhone: new Thickness(0, 20, 0, 0)
            );

            Device.OnPlatform(
                iOS: () => { Padding = new Thickness(0, 20, 0, 0); }
            );*/
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello world!", "OK");
        }

        void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}
