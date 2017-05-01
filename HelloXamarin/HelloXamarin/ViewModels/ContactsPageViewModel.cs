using HelloXamarin.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloXamarin.ViewModels
{
    public class ContactsPageViewModel : BaseViewModel
    {
        private ContactViewModel _selectedContact;
        private IContactStore _contactStore;
        private IPageService _pageService;
        private bool _isDataLoaded;

        public ObservableCollection<ContactViewModel> Contacts { get; private set; }
            = new ObservableCollection<ContactViewModel>(); //without this binding will throw NullReferenceException

        public ContactViewModel SelectedContact
        {
            get { return _selectedContact; }
            set { SetValue(ref _selectedContact, value); }
        }

        public ICommand LoadDataCommand { get; private set; }
        public ICommand AddContactCommand { get; private set; }
        public ICommand SelectContactCommand { get; private set; }
        public ICommand DeleteContactCommand { get; private set; }

        public ContactsPageViewModel(IContactStore contactStore, IPageService pageService)
        {
            _contactStore = contactStore;
            _pageService = pageService;
            LoadDataCommand = new Command(async () => await LoadData());
            AddContactCommand = new Command(async () => await AddContact());
            SelectContactCommand = new Command<ContactViewModel>(async c => await SelectContact(c));
            DeleteContactCommand = new Command<ContactViewModel>(async c => await DeleteContact(c));
            MessagingCenter.Subscribe<ContactDetailViewModel, Contact>(this, ContactEvents.ContactAdded, OnContactAdded);
            MessagingCenter.Subscribe<ContactDetailViewModel, Contact>(this, ContactEvents.ContactUpdated, OnContactUpdated);
        }

        private void OnContactAdded(ContactDetailViewModel source, Contact contact)
        {
            Contacts.Add(new ContactViewModel(contact));
        }

        private void OnContactUpdated(ContactDetailViewModel source, Contact contact)
        {
            var contactInList = Contacts.Single(c => c.Id == contact.Id);
            contactInList.Id = contact.Id;
            contactInList.FirstName = contact.FirstName;
            contactInList.LastName = contact.LastName;
            contactInList.Phone = contact.Phone;
            contactInList.Email = contact.Email;
            contactInList.IsBlocked = contact.IsBlocked;
        }

        private async Task LoadData()
        {
            if (_isDataLoaded)
                return;
            _isDataLoaded = true;
            var contacts = await _contactStore.GetContactsAsync();
            foreach (var c in contacts)
                Contacts.Add(new ContactViewModel(c));
        }

        private async Task AddContact()
        {
            await _pageService.PushAsync(new ContactDetailPage(new ContactViewModel()));
        }

        private async Task SelectContact(ContactViewModel contact)
        {
            if (contact == null)
                return;
            SelectedContact = null;
            await _pageService.PushAsync(new ContactDetailPage(contact));
        }

        private async Task DeleteContact(ContactViewModel contactViewModel)
        {
            if (await _pageService.DisplayAlert("Warning", $"Are you sure you want to delete {contactViewModel.FullName}?", "Yes", "No"))
            {
                Contacts.Remove(contactViewModel);
                var contact = await _contactStore.GetContact(contactViewModel.Id);
                await _contactStore.DeleteContact(contact);
            }
        }
    }
}
