using Inventory.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data.SeedData;

public static class SeedDataInit
{

    public static void Initialize(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InventoryItem>().HasData(
                new InventoryItem { Id = 1, Name = "Product A", Quantity = "100", Price = 19.99m },
                new InventoryItem { Id = 2, Name = "Product B", Quantity = "50", Price = 29.99m },
                new InventoryItem { Id = 3, Name = "Product C", Quantity = "75", Price = 9.99m }
            );
    }
}
