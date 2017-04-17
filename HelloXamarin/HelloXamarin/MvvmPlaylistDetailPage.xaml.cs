using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MvvmPlaylistDetailPage : ContentPage
    {
        private Playlist _playlist;

        public MvvmPlaylistDetailPage(Playlist playlist)
        {
            _playlist = playlist;
            InitializeComponent();
            title.Text = _playlist.Title;
        }
    }
}
