using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MessagingCenterTargetPage : ContentPage
    {
        public MessagingCenterTargetPage()
        {
            InitializeComponent();
        }

        void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            MessagingCenter.Send(this, "SliderValueChanged", e.NewValue);
        }
    }
}
