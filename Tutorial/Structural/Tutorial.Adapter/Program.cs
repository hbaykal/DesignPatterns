using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new DbLogger());
            ProductManager productManager = new ProductManager(new Lo4NetAdapter());
            productManager.Save();
            Console.ReadLine();
        }
    }
}
