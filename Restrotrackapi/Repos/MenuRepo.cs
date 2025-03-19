using Microsoft.EntityFrameworkCore;
using Restrotrackapi.Models;
using Restrotrackapi.Utilities;

namespace Restrotrackapi.Repos
{
    public class MenuRepo : IMenuRepo
    {
        private readonly AppDbContext ctx;

        public MenuRepo(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<MenuItem> AddNewMenuItem(MenuItem newMenuItem)
        {
            var result = await ctx.AddAsync(newMenuItem);
            await ctx.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<MenuItem> DeleteMenuItemById(string id)
        {
            var MenuItem = await ctx.MenuItems.FirstOrDefaultAsync(MenuItem => MenuItem.Id == id);
            ctx.MenuItems.Remove(MenuItem);
            await ctx.SaveChangesAsync();
            return MenuItem;
        }

        public async Task<List<MenuItem>> GetAllMenuItems()
        {
            return await ctx.MenuItems.ToListAsync();
        }

        public async Task<MenuItem> GetMenuItemById(string id)
        {
            return await ctx.MenuItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<MenuItem> GetMenuItemByOrderId(string id)
        {
            return await ctx.MenuItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<MenuItem> ModifyMenuItem(MenuItem newMenuItem)
        {
            var currMenuItem = await ctx.MenuItems.FirstOrDefaultAsync(x => x.Id == newMenuItem.Id);
            currMenuItem.Unit = newMenuItem.Unit;
            currMenuItem.Quantity = newMenuItem.Quantity;
            currMenuItem.Name = newMenuItem.Name;
            currMenuItem.CategoryId = newMenuItem.CategoryId;
            currMenuItem.CuisineId = newMenuItem.CuisineId;
            ctx.MenuItems.Update(currMenuItem);
            await ctx.SaveChangesAsync();
            return currMenuItem;
        }
    }
}
