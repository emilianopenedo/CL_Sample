using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetThirdProduct();
    }
}