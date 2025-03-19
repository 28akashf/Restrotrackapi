using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restrotrackapi.Models
{
    public class Bill
    {
        [Key]
        public string Id { get; set; }
        public double Total { get; set; }
        public Status Status { get; set; }
        public DateTime date { get; set; }
        public virtual string OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }

    public enum Status
    {
        Paid,
        Due
    }
}
