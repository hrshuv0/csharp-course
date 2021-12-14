using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////first method start ///////////////
            string str;
            str= Console.ReadLine();
            char[] s = str.ToCharArray();
 
            int cnt = 1, mx = 1, l = str.Length;
 
            for (int i = 1; i < l; i++)
            {
                if (s[i] == s[i - 1])
                {
                    cnt++;
                }
                else
                {
                    cnt = 1;
                }
                mx = Math.Max(mx, cnt);
            }
 
            if (mx > 6)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
            //////////////// first method end //////////////

            
            //this is solution of another way. remove comment to execute
            
            // AnotherWay anotherWay = new AnotherWay();       
            // anotherWay.Myprogram();
        }
    }
}