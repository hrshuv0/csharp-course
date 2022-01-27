using Pharmacy.Data;
using Pharmacy.Model;

namespace Pharmacy.Controller;

public class MedicineController
{
    private PharmacyDbContext _dbContext = new PharmacyDbContext();
    
    public void Create()
    {
        Medicine medicine = new Medicine();
        
        medicine.Name = Console.ReadLine();
        medicine.Quantity = Convert.ToInt32(Console.ReadLine());

        _dbContext.Add(medicine);
        _dbContext.SaveChanges();
        Console.WriteLine("Medecine \"" + medicine.Name + "\" with Quantity \"" + medicine.Quantity + "\" added Successfully!");
    }
}