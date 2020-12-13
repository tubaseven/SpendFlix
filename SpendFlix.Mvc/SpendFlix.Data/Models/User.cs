using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpendFlix.Data.Models
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
