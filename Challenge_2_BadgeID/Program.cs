using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_BadgeID
{
    class Program
    {
        static void Main(string[] args)
        {
            Badge badge = new Badge();
            badge.BadgeId = 12345;
            badge.ListOfDoors = new List<string> { "A1", "B2", "B5", "G21"};
            badge.HasSecurityClearance = true;
            badge.EmployeeId = "F54G678HJ32321S";
            badge.CreatedOn = new DateTime(2021, 7, 27);

            string json = JsonConvert.SerializeObject(badge);

            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
