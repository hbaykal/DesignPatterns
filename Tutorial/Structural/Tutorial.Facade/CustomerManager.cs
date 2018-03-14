using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Facade
{
    public class CustomerManager
    {
        //ILogger _logger;
        //ICaching _caching;
        //IAuthorize _authorize;
        //public CustomerManager(ILogger logger, ICaching caching, IAuthorize authorize)
        //{
        //    _logger = logger;
        //    _caching = caching;
        //    _authorize = authorize;
        //}

        //public void Save()
        //{
        //    _authorize.CheckUser();
        //    _logger.Log();
        //    Console.WriteLine("Saved");            
        //}

        private BusinessActionFacade _facade;
        public CustomerManager()
        {
            _facade = new BusinessActionFacade();
        }

        public void Save()
        {
            _facade.Authorize.CheckUser();
            _facade.Logger.Log();
            _facade.Caching.Cache();
            _facade.Validation.Validate();
            Console.WriteLine("Saved");
        }
    }
}
