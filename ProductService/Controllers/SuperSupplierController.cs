using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;
using ProductService.Models;

namespace ProductService.Controllers
{
    public class SuperSupplierController : ODataController
    {
        public static Supplier SuperSupplier;

        static SuperSupplierController()
        {
            InitData();
        }

        private static void InitData()
        {
            SuperSupplier = new Supplier
            {
                Id = 0,
                Name = "SuperSupplier",
                Address = new Address
                {
                    Street = "Zixing Road",
                    ZipCode = "200241"
                },
                Products = new List<Product>()
            };
        }

        [ODataRoute("SuperSupplier/Name")]
        public IHttpActionResult GetSupplierName()
        {
            return Ok(SuperSupplier.Name);
        }

        [EnableQuery]
        public IHttpActionResult Get()
        {
            return Ok(SuperSupplier);
        }
    }
}