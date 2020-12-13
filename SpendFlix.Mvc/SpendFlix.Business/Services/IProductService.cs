using SpendFlix.Entities;
using System.Collections.Generic;

namespace SpendFlix.Business.Services
{
    public interface IProductService
    {
        List<ProductDTO> GetProducts();
    }
}
