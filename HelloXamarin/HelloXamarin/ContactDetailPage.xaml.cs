using HelloXamarin.ViewModels;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(ContactDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
