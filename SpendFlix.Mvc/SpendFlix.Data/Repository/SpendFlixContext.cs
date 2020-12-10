using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpendFlix.Data.Models;

namespace SpendFlix.Data
{
    public class SpendFlixContext : DbContext , ISpendFlixContext
    {
        //private readonly IConfiguration _configuration;
        //public SpendFlixContext(IConfiguration configuration)
        //{
        //    this._configuration = configuration;
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= C:\\Users\\meliksah.ince\\source\\repos\\SpendFlix\\SpendFlix.Mvc\\SpendFlix.Data\\bin\\Debug\net5.0\\SpendFlix.db");
            //optionsBuilder.UseSqlite(this._configuration["DBConnectionString"]);
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
