using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJAX_MVC4_APP.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}