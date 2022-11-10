using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using WebApplication2.Entities;
using WebApplication2.Repositories;
using WebApplication2.Services.Implementations;

namespace TestProject1
{
    public class ProductServiceTest
    {
        Mock<IProductRepository> productRepository;

        [SetUp]
        public void Setup()
        {
            productRepository = new Mock<IProductRepository>();
        }

        [Test]
        public void TestGetThirdProductIsNull()
        {
            productRepository.Setup(x => x.GetAll())
                .Returns(new List<Product>());

            var sut = new ProductService(productRepository.Object);

            var result = sut.GetThirdProduct();

            Assert.IsNull(result);
        }

        [Test]
        public void TestGetThirdProduct()
        {
            productRepository.Setup(x => x.GetAll())
                .Returns(Products());

            var sut = new ProductService(productRepository.Object);

            var result = sut.GetThirdProduct();

            Assert.IsTrue(result.Name == "Product 3");
        }

        private static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product() { Name = "Product 1" },
                new Product() { Name = "Product 2" },
                new Product() { Name = "Product 3" },
            };
        }
    }
}