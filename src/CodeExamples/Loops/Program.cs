int count = 1;
for(int i = 0, j = 20; i < 20 && j > 0; i++, j--)
{
    count = (count + 1) * 2;
    Console.WriteLine(count);
}

count = 1;
for(int i = 20; i> 0; i--)
{
    count = (count + 1) * 2;
    Console.WriteLine(count);
}

int x = 5;
++x;
int y = x++;

while(y > 0)
{
    Console.WriteLine("Inside while loop");
    y--;
}

do
{
    Console.WriteLine("Inside do-while loop");
    y--;

} while (y > 0);

int[] ages = new int[] { 23, 49, 23, 40, 38 };
for(int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}

foreach(int age in ages)
{
    Console.WriteLine(age);
}

int[,] graph = new int[10, 10];
graph[0, 0] = 3;
graph[2, 3] = 4;

foreach(int i in graph)
{
    Console.WriteLine(i);
}




