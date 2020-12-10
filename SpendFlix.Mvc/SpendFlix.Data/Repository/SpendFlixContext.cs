using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpendFlix.Data.Models;
using SpendFlix.Data.Repository;
using System;

namespace SpendFlix.Data
{
    public class SpendFlixContext : DbContext , ISpendFlixContext
    {
        private readonly IConfiguration _configuration;
        public SpendFlixContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= SpendFlix.db");
            optionsBuilder.UseSqlite(this._configuration["DBConnectionString"]);
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Post> Post { get; set; }

        public void MyProperty()
        {
            var connectionString = new SqliteConnectionStringBuilder();
            connectionString.DataSource = "./SpendFlix.db";

            using (var connection = new SqliteConnection(connectionString.ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var tableCmd = connection.CreateCommand();
                    tableCmd.CommandText = "INSERT INTO Admin VALUES ('Tuba','','',1,1)";
                    tableCmd.ExecuteNonQuery();

                    transaction.Commit();
                }

                var selected = connection.CreateCommand();
                selected.CommandText = "Select * from Admin";
                using (var reader = selected.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var result = reader.GetString(0);
                        Console.WriteLine(result);
                    }
                }

            }

        }

    }
}
