using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Model;

namespace Pharmacy.Data;

public class PharmacyDbContext : DbContext
{
    private readonly string _connectionString;
    private readonly string _assemblyName;

    public PharmacyDbContext()
    {
        _connectionString = "Server=localhost;Database=CSharpB9;User Id=sa;Password=MSsql123#";;
        _assemblyName = Assembly.GetExecutingAssembly().FullName;;
    }
    protected PharmacyDbContext(string connectionString, string assemblyName)
    {
        _connectionString = connectionString;
        _assemblyName = assemblyName;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        if (!builder.IsConfigured)
        {
            builder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
        }
        base.OnConfiguring(builder);
    }


    public DbSet<Medicine> Medicines { get; set; }
    
}