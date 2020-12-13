using System;

namespace SpendFlix.Entities
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Link { get; set; }
        public string ImageLink { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }


    }
}
