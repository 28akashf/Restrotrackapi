﻿namespace Restrotrackapi.Models
{
    public class Staff
    {
        public string StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Chef,
        Waiter,
        Assistant,
        Shelf
    }
}
