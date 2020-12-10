using Microsoft.EntityFrameworkCore;
using SpendFlix.Data.Models;

namespace SpendFlix.Data
{
    public interface ISpendFlixContext
    {
        DbSet<Admin> Admin { get; set; }
        DbSet<Links> Links { get; set; }
        DbSet<Post> Post { get; set; }
    }
}
