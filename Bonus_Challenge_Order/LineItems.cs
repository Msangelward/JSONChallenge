using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Challenge_Order
{
    public class LineItems
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public LineItems()
        {

        }

        public LineItems(string sku, int quantity, decimal unitPrice, decimal totalPrice)
        {
            Sku = sku;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }

    }
}
