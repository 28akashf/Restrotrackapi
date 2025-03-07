namespace Restrotrackapi.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public Course Category { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }

    public enum Course
    {
        Drink,
        Snack,
        Starter,
        Main,
        Desert
    }

 
}
