using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory1());
            productManager.GetAll();
            Console.ReadLine();
        }
    }

   
}
