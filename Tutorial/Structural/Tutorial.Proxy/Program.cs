using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditManager manager = new CreditManager();
            Console.WriteLine(manager.Calculate());
            Console.WriteLine(manager.Calculate());

            CreditBase manager2 = new CreditmanagerProxy();
            Console.WriteLine(manager2.Calculate());
            Console.WriteLine(manager2.Calculate());

            Console.ReadLine();
        }
    }
}
