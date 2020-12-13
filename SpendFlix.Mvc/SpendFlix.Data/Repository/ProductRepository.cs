using SpendFlix.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SpendFlix.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISpendFlixContext _spendFlixContext;
        public ProductRepository(ISpendFlixContext _spendFlixContext)
        {
            this._spendFlixContext = _spendFlixContext;
        }

        public List<ProductDTO> GetProducts()
        {
            var query = (from a in _spendFlixContext.Post
                         select (new ProductDTO
                         {
                             Id = a.Id,
                             Title = a.Title,
                             ImageLink = a.ImageLink,
                             Description = a.Description,
                             Active = a.Active,
                             CreationDate = a.CreationDate
                         })).ToList();
            return query;

        }
    }
}
