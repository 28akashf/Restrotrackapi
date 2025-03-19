using Restrotrackapi.Models;

namespace Restrotrackapi.Repos
{
    public interface IMenuRepo
    {
        Task<List<MenuItem>> GetAllMenuItems();
        Task<MenuItem> GetMenuItemById(string id);
        Task<MenuItem> GetMenuItemByOrderId(string id);
        Task<MenuItem> DeleteMenuItemById(string id);
        Task<MenuItem> AddNewMenuItem(MenuItem newMenuItem);
        Task<MenuItem> ModifyMenuItem(MenuItem newMenuItem);
    }
}
