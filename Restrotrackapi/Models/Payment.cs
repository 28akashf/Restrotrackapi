using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restrotrackapi.Models
{
    public class Payment
    {
        [Key]
        public string Id { get; set; }
        public virtual string BillId { get; set; }
        [ForeignKey("BillId")]
        public Bill Bill { get; set; }
        public string? Name { get; set; }
        public string? Details { get; set; }
    }

    public enum Method
    {
        Card,
        Cash,
        Wallet
    }
}
