using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str= Console.ReadLine();
            char[] s = str.ToCharArray();
            
            int l = str.Length;
 
            int one = 0;
            int two = 0;
            int tre = 0;
 
            for (int i = 0; i < l; i++)
            {
                if (s[i] == '1')
                {
                    one++;
                }
                else if (s[i] == '2')
                {
                    two++;
                }
                else if (s[i] == '3')
                {
                    tre++;
                }
            }
 
            if (one > 0)
            {
                Console.Write(1);
            }
            for (int i = 1; i < one; i++)
            {
                Console.Write('+');
                Console.Write('1');
            }
 
            if (two > 0 && one == 0)
            {
                Console.Write('2');
            }
            else if (two > 0)
            {
                Console.Write('+');
                Console.Write('2');
            }
 
            for (int i = 1; i < two; i++)
            {
                Console.Write('+');
                Console.Write('2');
            }
            
            if (tre > 0 && two == 0 && one == 0)
            {
                Console.Write('3');
            }
            else if (tre > 0)
            {
                Console.Write('+');
                Console.Write('3');
            }
 
            for (int i = 1; i < tre; i++)
            {
                Console.Write('+');
                Console.Write('3');
            }
        }
    }
}