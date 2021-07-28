using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Challenge_Order
{
    public class ShippingAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public ShippingAddress()
        {

        }

        public ShippingAddress(string addressLine1, string addressLine2, string city, string state, int zip)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            Zip = zip;
        }
    }
}
