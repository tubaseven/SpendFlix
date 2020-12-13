using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpendFlix.Data.Models
{
    [Table("Post")]
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageLink { get; set; }
        public bool Active { get; set; }
        public bool Featured { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
