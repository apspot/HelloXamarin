using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage()
        {
            InitializeComponent();
        }

        void Handle_SwitchToggled(object sender, ToggledEventArgs e)
        {
            labelForSwitch.IsVisible = e.Value;
        }

        void Handle_SliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            labelForSlider.Text = e.NewValue.ToString();
        }

        void Handle_EntryCompleted(object sender, EventArgs e)
        {
            labelForEntry1.Text = "Completed";
        }

        void Handle_EntryTextChanged(object sender, TextChangedEventArgs e)
        {
            labelForEntry2.Text = e.NewTextValue;
        }

        void Handle_PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var contactMethod = picker.Items[picker.SelectedIndex];
            DisplayAlert("Selection", contactMethod, "OK");
        }

        void Handle_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Date selected", e.NewDate.ToString(), "OK");
        }
    }
}
