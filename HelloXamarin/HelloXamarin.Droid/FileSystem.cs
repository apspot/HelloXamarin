using System;
using Android.OS;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(HelloXamarin.Droid.FileSystem))]

namespace HelloXamarin.Droid
{
    public class FileSystem : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docsPath, fileName);
            using (var writer = File.CreateText(path))
            {
                await writer.WriteAsync(text);
            }
        }
    }
}