int x = 5;
int y = 10;
int z = x + y;



int Formula(int x, int y, int z)
{
    int t = 5;
    int v = 10;
    int r = 10;
    return x * t + y * v + z / r;
}

void PrintResult(int r)
{
    Console.WriteLine(r);
}

int t = Formula(2, 4, 10);
int t2 = Formula(3, 5, 30);

PrintResult(5);
PrintResult(t);
PrintResult(t2);
PrintResult(Formula(2, 2, 2));


if (t > 100)
{
    Console.WriteLine("T is greater than 100");
}
else if (t < 100)
{
    Console.WriteLine("T is smaller than 100");
}
else
{
    int p = 2;
    Console.WriteLine("T is 100");
}

string message = t > 100 ? "T is greater than 100" : "T is not greater than 100";

switch (t)
{
    case 100:
        Console.WriteLine("T is 100");
        break;
    case 101:
        Console.WriteLine("T is 101");
        break;
    default:
        Console.WriteLine("No match found");
        break;
}