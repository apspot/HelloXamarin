using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class NavHierarchicalPage2 : ContentPage
    {
        public NavHierarchicalPage2()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
