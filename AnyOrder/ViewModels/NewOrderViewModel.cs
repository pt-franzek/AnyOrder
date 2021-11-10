using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnyOrder.Models;

namespace AnyOrder.ViewModels
{
    public class NewOrderViewModel
    {
        public List<MenuItem> Meals { get; set; }
        public List<AddOn> AddOns { get; set; }
    }
}