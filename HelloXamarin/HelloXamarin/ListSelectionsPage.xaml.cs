using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ListSelectionsPage : ContentPage
    {
        public ListSelectionsPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Peter", Status = "status1", ImageUrl = "http://lorempixel.com/100/100/cats/1" },
                new Contact { Name = "John", Status = "status2", ImageUrl = "http://lorempixel.com/100/100/cats/2" },
                new Contact { Name = "Spot", Status = "status3", ImageUrl = "http://lorempixel.com/100/100/cats/3" }
            };
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
            //var contact = (Contact)e.SelectedItem;
            //DisplayAlert("Selected", contact.Name, "OK");
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = (Contact)e.Item;
            DisplayAlert("Tapped", contact.Name, "OK");
        }
    }
}
