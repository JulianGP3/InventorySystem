
using Inventory.Models.Models;

namespace Inventory.Core.Interfaces;

public interface IInventoryRepository
{
    Task<IEnumerable<InventoryItem>> GetAllAsync();
    Task<InventoryItem> GetByIdAsync(Guid id);
    Task AddAsync(InventoryItem item);
    Task UpdateAsync(InventoryItem item);
    Task DeleteAsync(Guid id);

}
