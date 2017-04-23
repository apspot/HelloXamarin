using HelloXamarin.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ContactsPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Contact> _contacts;
        private bool _firstAppear = true;

        public ContactsPage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection("Contacts.sqlite");
        }

        protected override async void OnAppearing()
        {
            if (_firstAppear)
            {
                _firstAppear = false;
                await _connection.CreateTableAsync<Contact>();
                var contacts = await _connection.Table<Contact>().ToListAsync();
                _contacts = new ObservableCollection<Contact>(contacts);
                listView.ItemsSource = _contacts;
            }
            base.OnAppearing();
        }

        async void Handle_Add(object sender, EventArgs e)
        {
            var page = new ContactDetailPage(new Contact());
            page.ContactAdded += async (source, contact) =>
            {
                await _connection.InsertAsync(contact);
                _contacts.Add(contact);
            };
            await Navigation.PushAsync(page);
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedContact = e.Item as Contact;
            listView.SelectedItem = null;
            var page = new ContactDetailPage(selectedContact);
            page.ContactUpdated += (source, contact) =>
            {
                selectedContact.Id = contact.Id;
                selectedContact.FirstName = contact.FirstName;
                selectedContact.LastName = contact.LastName;
                selectedContact.Phone = contact.Phone;
                selectedContact.Email = contact.Email;
                selectedContact.IsBlocked = contact.IsBlocked;
                _connection.UpdateAsync(selectedContact);
            };
            await Navigation.PushAsync(page);
        }

        async void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            if (await DisplayAlert("Warning", $"Are you sure you want to delete {contact.FullName}?", "Yes", "No"))
            {
                _contacts.Remove(contact);
                await _connection.DeleteAsync(contact);
            }
        }
    }
}
