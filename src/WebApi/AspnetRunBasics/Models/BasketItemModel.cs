using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRunBasics.Models
{
    public class BasketItemModel
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
    }
}
