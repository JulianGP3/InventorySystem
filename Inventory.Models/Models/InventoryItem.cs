namespace Inventory.Models.Models;

public class InventoryItem
{
    //[Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Quantity { get; set; }
    public decimal Price { get; set; }
}
