using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendFlix.Data.Models
{
    [Table("MailList")]
   public  class MailList
    {
        public int Id { get; set; }     
        public string Email { get; set; }
        public bool IsSubscribed { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
