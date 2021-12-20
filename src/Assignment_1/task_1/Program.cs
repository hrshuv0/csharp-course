// See https://aka.ms/new-console-template for more information

using task_1;

Console.WriteLine("Hello, Assignment 1 !\n");

Area area = new Area(3, 8);
Console.WriteLine("area of square: " + area.area());
Console.WriteLine("area of circle: " + area.area(3) + "\n");

Perimeter perimeter = new Perimeter(3, 8);
Console.WriteLine("perimeter of square: " + perimeter.area());
Console.WriteLine("perimeter of circle: " + perimeter.area(3));

