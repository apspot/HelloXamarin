using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ToolbarItemsPage : ContentPage
    {
        public ToolbarItemsPage()
        {
            InitializeComponent();
        }

        void Handle_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "Item activated", "Cancel");
        }
    }
}
