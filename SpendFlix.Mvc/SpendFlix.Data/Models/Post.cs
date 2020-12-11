using SQLite;
using System;

namespace SpendFlix.Data.Models
{
    [Table("Post")]

    public class Post
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageLink { get; set; }
        public bool Active { get; set; }
        public bool Featured { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
