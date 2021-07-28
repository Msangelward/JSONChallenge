using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Challenge_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OrderId = "C-12345";
            order.Customer = new List<Customer>
                { "Taylor",
                  "Jones",
                  "(733) 265-3421",

                };
            order.LineItems = new List<LineItems> { };
            order.PurchaseDate = new DateTime(2021, 7, 27);

            string json = JsonConvert.SerializeObject(order);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
