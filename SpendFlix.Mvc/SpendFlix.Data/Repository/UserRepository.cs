using SpendFlix.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SpendFlix.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ISpendFlixContext _spendFlixContext;
        public UserRepository(ISpendFlixContext _spendFlixContext)
        {
            this._spendFlixContext = _spendFlixContext;
        }

        public List<UserDTO> GetUsers()
        {
            var query = (from a in _spendFlixContext.User
                         select (new UserDTO
                         {
                             Id = a.Id,
                             FullName = a.FullName,
                             UserName = a.UserName,
                             HashPassword = a.HashPassword,
                             Email = a.Email,
                             Active = a.Active,
                             CreationDate = a.CreationDate
                         })).ToList();
            return query;

        }
       
    }
}
