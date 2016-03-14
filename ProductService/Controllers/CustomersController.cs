using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.OData;
using ProductService.Models;

namespace ProductService.Controllers
{
    public class CustomersController : ODataController
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer()
            {
                CustomerId = 1,
                Location = new Address()
                {
                    City = "Shanghai",
                    Country = "China"
                },
                Orders = new List<Order>
                {
                    new Order
                    {
                        OrderId = 1,
                        Token = new Guid()
                    },
                    new Order
                    {
                        OrderId = 2,
                        Token = new Guid()
                    }
                }
            },
            new Customer()
            {
                CustomerId = 2,
                Location = new Address()
                {
                    City = "Bijie",
                    Country = "China"
                },
                Orders = new List<Order>
                {
                    new Order
                    {
                        OrderId = 1988,
                        Token = new Guid()
                    },
                    new Order
                    {
                        OrderId = 1989,
                        Token = new Guid()
                    }
                }
            }
        };

        public List<Customer> Get()
        {
            return customers;
        }

        public Customer Get(int key)
        {
            return (
                from n in customers
                where n.CustomerId == key
                select n).First();
        }

        public int GetCustomerId(int key)
        {
            return Get(key).CustomerId;
        }

        public Address GetLocation(int key)
        {
            return Get(key).Location;
        }

        public IList<Order> GetOrders(int key)
        {
            return Get(key).Orders;
        }
    }
}