
using Pharmacy;
using Pharmacy.Controller;

Dashboard dashboard = new Dashboard();
dashboard.Display();

MedicineController medicine = new MedicineController();

while (true)
{
    Console.Write("\nEnter option: ");
    // char input = Char.ToLower(Console.ReadLine()[0]);

    char input;
    try
    {
        input = Char.ToLower(Console.ReadLine()[0]);
    }
    catch (Exception e)
    {
        continue;
    }

    switch (input)
    {
        case 'a':
            Console.WriteLine("a. Search medicine");
            medicine.Search();
            Console.WriteLine();
            dashboard.Display();
            break;
        case 'b':
            Console.WriteLine("b. Add Medicine");
            medicine.Create();
            Console.WriteLine();
            dashboard.Display();
            break;
        case 'c':
            Console.WriteLine("c. Update Medicine");
            medicine.Update();
            Console.WriteLine();
            dashboard.Display();
            break;
        case 'd':
            Console.WriteLine("d. Remove Medicine");
            medicine.Delete();
            dashboard.Display();
            break;
        case 'e':
            Console.WriteLine("e. Exit");
            return;
        default:
            dashboard.Display();
            Console.WriteLine("[warning] Enter option among [a-e]");
            Console.WriteLine();
            break;
    }

    
    
    
}