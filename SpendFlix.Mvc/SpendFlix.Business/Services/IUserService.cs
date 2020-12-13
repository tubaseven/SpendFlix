using SpendFlix.Entities;
using System.Collections.Generic;

namespace SpendFlix.Business.Services
{
    public interface IUserService
    {
        List<UserDTO> GetUsers();
    }
}
