using Inventory.Data.SeedData;
using Inventory.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Inventory.Data.DatabaseContext;

public class ApplicationDbContext : DbContext
{
    //private readonly IConfiguration _configuration;

    //public ApplicationDbContext(IConfiguration configuration)
    //{
    //    _configuration = configuration;
    //}
    public DbSet<InventoryItem> InventoryItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")); 
        options.UseSqlServer("Server=localhost;Database=inventory;TrustServerCertificate=True;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InventoryItem>().Property(prop => prop.Price).HasPrecision(10, 5);

        SeedDataInit.Initialize(modelBuilder);


    }

}