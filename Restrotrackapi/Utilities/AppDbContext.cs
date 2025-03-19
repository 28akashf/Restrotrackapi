using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using Restrotrackapi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Restrotrackapi.Utilities
{
    public class AppDbContext : IdentityDbContext
    {
        DbSet<Bill> Bills { get; set; }
        DbSet<InventoryItem> InventoryItems { get; set; }
        DbSet<MenuItem> MenuItems { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Payment> Payments { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

  
        
   
    }
}
