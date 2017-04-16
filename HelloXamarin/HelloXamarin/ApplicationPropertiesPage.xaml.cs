using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ApplicationPropertiesPage : ContentPage
    {
        public ApplicationPropertiesPage()
        {
            InitializeComponent();
            BindingContext = (App)Application.Current;
            /*if (Application.Current.Properties.ContainsKey("Name"))
                title.Text = Application.Current.Properties["Name"].ToString();
            if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
                notificationsEnabled.On = (bool)Application.Current.Properties["NotificationsEnabled"];*/
        }

        /*void OnChanged(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["NotificationsEnabled"] = notificationsEnabled.On;
            Application.Current.SavePropertiesAsync();
        }

        protected override void OnDisappearing() //itt is le lehetne menteni
        {
            base.OnDisappearing();
        }*/
    }
}
