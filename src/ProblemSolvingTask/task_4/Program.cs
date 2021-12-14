using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str= Console.ReadLine();
            char[] stra = str.ToCharArray();
            str = Console.ReadLine();
            char[] strb = str.ToCharArray();
            
            int l = stra.Length;
 
            for (int i = 0; i < l; i++)
            {
                char a = Char.ToLower(stra[i]);
                char b = Char.ToLower(strb[i]);
 
                if (a < b)
                {
                    Console.WriteLine(-1);
                    return;
                }
                else if (a > b)
                {
                    Console.WriteLine(1);
                    return;
                }
            }
            Console.WriteLine(0);
        }
    }
}