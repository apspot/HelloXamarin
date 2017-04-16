using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public partial class RestfulPage : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _posts;

        public RestfulPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            _posts = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _posts;
            base.OnAppearing();
        }

        void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post { Title = "Title " + DateTime.Now.Ticks };
            _posts.Insert(0, post); //optimistic: see the result immediately, but the server call may fail
            var content = JsonConvert.SerializeObject(post);
            _client.PostAsync(Url, new StringContent(content));
        }

        void OnUpdate(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            post.Title += " UPDATED"; //TODO: we have to implement INotifyDatasetChanged to see the changes
            var content = JsonConvert.SerializeObject(post);
            _client.PutAsync(Url + "/" + post.Id, new StringContent(content));
        }

        void OnDelete(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            _posts.Remove(post);
            _client.DeleteAsync(Url + "/" + post.Id);
        }
    }
}
