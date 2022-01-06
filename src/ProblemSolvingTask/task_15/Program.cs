using System;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
 
            int x = 0, mx = 0;
            for (int k = 0; k < n; k++)
            {
                var str = Console.ReadLine().Split(" ");
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
 
                x += b - a;
 
                mx = Math.Max(x, mx);
            }
 
            Console.WriteLine(mx);
        }
    }
}