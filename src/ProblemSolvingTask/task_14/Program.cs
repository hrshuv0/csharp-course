using System;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] s = str.ToCharArray();
 
            int l = str.Length;
 
            int up = 0;
            int lw = 0;
 
            for (int i = 0; i < l; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    up++;
                }
                else
                {
                    lw++;
                }
            }
 
            if (up > lw)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.ToLower());
            }
        }
    }
}