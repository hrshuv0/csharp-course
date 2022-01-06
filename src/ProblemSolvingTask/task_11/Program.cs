using System;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(" ");
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = 0;
 
            while (a <= b)
            {
                a = a * 3;
                b = b * 2;
                c++;
            }
 
            Console.WriteLine(c);
        }
    }
}