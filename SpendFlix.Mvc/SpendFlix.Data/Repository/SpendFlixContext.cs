
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpendFlix.Data.Models;
using MySQL.Data.EntityFrameworkCore;

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
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("ConnectionStrings:Default"));
           
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Post> Post { get; set; }

    }
}


