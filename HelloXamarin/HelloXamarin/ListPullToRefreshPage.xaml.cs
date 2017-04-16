using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ListPullToRefreshPage : ContentPage
    {
        public ListPullToRefreshPage()
        {
            InitializeComponent();
            listView.ItemsSource = GetContacts();
        }

        void Handle_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            listView.IsRefreshing = false;
            listView.EndRefresh();
        }

        List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact { Name = "Peter", Status = "status1", ImageUrl = "http://lorempixel.com/100/100/cats/1" },
                new Contact { Name = "John", Status = "status2", ImageUrl = "http://lorempixel.com/100/100/cats/2" },
                new Contact { Name = "Spot", Status = "status3", ImageUrl = "http://lorempixel.com/100/100/cats/3" }
            };
        }
    }    
}
