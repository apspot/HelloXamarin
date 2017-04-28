using HelloXamarin.Model;
using HelloXamarin.Services;
using System;
using System.Linq;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MoviesPage : ContentPage
    {
        private MovieService _service = new MovieService();

        private BindableProperty IsSearchingProperty =
            BindableProperty.Create("IsSearching", typeof(bool), typeof(MoviesPage), false);
        public bool IsSearching
        {
            get { return (bool)GetValue(IsSearchingProperty); }
            set { SetValue(IsSearchingProperty, value); }
        }

        public MoviesPage()
        {                        
            IsSearching = false;
            BindingContext = this;
            InitializeComponent();
        }

        async void Search(object sender, TextChangedEventArgs e)
        {
            notFound.IsVisible = false;
            listView.IsVisible = false;
            if (e.NewTextValue == null || e.NewTextValue.Replace(" ", "").Length < MovieService.MinSearchLength)
                return;
            try
            {
                IsSearching = true;                
                var movies = await _service.FindMoviesByActor(e.NewTextValue);
                listView.ItemsSource = movies;
                listView.IsVisible = movies.Any();
                notFound.IsVisible = !listView.IsVisible;
            }
            catch (Exception)
            {
                notFound.IsVisible = true;
                listView.IsVisible = false;
            }
            finally
            {
                IsSearching = false;
            }
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            var movie = e.Item as Movie;
            listView.SelectedItem = null;
            await Navigation.PushAsync(new MovieDetailsPage(movie));
        }
    }
}
