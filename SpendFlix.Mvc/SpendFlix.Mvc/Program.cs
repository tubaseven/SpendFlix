using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpendFlix.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connectionString = new SqliteConnectionStringBuilder();
            connectionString.DataSource = "./SpendFlix.db";

            using (var connection = new SqliteConnection(connectionString.ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var tableCmd = connection.CreateCommand();
                    tableCmd.CommandText = "INSERT INTO Admin VALUES('Tuba','Seven','tubaseven',1,1)";
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
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
