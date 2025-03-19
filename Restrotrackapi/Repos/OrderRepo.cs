using Microsoft.EntityFrameworkCore;
using Restrotrackapi.Models;
using Restrotrackapi.Utilities;

namespace Restrotrackapi.Repos
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext ctx;

        public OrderRepo(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<Order> AddNewOrder(Order newOrder)
        {
            var result = await ctx.AddAsync(newOrder);
            await ctx.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Order> DeleteOrderById(string id)
        {
            var Order = await ctx.Orders.FirstOrDefaultAsync(Order => Order.Id == id);
            ctx.Orders.Remove(Order);
            await ctx.SaveChangesAsync();
            return Order;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await ctx.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderById(string id)
        {
            return await ctx.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Order> GetOrderByOrderId(string id)
        {
            return await ctx.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Order> ModifyOrder(Order newOrder)
        {
            var currOrder = await ctx.Orders.FirstOrDefaultAsync(x => x.Id == newOrder.Id);
            currOrder.Stage = newOrder.Stage;
            currOrder.MenuItems = newOrder.MenuItems;
            currOrder.BillId = newOrder.BillId;
            currOrder.Date = newOrder.Date;
            currOrder.Paid = newOrder.Paid;
            ctx.Orders.Update(currOrder);
            await ctx.SaveChangesAsync();
            return currOrder;
        }
    }
}
