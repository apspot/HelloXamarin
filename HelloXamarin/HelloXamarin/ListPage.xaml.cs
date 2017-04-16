using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            var names = new List<String>
            {
                "Peter",
                "John",
                "Bob"
            };
            listView.ItemsSource = names;
        }
    }
}
