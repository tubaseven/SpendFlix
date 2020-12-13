using Microsoft.EntityFrameworkCore;
using SpendFlix.Data.Models;

namespace SpendFlix.Data
{
    public interface ISpendFlixContext
    {
        DbSet<User> User { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<Post> Post { get; set; }
        DbSet<MailList> MailList { get; set; }

    }
}
