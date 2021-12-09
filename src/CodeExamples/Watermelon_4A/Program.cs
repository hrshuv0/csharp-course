using System;

public class Program
{
    public static void Main(string[] args)
    {
        string line = Console.ReadLine();
        int w = int.Parse(line);

        if (w % 2 == 1)
            Console.WriteLine("NO");
        else if(w == 2)
            Console.WriteLine("NO");
        else
            Console.WriteLine("YES");
    }
}