using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Challenge_Order
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ShippingAddress ShippingAddress { get; set; }

        public Customer()
        {
        }

        public Customer(string firstName, string lastName, string phoneNumber, ShippingAddress shippingAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            ShippingAddress = shippingAddress;
        }
    }
}
