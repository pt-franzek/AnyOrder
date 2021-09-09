using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var order = new Order() { Summary = "Steak" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"},
            };

            var viewModel = new RandomOrderViewModel
            {
                Order = order,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("orders")]
        [Route("orders/orders")]
        public ActionResult Orders()
        {
            var orders = new List<Order>
            {
                new Order { Summary = "Burger" },
                new Order { Summary = "Pork" }
            };

            var viewModel = new OrdersViewModel { Orders = orders };

            return View(viewModel);
        }
    }
}