using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin
{
    public interface IFileSystem
    {
        Task WriteTextAsync(string fileName, string text);
    }
}
