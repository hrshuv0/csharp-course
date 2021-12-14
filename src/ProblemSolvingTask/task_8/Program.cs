using System;
using System.Linq;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str= Console.ReadLine();
 
            int cnt = str.Distinct().Count();
 
            if (cnt % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
}