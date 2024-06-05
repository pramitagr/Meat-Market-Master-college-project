using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFreshHouse
{
    internal class Cart
    {
        public string ProductName { get; set; }

        public int ProductId { get; set; }
        public decimal ProductPricePerKg { get; set; }
        public decimal Quantity { get; set; }

        public decimal Subtotal { get; set; } 
    }
}
