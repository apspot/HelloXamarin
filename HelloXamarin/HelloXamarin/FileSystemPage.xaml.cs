using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class FileSystemPage : ContentPage
    {
        public FileSystemPage()
        {
            InitializeComponent();
            var fileSystem = DependencyService.Get<IFileSystem>();
            fileSystem.WriteTextAsync("filesystemtest.txt", "File system test :)");
        }
    }
}
