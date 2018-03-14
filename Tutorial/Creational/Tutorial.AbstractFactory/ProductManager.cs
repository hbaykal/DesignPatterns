using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.AbstractFactory
{
    public class ProductManager
    {
        private CreatorFactory _creatorFactory;
        private Logging _logging;
        private Caching _caching;
        public ProductManager(CreatorFactory creatorFactory)
        {
            _creatorFactory = creatorFactory;
            _logging = _creatorFactory.CreateLogger();
            _caching = _creatorFactory.CreateCache();
        }
        public void GetAll()
        {
            _logging.Log("Product Manager Log");
            _caching.Cache("Product Manager Cache");
            Console.WriteLine("Products Listed");
        }
    }
}
