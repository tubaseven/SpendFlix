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

        public List<ProductDTO> GetProducts(int postId)
        {
            var query = (from a in _spendFlixContext.Product
                         where a.PostId == postId
                         select (new ProductDTO
                         {
                             Id = a.Id,
                             Title = a.Title,
                             ImageLink = a.ImageLink,
                             Description = a.Description,
                             Price = a.Price,
                             Link = a.Link,
                             PostId = a.PostId,
                             Active = a.Active,
                             CreationDate = a.CreationDate
                         })).ToList();
            return query;

        }
    }
}
