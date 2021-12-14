using System;

namespace task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] s = str.ToCharArray();
            string h = "hello";
            char[] hello = h.ToCharArray();
 
            int cnt = 0, l = str.Length;
            for (int i = 0, j = 0; i < l; i++)
            {
                if (s[i] == hello[j])
                {
                    j++;
                    cnt++;
                }
 
                if (cnt == 5)
                {
                    break;
                }
            }
 
 
            if (cnt == 5)
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