using SpendFlix.Data.Models;
using SpendFlix.Data.Repository;
using System.Collections.Generic;

namespace SpendFlix.Mvc.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public List<Admin> GetUsers()
        {
            return _adminRepository.GetUsers();
        }

        public List<Admin> AddUser()
        {
            return _adminRepository.Add();
        }

    }
    
}
