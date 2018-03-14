using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { FirstName = "Hakkı", LastName = "Baykal", City = "Manisa", Id = 45 };
           
            //Customer customer2 = customer1;
            Customer customer2 = (Customer)customer1.Clone();
            customer2.FirstName = "Sedat";

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
