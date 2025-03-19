using System.ComponentModel.DataAnnotations;

namespace Restrotrackapi.Models
{
    public class InventoryItem
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public  Category Category { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }

public enum Category
{
    Grocery,
    Vegetable,
    Fruit,
    Meat
}

}
