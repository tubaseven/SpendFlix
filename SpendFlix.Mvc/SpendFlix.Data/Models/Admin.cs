using SQLite;
using System;

namespace SpendFlix.Data.Models
{
    [Table("Admin")]
    public class Admin
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string Username { get; set; }
        public string HashPassword { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
