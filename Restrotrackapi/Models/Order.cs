using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restrotrackapi.Models
{
    public class Order
    {
        [Key]
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public bool Paid { get; set; }
        public Stage Stage { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public virtual string BillId { get; set; }
        [ForeignKey("BillId")]
        public Bill Bill { get; set; }
    }

    public enum Stage
    {
        Placed,
        Preparing,
        Served,
        Bill,
        Completed
    }

    //public class UserConfiguration : IEntityTypeConfiguration<User>
    //{
    //    public void Configure(EntityTypeBuilder<User> builder)
    //    {
    //        builder.HasKey(u => u.Id);

    //        builder.HasMany(u => u.Roles)
    //            .WithOne()
    //            .HasForeignKey(r => r.Id)
    //            .OnDelete(DeleteBehavior.Restrict);
    //    }
    //}
}
