using System;

namespace task_9
{
    public class AnotherWay
    {
        public void Myprogram()
        {
            string str;
            str= Console.ReadLine();
 
            if (str.Contains("1111111") || str.Contains("0000000"))
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