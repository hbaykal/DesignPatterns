using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Facade
{
    public class Authorize : IAuthorize
    {
        public bool CheckUser()
        {
            Console.WriteLine("User checked");
            return true;
        }
    }

    public interface IAuthorize
    {
        bool CheckUser();
    }
}
