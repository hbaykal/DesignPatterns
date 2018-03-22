using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalCar = new PersonalCar() { Mark = "Fiat", Model = "Egea", HirePrice = 35000 };

            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage = 10;

            Console.WriteLine("Personal: {0}", personalCar.HirePrice);
            Console.WriteLine("Special: {0}", specialOffer.HirePrice);
            Console.ReadLine();

        }
    }
}
