using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class PopupsPage : ContentPage
    {
        public PopupsPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_Alert(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            if (response)
                await DisplayAlert("Done", "Your response will be saved", "OK");
        }

        async void Handle_Clicked_Actionsheet(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy link", "Message");
            await DisplayAlert("Response", response, "OK");
        }
    }
}
