using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ResourceDictionaryPage : ContentPage
    {
        public ResourceDictionaryPage()
        {
            InitializeComponent();
            /*this.Resources = new ResourceDictionary();
            this.Resources["borderRadius"] = 20;*/
        }

        void ChangeStyle(object sender, EventArgs e)
        {
            Resources["buttonBackgroundColor"] = Color.Pink;
        }
    }
}
