using SpendFlix.Data.Repository;
using SpendFlix.Entities;
using System.Collections.Generic;

namespace SpendFlix.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<ProductDTO> GetProducts(int postId)
        {
            return _productRepository.GetProducts(postId);
        }
    }
}
