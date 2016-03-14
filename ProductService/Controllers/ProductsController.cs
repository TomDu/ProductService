using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.OData;
using ProductService.Models;

namespace ProductService.Controllers
{
    public class ProductsController : ODataController
    {
        private List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Bread"
            },
            new Product()
            {
                Id = 2,
                Name = "Milk"
            }
        };

        public List<Product> Get()
        {
            return products;
        }

        public Product Get(int key)
        {
            IEnumerable<Product> arr = from n in products
                where n.Id == key
                select n;
            return arr.First();
        }
    }
}