using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}