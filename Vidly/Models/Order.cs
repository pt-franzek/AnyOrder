using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public float Cost { get; set; }
    }
}