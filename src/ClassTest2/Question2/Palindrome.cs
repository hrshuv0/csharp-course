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
            char[] str = text.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Char.ToLower(str[i]);
            }
            Array.Reverse(str);

            string s = new string(str);

            if (s == text)
            {
                return true;
            }

            return false;
        }
    }
}
