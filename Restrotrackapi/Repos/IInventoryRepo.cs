using Restrotrackapi.Models;

namespace Restrotrackapi.Repos
{
    public interface IInventoryRepo
    {
        Task<List<InventoryItem>> GetAllInventoryItems();
        Task<InventoryItem> GetInventoryItemById(string id);
      
        Task<InventoryItem> DeleteInventoryItemById(string id);
        Task<InventoryItem> AddNewInventoryItem(InventoryItem newInventoryItem);
        Task<InventoryItem> ModifyInventoryItem(InventoryItem newInventoryItem);
    }
}
