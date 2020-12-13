using SpendFlix.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SpendFlix.Data.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly ISpendFlixContext _spendFlixContext;
        public PostRepository(ISpendFlixContext _spendFlixContext)
        {
            this._spendFlixContext = _spendFlixContext;
        }

        public List<PostDTO> GetPosts()
        {
            var query = (from a in _spendFlixContext.Post
                         select (new PostDTO
                         {
                             Id = a.Id,
                             Title = a.Title,
                             ImageLink = a.ImageLink,
                             Description = a.Description,
                             Featured = a.Featured,
                             Active = a.Active,
                             CreationDate = a.CreationDate
                         })).ToList();
            return query;

        }
    }
}
