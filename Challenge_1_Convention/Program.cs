using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Convention
{
    class Program
    {
        static void Main(string[] args)
        {
            Convention convention = new Convention();
            convention.StartDate = new DateTime(2021, 7, 27);
            convention.EndDate = new DateTime(2021, 7, 31);
            convention.EventTitle = "Gen Con";
            convention.EventCapacity = 10000;
            convention.PriceOfAdmission = 325.50;

            string json = JsonConvert.SerializeObject(convention);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
