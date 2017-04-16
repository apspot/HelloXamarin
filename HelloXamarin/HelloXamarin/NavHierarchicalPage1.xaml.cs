using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class NavHierarchicalPage1 : ContentPage
    {
        public NavHierarchicalPage1()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavHierarchicalPage2());
        }
    }
}
