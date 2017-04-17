using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MessagingCenterPage : ContentPage
    {
        private double SliderValue = 0;

        public MessagingCenterPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Unsubscribe<MessagingCenterPage>(this, "SliderValueChanged");
            base.OnAppearing();
        }

        void OnClick(object sender, EventArgs e)
        {
            var page = new MessagingCenterTargetPage();
            MessagingCenter.Subscribe<MessagingCenterTargetPage, double>(this, "SliderValueChanged", OnSliderValueChanged);
            Navigation.PushAsync(page);
        }

        private void OnSliderValueChanged(MessagingCenterTargetPage source, double newValue)
        {
            label.Text = newValue.ToString();
        }
    }
}
