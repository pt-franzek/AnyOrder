using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnyOrder.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public float Price { get; set; }
        public string ItemType { get; set; }
    }
}