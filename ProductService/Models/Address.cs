using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
    }

    public class SubAddress : Address
    {
        public string Street { get; set; }
    }
}