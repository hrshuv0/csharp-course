using Question1;

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter File Name as path: ");

string path = Console.ReadLine();
string cnv = "../../../DataPath/";

string[] str = DirectoryUtility.GetFileNames(cnv+path);

for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i]);
}

