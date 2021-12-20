namespace task_3;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Price { get; set; }

    public Car(string brand, string model, int price)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public Car(string brand)
    {
        Brand = brand;
    }
    
    public void MyCar()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Price: " + Price + "\n");
    }

    public void MyCar(double price)
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Price: " + price + "\n");
    }

    public void MyCar(string model, double price)
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Price: " + price + "\n");
    }






}