using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpendFlix.Data.Models;

namespace SpendFlix.Data
{
    public class SpendFlixContext : DbContext , ISpendFlixContext
    {
        private readonly IConfiguration _configuration;
        public SpendFlixContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source = SpendFlix.db");
            optionsBuilder.UseSqlite(_configuration["DBConnectionString"]);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Admin>()
        //      .HasKey(p => new { p.Id)};
        //}

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Post> Post { get; set; }

    }
}
