﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnyOrder.Models;
using AnyOrder.ViewModels;

namespace AnyOrder.Controllers
{
    public class OrdersController : Controller
    {
        [Route("orders")]
        [Route("orders/orders")]
        public ActionResult Orders()
        {
            var orders = new List<MenuItem>
            {
                new MenuItem { Summary = "Burger" },
                new MenuItem { Summary = "Pork" }
            };

            var viewModel = new OrdersViewModel { Orders = orders };

            return View(viewModel);
        }
    }
}