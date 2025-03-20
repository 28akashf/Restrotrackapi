using Microsoft.EntityFrameworkCore;
using Restrotrackapi.Models;
using Restrotrackapi.Utilities;

namespace Restrotrackapi.Repos
{
    public class StaffRepo
    {
        private readonly AppDbContext ctx;

        public StaffRepo(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<Staff> AddNewStaff(Staff newStaff)
        {
            var result = await ctx.Users.AddAsync(newStaff);
            await ctx.SaveChangesAsync();
            return (Staff)result.Entity;
        }

        public async Task<Staff> DeleteStaffById(string id)
        {
            var staff = await ctx.Users.FirstOrDefaultAsync(x => x.Id == id);
            ctx.Users.Remove(staff);
            await ctx.SaveChangesAsync();
            return (Staff)staff;
        }

        public async Task<List<Staff>> GetAllStaffs()
        {
            var result = await ctx.Users.ToListAsync();
            return result.Select(x=>(Staff)x).ToList();
        }

        public async Task<Staff> GetStaffById(string id)
        {
            return (Staff)(await ctx.Users.FirstOrDefaultAsync(x => x.Id == id));
        }

        public async Task<Staff> GetStaffByStaffId(string id)
        {
            return (Staff)(await ctx.Users.FirstOrDefaultAsync(x => x.Id == id));
        }

        public async Task<Staff> ModifyStaff(Staff newStaff)
        {
            var currStaff = await ctx.Users.FirstOrDefaultAsync(x => x.Id == newStaff.Id);
            currStaff.PhoneNumber = newStaff.PhoneNumber;
            currStaff.Email = newStaff.Email;
            currStaff.NormalizedEmail = newStaff.NormalizedEmail;
            currStaff.NormalizedUserName = newStaff.NormalizedUserName;
            ctx.Users.Update(currStaff);
            await ctx.SaveChangesAsync();
            return (Staff)currStaff;
        }
    }
}
