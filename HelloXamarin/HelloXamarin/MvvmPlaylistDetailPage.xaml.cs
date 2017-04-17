using HelloXamarin.ViewModels;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MvvmPlaylistDetailPage : ContentPage
    {
        private PlaylistViewModel _playlist;

        public MvvmPlaylistDetailPage(PlaylistViewModel playlist)
        {
            _playlist = playlist;
            InitializeComponent();
            title.Text = _playlist.Title;
        }
    }
}
