using SQLite;
using System;

namespace SpendFlix.Data.Models
{
    [Table("Links")]

    public class Links
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Link { get; set; }
        public string ImageLink { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }


    }
}
