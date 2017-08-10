using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.IceCream
{
    public class IceCreamCreator
    {
        public Icecream GetIceCream(IceCreamTypes type)
        {
            Icecream iceCream = null;
            switch (type)
            {
                case IceCreamTypes.Strawberry:
                    iceCream = new StrawberryIceCream();
                    break;
                case IceCreamTypes.Chocolate:
                    iceCream = new ChocolateIceCream();
                    break;
                case IceCreamTypes.Vanilla:
                    iceCream = new VanillaIceCream();
                    break;
                default:
                    break;
            }
            return iceCream;
        }
    }
}
