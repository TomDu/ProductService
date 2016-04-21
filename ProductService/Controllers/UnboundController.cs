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
    public class UnboundController : ODataController
    {
        ProductsContext db = new ProductsContext();

        [HttpGet]
        [ODataRoute("GetSalesTaxRate(PostalCode={postalCode})")]
        public IHttpActionResult GetSalesTaxRate([FromODataUri] int postalCode)
        {
            double rate = 5.6;
            return Ok(rate);
        }
    }
}