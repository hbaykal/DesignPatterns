using FactoryMethod.IceCream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            IceCreamTest();

            Console.Read();
        }

        private static void IceCreamTest()
        {
            IceCreamCreator factory = new IceCream.IceCreamCreator();
            Icecream strawberry = factory.GetIceCream(IceCreamTypes.Strawberry);
            Icecream chocolate = factory.GetIceCream(IceCreamTypes.Chocolate);
            Icecream vanilla = factory.GetIceCream(IceCreamTypes.Vanilla);

            Icecream[] iceCreams = { strawberry, chocolate, vanilla };

            foreach (Icecream item in iceCreams)
            {
                item.CreateIceCream();
            }
        }
    }
}
