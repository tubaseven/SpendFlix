using System;

namespace SpendFlix.Data.Models
{
    public class Links
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Link { get; set; }
        public string ImageLink { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }


    }
}
