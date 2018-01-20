using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class ShopVM
    {

        public Product prod { get; set; }

        public Weights Weight { get; set; }

        public Mechine Mechine { get; set; }

        public List<Product> prods { get; set; }

        public List<Weights> Weights { get; set; }

        public List<Mechine> Mechines { get; set; }

        public ShopsM Shop { get; set; }

        public List<ShopsM> Shops { get; set; }
    }
}