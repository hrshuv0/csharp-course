string country = "Bangladesh";
char letter = 'D';

string part = country.Substring(4, 3);
Console.WriteLine(part);

Console.WriteLine(country[4]);

int position = country.IndexOf('d');
Console.WriteLine(position);

string[] parts = country.Split('l');
foreach(string p in parts)
    Console.WriteLine(p);

for(int i = 0; i< country.Length; i++)
{
    country = country.Replace(country[i], 'x');
}
Console.WriteLine(country);

Console.WriteLine(char.IsLetter(country[0]));


