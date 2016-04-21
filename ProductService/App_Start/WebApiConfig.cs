using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using Microsoft.OData.Edm;
using ProductService.Models;

namespace ProductService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapODataServiceRoute("odata", null, GetConventionModel());
        }

        public static IEdmModel GetConventionModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            builder.EntitySet<Supplier>("Suppliers");
            builder.Namespace = "ProductService";
            builder.EntityType<Product>()
                .Action("Rate")
                .Parameter<int>("Rating");
            builder.EntityType<Product>().Collection
                .Function("MostExpensive")
                .Returns<double>();
            builder.Function("GetSalesTaxRate")
                .Returns<double>()
                .Parameter<int>("PostalCode");

            return builder.GetEdmModel();
        }
    }
}
