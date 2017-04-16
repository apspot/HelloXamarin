using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ListSearchBarPage : ContentPage
    {
        public ListSearchBarPage()
        {
            InitializeComponent();
            listView.ItemsSource = GetContacts();
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue); //ilyen is van: e.OldTextValue
        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "Peter", Status = "status1", ImageUrl = "http://lorempixel.com/100/100/cats/1" },
                new Contact { Name = "John", Status = "status2", ImageUrl = "http://lorempixel.com/100/100/cats/2" },
                new Contact { Name = "Spot", Status = "status3", ImageUrl = "http://lorempixel.com/100/100/cats/3" }
            };
            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;
            return contacts.Where(c => c.Name.ToLower().StartsWith(searchText.ToLower())).ToList();
        }
    }
}
