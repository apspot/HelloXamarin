using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //var imageSource = (UriImageSource)ImageSource.FromUri(new Uri("http://lorempixel.com/192/180/sports/7"));
            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/192/180/sports/7") };
            //imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);
            //image.Source = imageSource;
            //image.Source = "http://lorempixel.com/192/180/sports/7"; //ezt automatikusan UriImageSource-á konvertálja
            //image.Aspect = Aspect.AspectFill;
            //image.Source = ImageSource.FromResource("HelloXamarin.Images.background.jpg");
        }
    }
}
