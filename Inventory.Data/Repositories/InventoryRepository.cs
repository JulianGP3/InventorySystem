using Inventory.Core.Interfaces;
using Inventory.Models.Models;

namespace Inventory.Data.Repositories;

public class InventoryRepository : IInventoryRepository
{
    public Task AddAsync(InventoryItem item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<InventoryItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<InventoryItem> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(InventoryItem item)
    {
        throw new NotImplementedException();
    }
}
