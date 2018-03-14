using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateSingleton();
            customerManager.Save();
        }
    }
}
