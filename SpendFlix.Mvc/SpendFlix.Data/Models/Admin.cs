using System;

namespace SpendFlix.Data.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string HashPassword { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
