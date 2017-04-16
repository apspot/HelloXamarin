using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class NavSimpleDetailPage : ContentPage
    {
        public NavSimpleDetailPage(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(); //defensive programming

            BindingContext = contact;

            InitializeComponent();
        }
    }
}
