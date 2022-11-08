using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product { Name = "Product 1"}
            };
        }
    }
}