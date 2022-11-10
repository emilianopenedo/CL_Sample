using System.Collections.Generic;
using System.Linq;
using WebApplication2.Entities;
using WebApplication2.Repositories;

namespace WebApplication2.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public Product GetThirdProduct()
        {
            return productRepository.GetAll().Skip(2).FirstOrDefault();
        }
    }
}