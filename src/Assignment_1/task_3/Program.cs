// See https://aka.ms/new-console-template for more information

using task_3;

Console.WriteLine("Hello, Task 3!\n");

Car car1 = new Car("Toyota", "Corolla", 2);
car1.MyCar();

Car car2 = new Car("Rolls Royce", "Phantom");
car2.MyCar(3.7);

Car car3 = new Car("Jaguar");
car3.MyCar("XK", 1.9);

Console.WriteLine("-------------------------------------------");

BMW bmw1 = new BMW("Audi", "Q-7", 7);
bmw1.MyCar("Zip", "2-nov");

BMW bmw2 = new BMW("old brand", "new model", 9);
bmw2.MyCar();