using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public Address Location { get; set; }
        public IList<Order> Orders { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class VipCustomer : Customer
    {
        public Color FavoriteColor { get; set; }
    }
}