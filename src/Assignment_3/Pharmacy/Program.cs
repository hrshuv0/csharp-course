
using Pharmacy;

Dashboard dashboard = new Dashboard();
dashboard.Display();

while (true)
{
    var input = Char.ToLower(Console.ReadLine()[0]);
    

    switch (input)
    {
        case 'a':
            Console.WriteLine("a. Search medicine");
            break;
        case 'b':
            Console.WriteLine("b. Add Medicine");
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
            Console.WriteLine("among [a-e]");
            break;
    }

    
    
    
}