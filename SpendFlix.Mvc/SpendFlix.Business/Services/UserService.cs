using SpendFlix.Data.Repository;
using SpendFlix.Entities;
using System.Collections.Generic;

namespace SpendFlix.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _adminRepository;

        public UserService(IUserRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }


        public List<UserDTO> GetUsers()
        {
            return _adminRepository.GetUsers();
        }

    }
    
}
