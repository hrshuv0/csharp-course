// See https://aka.ms/new-console-template for more information

using System.Globalization;
using task_2;

Console.WriteLine("Hello, Task 2!\n");

double[] arr = {2, 7, 3, 7, 6};

var a = Calculator.average(12, 6);
var b = Calculator.average(3, 6, 11);
var c = Calculator.average(arr);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
