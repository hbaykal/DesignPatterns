using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Facade
{
    public class BusinessActionFacade
    {
        public ILogger Logger;
        public ICaching Caching;
        public IAuthorize Authorize;
        public IValidate Validation;

        public BusinessActionFacade()
        {
            Logger = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
            Validation = new Validation();
        }
    }
}
