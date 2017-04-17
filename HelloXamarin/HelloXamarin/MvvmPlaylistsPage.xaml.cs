﻿using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MvvmPlaylistsPage : ContentPage
    {
        private ObservableCollection<Playlist> _playlists = new ObservableCollection<Playlist>();

        public MvvmPlaylistsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            playlistsListView.ItemsSource = _playlists;
            base.OnAppearing();
        }

        void OnAddPlaylist(object sender, System.EventArgs e)
        {
            var newPlaylist = "Playlist " + (_playlists.Count + 1);
            _playlists.Add(new Playlist { Title = newPlaylist });
            this.Title = $"{_playlists.Count} Playlists";
        }

        void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var playlist = e.SelectedItem as Playlist;
            playlist.IsFavorite = !playlist.IsFavorite;
            playlistsListView.SelectedItem = null;
            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
