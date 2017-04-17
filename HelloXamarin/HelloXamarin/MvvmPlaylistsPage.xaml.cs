using HelloXamarin.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MvvmPlaylistsPage : ContentPage
    {
        public MvvmPlaylistsPage()
        {
            InitializeComponent();
            ViewModel = new PlaylistsViewModel(new PageService());
        }

        protected override void OnAppearing()
        {
            //ViewModel.LoadPlaylists.Execute(); //we can call the webserver here
            base.OnAppearing();
        }

        void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectPlaylistCommand.Execute(e.SelectedItem);
        }

        private PlaylistsViewModel ViewModel
        {
            get { return BindingContext as PlaylistsViewModel; }
            set { BindingContext = value; }
        }
    }
}
