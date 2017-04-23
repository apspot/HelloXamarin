using HelloXamarin.Model;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class NavExcerciseActivityFeedPage : ContentPage
    {
        private ActivityService service = new ActivityService();

        public NavExcerciseActivityFeedPage()
        {
            InitializeComponent();
            listView.ItemsSource = service.GetActivities();
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var rec = (Activity)e.Item;
            Navigation.PushAsync(new NavExcerciseUserProfilePage(rec.UserId));
        }
    }
}
