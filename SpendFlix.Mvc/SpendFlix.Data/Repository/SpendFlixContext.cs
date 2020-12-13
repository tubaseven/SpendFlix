
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpendFlix.Data.Models;

namespace SpendFlix.Data
{

    public class SpendFlixContext : DbContext, ISpendFlixContext
    {
        private readonly IConfiguration _configuration;
        public SpendFlixContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public SpendFlixContext(DbContextOptions<SpendFlixContext> options)
        //    : base("SpendFlix.db") { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("Default"));

        }
        //private MySqlConnection GetConnection()
        //{
        //    return new MySqlConnection(ConnectionString);
        //}
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<MailList> MailList { get; set; }


    }
}


