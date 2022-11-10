using System.Collections.Generic;
using System.Web.Http;
using WebApplication2.Entities;
using WebApplication2.Repositories.Implementations;
using WebApplication2.Services;
using WebApplication2.Services.Implementations;

namespace WebApplication2
{
    public class ProductController : ApiController
    {
        private readonly IProductService productService;

        public ProductController()
        {
            var productRepository = new ProductRepository();
            this.productService = new ProductService(productRepository);
        }

        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return productService.GetAll();
        }

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //}

        //// POST api/<controller>
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}