using System;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
 
            if (str.Contains('H') || str.Contains('Q'))
            {
                Console.WriteLine("YES");
            }
            else if (str.Contains('9'))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}