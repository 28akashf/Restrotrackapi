
using Microsoft.EntityFrameworkCore;
using Restrotrackapi.Models;
using Restrotrackapi.Utilities;

namespace Restrotrackapi.Repos
{
    public class PaymentRepo : IPaymentRepo
    {
        private readonly AppDbContext ctx;

        public PaymentRepo(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<Payment> AddNewPayment(Payment newPayment)
        {
            var result = await ctx.AddAsync(newPayment);
            await ctx.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Payment> DeletePaymentById(string id)
        {
            var Payment = await ctx.Payments.FirstOrDefaultAsync(Payment => Payment.Id == id);
            ctx.Payments.Remove(Payment);
            await ctx.SaveChangesAsync();
            return Payment;
        }

        public async Task<List<Payment>> GetAllPayments()
        {
            return await ctx.Payments.ToListAsync();
        }

        public async Task<Payment> GetPaymentById(string id)
        {
            return await ctx.Payments.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Payment> GetPaymentByOrderId(string id)
        {
            return await ctx.Payments.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Payment> ModifyPayment(Payment newPayment)
        {
            var currPayment = await ctx.Payments.FirstOrDefaultAsync(x => x.Id == newPayment.Id);
            currPayment.Details = newPayment.Details;
            ctx.Payments.Update(currPayment);
            await ctx.SaveChangesAsync();
            return currPayment;
        }
    }
}
