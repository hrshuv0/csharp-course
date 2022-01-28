using Pharmacy.Data;
using Pharmacy.Model;

namespace Pharmacy.Controller;

public class MedicineController
{
    private PharmacyDbContext _dbContext = new PharmacyDbContext();
    
    public void Create()
    {
        Medicine medicine = new Medicine();

        Console.WriteLine("Enter medicine name: ");
        medicine.Name = Console.ReadLine();
        Console.WriteLine("Enter medicine quantity: ");
        medicine.Quantity = Convert.ToInt32(Console.ReadLine());

        _dbContext.Add(medicine);
        _dbContext.SaveChanges();
        Console.WriteLine("Medecine \"" + medicine.Name + "\" with Quantity \"" + medicine.Quantity + "\" added Successfully!");
    }
    
    public void Search()
    {
        Console.Write("Enter medicine name to search: ");
        string name = Console.ReadLine();

        var medicines = from m in _dbContext.Medicines select m;

        if (!String.IsNullOrEmpty(name))
        {
            medicines = medicines.Where(m => m.Name != null && m.Name.Contains(name));

            if (!medicines.Any())
            {
                Console.WriteLine("Not Found any medicine with " + name + " keyword, Add new");
                Create();
                return;
            }
        }
        else
        {
            Search();
            return;
        }

        Console.WriteLine("\n  Medicine Name       Quantity");
        foreach (var m in medicines)
        {
            Console.Write("      " + m.Name);
            if (m.Name != null)
                for (var i = 0; i < 20 - m.Name.Length; i++)
                {
                    Console.Write(" ");
                }

            Console.WriteLine(m.Quantity);
        }

    }

    public void Update()
    {
        Console.Write("Enter medicine name: ");
        string? name = Console.ReadLine();

        // Medicine medicine = _dbContext.Medicines.FirstOrDefault(m => m.Name.Contains(name));
        Medicine? medicine = _dbContext.Medicines.FirstOrDefault(m => m.Name == name);

        Console.WriteLine(medicine.Name);
        
        Medicine newMedicine = new Medicine();

        Console.WriteLine("Enter medicine name: ");
        newMedicine.Name = Console.ReadLine();
        Console.WriteLine("Enter medicine quantity: ");
        newMedicine.Quantity = Convert.ToInt32(Console.ReadLine());

        medicine.Name = newMedicine.Name;
        medicine.Quantity = newMedicine.Quantity;

        _dbContext.SaveChanges();

        Console.WriteLine("Medicine updated successfully!");
    }

    public void Delete()
    {
        Console.Write("Enter medicine name: ");
        string? name = Console.ReadLine();

        Medicine medicine = _dbContext.Medicines.FirstOrDefault(m => m.Name != null && m.Name.Contains(name));
        _dbContext.Remove(medicine);
        _dbContext.SaveChanges();
        
        Console.WriteLine("Medicine Deleted successfully!");
    }
    
    
}