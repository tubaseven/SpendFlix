using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpendFlix.Data.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string HashPassword { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
