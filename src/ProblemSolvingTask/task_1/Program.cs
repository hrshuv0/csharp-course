using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                string str = Console.ReadLine();
                char[] s = str.ToCharArray();

                int l = s.Length;
                if (l > 10)
                {
                    Console.Write(s[0]);
                    Console.Write(l-2);
                    Console.WriteLine(s[l-1]);
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}