using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using Restrotrackapi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Restrotrackapi.Utilities
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
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
