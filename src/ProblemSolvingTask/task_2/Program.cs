using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
 
            int cnt = 0;
            for (int i = 0; i < x; i++)
            {
                string str;
                str = Console.ReadLine();
                char[] s = str.ToCharArray();
 
                if (s[1] == '+')
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                }
            }
            
            Console.WriteLine(cnt);
        }
    }
}