using HelloXamarin.Model;
using HelloXamarin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ListExcercisePage : ContentPage
    {
        private SearchService service = new SearchService();

        public ListExcercisePage()
        {
            InitializeComponent();
            PopulateListView(service.GetSearches());
        }

        void Handle_Search(object sender, TextChangedEventArgs e)
        {
            PopulateListView(service.GetSearches(e.NewTextValue));
        }

        void Handle_Refresh(object sender, EventArgs e)
        {
            PopulateListView(service.GetSearches(searchBar.Text));
            listView.EndRefresh();
        }

        void Handle_Delete(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var rec = menuItem.CommandParameter as Search;
            var searchGroups = listView.ItemsSource as List<SearchGroup>;
            searchGroups[0].Remove(rec);
            service.DeleteSearch(rec.Id);
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var rec = (Search)e.Item;
            DisplayAlert("Tapped", rec.Location, "OK");
        }

        private void PopulateListView(IEnumerable<Search> searches)
        {
            listView.ItemsSource = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", searches)
            };
        }
    }
}
