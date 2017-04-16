using System;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(HelloXamarin.iOS.FileSystem))]

namespace HelloXamarin.iOS
{
    public class FileSystem : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docsPath, fileName);
            using (var writer = File.CreateText(path))
            {
                await writer.WriteAsync(text);
            }
        }
    }
}