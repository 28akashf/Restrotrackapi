using Microsoft.EntityFrameworkCore;
using Restrotrackapi.Models;
using Restrotrackapi.Utilities;

namespace Restrotrackapi.Repos
{
    public class BillRepo : IBillRepo
    {
        private readonly AppDbContext ctx;

        public BillRepo(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<Bill> AddNewBill(Bill newbill)
        {
           var result =  await ctx.AddAsync(newbill);   
            await ctx.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Bill> DeleteBillById(string id)
        {
            var bill = await ctx.Bills.FirstOrDefaultAsync(bill => bill.Id == id);
             ctx.Bills.Remove(bill);
            await ctx.SaveChangesAsync();
            return bill;
        }

       public async Task<List<Bill>> GetAllBills()
        {
           return await ctx.Bills.ToListAsync();
        }

        public async Task<Bill> GetBillById(string id)
        {
            return await ctx.Bills.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<Bill> GetBillByOrderId(string id)
        {
            return await ctx.Bills.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Bill> ModifyBill(Bill newbill)
        {
            var currbill = await ctx.Bills.FirstOrDefaultAsync(x => x.Id == newbill.Id);
            currbill.Status = newbill.Status;
            currbill.Total = newbill.Total;
            ctx.Bills.Update(currbill);
            await ctx.SaveChangesAsync();
            return currbill;
        }
    }
}
