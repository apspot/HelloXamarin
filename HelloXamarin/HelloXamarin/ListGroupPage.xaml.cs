using HelloXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ListGroupPage : ContentPage
    {
        public ListGroupPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("M", "M")
                {
                    new Contact { Name = "Peter", Status = "status1", ImageUrl = "http://lorempixel.com/100/100/cats/1" },
                    new Contact { Name = "Michael", Status = "status4", ImageUrl = "http://lorempixel.com/100/100/cats/4" }
                },
                new ContactGroup("J", "J")
                {
                    new Contact { Name = "John", Status = "status2", ImageUrl = "http://lorempixel.com/100/100/cats/2" }
                },
                new ContactGroup("S", "S")
                {
                    new Contact { Name = "Spot", Status = "status3", ImageUrl = "http://lorempixel.com/100/100/cats/3" }
                }                
            };
        }
    }
}
