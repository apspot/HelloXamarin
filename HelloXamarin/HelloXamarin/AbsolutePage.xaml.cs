using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();
            var layout = new AbsoluteLayout();
            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.All);
            Content = layout;
        }
    }
}
