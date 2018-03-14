using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Creational.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManger manager = new CustomerManger(new LoggerFactory2());
            manager.Save();
            Console.ReadLine();
        }
    }
}
