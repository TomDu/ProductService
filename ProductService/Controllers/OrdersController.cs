using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.OData;
using ProductService.Models;

namespace ProductService.Controllers
{
    public class OrdersController : ODataController
    {
        private List<Order> orders = new List<Order>
        {
            new Order
            {
                OrderId = 2016,
                Token = new Guid()
            }
        };

        public List<Order> Get()
        {
            return orders;
        }

        public Order Get(int key)
        {
            return (
                from n in orders
                where n.OrderId == key
                select n).First();
        }
    }
}