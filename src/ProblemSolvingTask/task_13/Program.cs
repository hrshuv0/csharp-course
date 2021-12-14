using System;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(" ");
            int n = int.Parse(str[0]);
            // int k = int.Parse(str[1]);
 
            int cnt = 0;
 
            if (n % 5 == 0)
            {
                cnt = n / 5;
            }
            else
            {
                cnt = n / 5 + 1;
            }
            
            Console.WriteLine(cnt);
        }
    }
}