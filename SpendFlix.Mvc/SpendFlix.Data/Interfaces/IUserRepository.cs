using SpendFlix.Data.Models;
using SpendFlix.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendFlix.Data.Repository
{
    public interface IUserRepository
    {
        List<UserDTO> GetUsers();

    }
}
