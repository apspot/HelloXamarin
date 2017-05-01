using HelloXamarin.Persistence;
using HelloXamarin.ViewModels;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(ContactViewModel viewModel)
        {
            InitializeComponent();
            var contactStore = new SQLiteContactStore(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            BindingContext = new ContactDetailViewModel(viewModel ?? new ContactViewModel(), contactStore, pageService);
        }
    }
}
