using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Palindrome
    {
        public bool IsPalindrome(string text)
        {
            char[] str = text.ToLower().ToCharArray();
            Array.Reverse(str);

            string s = new string(str);
            Console.WriteLine(s);

            if (s == text.ToLower())
            {
                return true;
            }

            return false;
        }
    }
}
