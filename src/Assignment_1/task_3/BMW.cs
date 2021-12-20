namespace task_3;

public class BMW : Car
{
    public string Type { get; set; }
    public string RelaseDate { get; set; }

    public BMW(string type, string date) : base(type, date)
    {
        Type = type;
        RelaseDate = date;
    }
    
    public BMW(string brand) : base(brand)
    {
        Brand = brand;
    }
    
    public BMW(string brand, string model, int price) : base(brand, model, price)
    {
        this.Brand = brand;
        this.Model = model;
        this.Price = price;
    }

    public void MyCar()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Price: " + Price + "\n");
    }
    public void MyCar(string type, string date)
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Type : " + type);
        Console.WriteLine("Date : " + date + "\n");
    }

    
    
    
}