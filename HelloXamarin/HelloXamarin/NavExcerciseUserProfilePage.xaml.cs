using HelloXamarin.Model;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class NavExcerciseUserProfilePage : ContentPage
    {
        private UserService service = new UserService();
        public User User { get; set; }

        public NavExcerciseUserProfilePage(int userId)
        {
            InitializeComponent();
            BindingContext = service.GetUser(userId);
        }
    }
}
