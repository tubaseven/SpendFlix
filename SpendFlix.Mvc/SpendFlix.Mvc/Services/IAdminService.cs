using SpendFlix.Data.Models;
using System.Collections.Generic;

namespace SpendFlix.Mvc.Services
{
    public interface IAdminService
    {
        List<Admin> GetUsers();
        List<Admin> AddUser();
    }
}
