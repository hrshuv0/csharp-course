using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str= Console.ReadLine();
            char[] s = str.ToCharArray();
            
            int l = str.Length;
 
            string vowel = "aeiouy";
 
            for (int i = 0; i < l; i++)
            {
                char x = Char.ToLower(s[i]);
 
                if (vowel.Contains(x))
                {
                    // Console.Write('.');
                }
                else
                {
                    Console.Write('.');
                    Console.Write(x);
                }
            }
        }
    }
}