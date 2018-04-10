using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.CreditCalculatorBase = new MainCustomerCalculate();
            customerManager.CreditCalculatorBase = new SpecialCustomerCalculate();
            customerManager.SaveCredit();

            Console.ReadLine();
        }
    }
}
