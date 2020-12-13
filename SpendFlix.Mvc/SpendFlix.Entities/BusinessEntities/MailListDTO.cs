using System;

namespace SpendFlix.Entities
{
    public  class MailListDTO
    {
        public int Id { get; set; }     
        public string Email { get; set; }
        public bool IsSubscribed { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
