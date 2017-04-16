using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class CarouselTestPage : CarouselPage
    {
        public CarouselTestPage()
        {
            InitializeComponent();
            Children.Add(new ContentPage());
        }
    }
}
