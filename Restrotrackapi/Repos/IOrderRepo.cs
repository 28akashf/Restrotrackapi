using Restrotrackapi.Models;

namespace Restrotrackapi.Repos
{
    public interface IOrderRepo
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderById(string id);
        Task<Order> GetOrderByOrderId(string id);
        Task<Order> DeleteOrderById(string id);
        Task<Order> AddNewOrder(Order newOrder);
        Task<Order> ModifyOrder(Order newOrder);
    }
}
