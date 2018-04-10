using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Strategy
{
    public abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    public class SpecialCustomerCalculate : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Special customer credit calculated");
        }
    }

    public class MainCustomerCalculate : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Main customer credit calculated");
        }
    }


}
