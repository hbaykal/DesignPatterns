using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.IceCream
{
    public class VanillaIceCream : Icecream
    {
        public override void CreateIceCream()
        {
            Console.WriteLine("Vanilla IceCream");
        }
    }
}
