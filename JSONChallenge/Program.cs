using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Wil";
            person.LastName = "Smith";
            person.DOB = new DateTime (1994, 5, 1 );
            person.FavoriteIceCreamFlavors = new List<string> { "Strawberry", "Cookie Dough" };

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();

        }
    }
}
