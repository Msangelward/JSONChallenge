using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Challenge_Order
{
    public class Order
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public LineItems LineItems { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Order()
        {

        }
        
        public Order(string orderId, Customer customer, LineItems lineItems, DateTime purchaseDate)
        {
            OrderId = orderId;
            Customer = customer;
            LineItems = lineItems;
            PurchaseDate = purchaseDate;
        }
    }
}
