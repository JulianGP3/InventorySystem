using Inventory.Core.Interfaces;

namespace Inventory.Core.Services;

public class InventoryService
{
    private readonly IInventoryRepository _inventoryRepository;

    public InventoryService(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }


}
