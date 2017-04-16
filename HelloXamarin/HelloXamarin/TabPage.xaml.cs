using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();
            this.Children.Add(new ListPage());
        }
    }
}
