using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Facade
{
    public class Logging : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    public interface ILogger
    {
        void Log();
    }
}
