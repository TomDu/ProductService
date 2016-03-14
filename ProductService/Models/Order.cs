using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Guid Token { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}