using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
 
            for (int i = 0; i < 5; i++)
            {
                string str = Console.ReadLine();
 
                if (str.Contains("1"))
                {
                    int col = str.IndexOf("1", StringComparison.Ordinal);
                    int row = i;
 
                    x = Math.Abs(col / 2 - 2) + Math.Abs(row - 2);
                }
            }
            Console.WriteLine(x);
        }
    }
}