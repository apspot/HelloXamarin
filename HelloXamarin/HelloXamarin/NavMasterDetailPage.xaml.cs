using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class NavMasterDetailPage : MasterDetailPage
    {
        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new NavSimpleDetailPage(contact));
            IsPresented = false;
        }

        public NavMasterDetailPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact> {
                new Contact { Name = "Peter", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
            };
        }
    }
}
