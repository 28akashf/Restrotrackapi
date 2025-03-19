using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restrotrackapi.Models
{
    public class MenuItem
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual string CuisineId { get; set; }
        [ForeignKey("CuisineId")]
        public Cuisine Cuisine { get; set; }
        public virtual string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Course Category { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Course
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class Cuisine
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }


}
