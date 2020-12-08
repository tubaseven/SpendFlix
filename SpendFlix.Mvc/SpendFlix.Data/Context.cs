using Microsoft.Data.Sqlite;
using System;

namespace SpendFlix.Data
{
    public class Context
    {

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
