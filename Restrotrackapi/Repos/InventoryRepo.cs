using Microsoft.EntityFrameworkCore;
using Restrotrackapi.Models;
using Restrotrackapi.Utilities;

namespace Restrotrackapi.Repos
{
    public class InventoryRepo : IInventoryRepo
    {
        private readonly AppDbContext ctx;

        public InventoryRepo(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<InventoryItem> AddNewInventoryItem(InventoryItem newInventoryItem)
        {
            var result = await ctx.AddAsync(newInventoryItem);
            await ctx.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<InventoryItem> DeleteInventoryItemById(string id)
        {
            var InventoryItem = await ctx.InventoryItems.FirstOrDefaultAsync(InventoryItem => InventoryItem.Id == id);
            ctx.InventoryItems.Remove(InventoryItem);
            await ctx.SaveChangesAsync();
            return InventoryItem;
        }

        public async Task<List<InventoryItem>> GetAllInventoryItems()
        {
            return await ctx.InventoryItems.ToListAsync();
        }

        public async Task<InventoryItem> GetInventoryItemById(string id)
        {
            return await ctx.InventoryItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<InventoryItem> GetInventoryItemByOrderId(string id)
        {
            return await ctx.InventoryItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<InventoryItem> ModifyInventoryItem(InventoryItem newInventoryItem)
        {
            var currInventoryItem = await ctx.InventoryItems.FirstOrDefaultAsync(x => x.Id == newInventoryItem.Id);
            currInventoryItem.Unit = newInventoryItem.Unit;
            currInventoryItem.Name = newInventoryItem.Name;
            currInventoryItem.Category = newInventoryItem.Category;
            currInventoryItem.Quantity = newInventoryItem.Quantity;
            ctx.InventoryItems.Update(currInventoryItem);
            await ctx.SaveChangesAsync();
            return currInventoryItem;
        }
    }
}
