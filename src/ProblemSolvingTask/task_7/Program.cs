using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            
            string str;
            str= Console.ReadLine();
            char[] s = str.ToCharArray();
 
            int cnt = 0;
            for (int i = 1; i < n; i++)
            {
                if (s[i] == s[i - 1])
                {
                    cnt++;
                }
            }
 
            Console.WriteLine(cnt);
        }
    }
}