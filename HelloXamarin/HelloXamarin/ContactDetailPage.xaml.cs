using HelloXamarin.Model;
using System;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ContactDetailPage : ContentPage
    {
        public event EventHandler<Contact> ContactAdded;
        public event EventHandler<Contact> ContactUpdated;

        public ContactDetailPage(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));
            InitializeComponent();
            BindingContext = new Contact //save data only at save button press
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone,
                Email = contact.Email,
                IsBlocked = contact.IsBlocked
            };
        }

        async void OnSave(object sender, EventArgs e)
        {
            var contact = BindingContext as Contact;
            if (String.IsNullOrWhiteSpace(contact.FullName))
            {
                await DisplayAlert("Error", "Please enter the name.", "OK");
                return;
            }
            if (contact.Id == 0)                
                ContactAdded?.Invoke(this, contact);
            else
                ContactUpdated?.Invoke(this, contact);
            await Navigation.PopAsync();
        }
    }
}
