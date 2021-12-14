using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
 
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int w = int.Parse(input[2]);
 
            int x = 0;
 
            for (int i = 1; i <= w; i++)
            {
                x += k * i;
            }
 
            if (x > n)
            {
                Console.WriteLine(x - n);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}