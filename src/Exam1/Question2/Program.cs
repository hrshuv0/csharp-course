// See https://aka.ms/new-console-template for more information

using Question2;

Console.WriteLine("Hello, World!");


FactorCalculator f = new FactorCalculator();

int[] arr = FactorCalculator.FindFactors(144);

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}