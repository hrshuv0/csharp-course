﻿
using Pharmacy;
using Pharmacy.Controller;

Dashboard dashboard = new Dashboard();
dashboard.Display();

MedicineController medicine = new MedicineController();

while (true)
{
    Console.Write("\nEnter option: ");
    char input = Char.ToLower(Console.ReadLine()[0]);
    

    switch (input)
    {
        case 'a':
            Console.WriteLine("a. Search medicine");
            break;
        case 'b':
            Console.WriteLine("b. Add Medicine");
            medicine.Create();
            break;
        case 'c':
            Console.WriteLine("c. Update Medicine");
            break;
        case 'd':
            Console.WriteLine("d. Remove Medicine");
            break;
        case 'e':
            Console.WriteLine("e. Exit");
            return;
        default:
            dashboard.Display();
            Console.WriteLine("[warning] Enter option among [a-e]");
            break;
    }

    
    
    
}