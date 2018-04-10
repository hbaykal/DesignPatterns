using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Strategy
{
    public class CustomerManager
    {
        public CreditCalculatorBase CreditCalculatorBase;
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager buiness");
            CreditCalculatorBase.Calculate();

        }

    }
}
