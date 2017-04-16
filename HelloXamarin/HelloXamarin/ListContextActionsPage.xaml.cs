using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ListContextActionsPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        public ListContextActionsPage()
        {
            InitializeComponent();
            listView.ItemsSource = _contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Peter", Status = "status1", ImageUrl = "http://lorempixel.com/100/100/cats/1" },
                new Contact { Name = "John", Status = "status2", ImageUrl = "http://lorempixel.com/100/100/cats/2" },
                new Contact { Name = "Spot", Status = "status3", ImageUrl = "http://lorempixel.com/100/100/cats/3" },
                new Contact { Name = "Michael", Status = "status4", ImageUrl = "http://lorempixel.com/100/100/cats/4" }
            };
        }

        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");            
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            _contacts.Remove(contact);
        }
    }
}
