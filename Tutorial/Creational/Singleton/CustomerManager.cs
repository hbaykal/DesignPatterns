using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CustomerManager
    {
        static CustomerManager _customerManager;
        static object _lockObject = new object();
        private CustomerManager()
        { }

        public static CustomerManager CreateSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }          
            return _customerManager;

            //return _customerManager ?? (_customerManager = new CustomerManager());
        }

        public void Save()
        { }
    }
}
