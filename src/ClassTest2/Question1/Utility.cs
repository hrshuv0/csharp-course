using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Utility
    {
        public static string Reverse(string text)
        {
            char[] str = text.ToCharArray();
            Array.Reverse(str);

            text = new string(str);
            return text;
        }
    }
}
