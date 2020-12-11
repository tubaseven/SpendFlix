using SpendFlix.Data.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System;

namespace SpendFlix.Data.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ISpendFlixContext _spendFlixContext;
        public AdminRepository(ISpendFlixContext _spendFlixContext)
        {
            this._spendFlixContext = _spendFlixContext;
        }

        public List<Admin> GetUsers()
        {
            //using (var db = new SpendFlixContext())
            //{
                //var product = new Admin() { Username = "Tuğba", Email = "asd", HashPassword = "asdadsfas", Active = true,  CreationDate = DateTime.Now };

                //_spendFlixContext.Admin.Add(product);
                //_spendFlixContext.SaveChanges();

                return _spendFlixContext.Admin.ToList();
            //}
                
        }



        public void AddUser()
        {
            var connectionString = new SqliteConnectionStringBuilder();
            connectionString.DataSource = "./SpendFlix.db";

            using (var connection = new SqliteConnection(connectionString.ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var tableCmd = connection.CreateCommand();
                    tableCmd.CommandText = "INSERT INTO [Admin] VALUES ('Tuba','','',1,1)";
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
        //public List<Admin> GetUsers()
        //{
        //    List<Admin> userList = new List<Admin>();
        //    try
        //    {
        //        var connectionString = new SqliteConnectionStringBuilder();
        //        connectionString.DataSource = "./SpendFlix.db";

        //        using (var connection = new SqliteConnection(connectionString.ConnectionString))
        //        {
        //            connection.Open();

        //            string sql = "SELECT * FROM Admin" ;
                    
        //            using (SqliteCommand cmd = new SqliteCommand(sql, connection))
        //            {
        //                using (SqliteDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        Admin user = new Admin();
        //                        user.Username = reader["Username"].ToString();
        //                        userList.Add(user);
        //                    }
        //                }
        //            }
        //            connection.Close();

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        //logg
        //        throw;
        //    }
        //    return userList;
        //}
    }
}
