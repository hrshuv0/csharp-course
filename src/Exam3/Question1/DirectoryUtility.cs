using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class DirectoryUtility
    {
        public static string[] GetFileNames(string path)
        {
            IEnumerable<string> str = File.ReadLines(path);

            string[] arr = str.ToArray();

            return arr;
        }
    }
}
