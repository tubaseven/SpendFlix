using SpendFlix.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendFlix.Data.Repository
{
    public interface IAdminRepository
    {
        List<Admin> GetUsers();
        void AddUser();

    }
}
