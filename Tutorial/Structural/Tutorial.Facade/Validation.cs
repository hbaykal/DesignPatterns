using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Facade
{
    public class Validation : IValidate
    {
        public bool Validate()
        {
            Console.WriteLine("User validated");
            return true;
        }
    }

    public interface IValidate
    {
        bool Validate();
    }
}
