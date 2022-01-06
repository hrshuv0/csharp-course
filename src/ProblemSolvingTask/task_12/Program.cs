using System;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(" ");
            int n = int.Parse(str[0]);
            int k = int.Parse(str[1]);
            
 
            while (k > 0)
            {
                k--;
 
                if (n % 10 == 0)
                {
                    n = n / 10;
                }
                else
                {
                    n--;
                }
            }
 
            Console.WriteLine(n);
        }
    }
}