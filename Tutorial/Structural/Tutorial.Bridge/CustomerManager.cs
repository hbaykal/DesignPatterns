using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Bridge
{
    public class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new Message { Title = "Bridge Pattern Hakkında!" });
            Console.WriteLine("Customer Updated...");
        }
    }

    public class SpecialCustomerManager : CustomerManager
    {
        public void CreateCamapaign()
        {
            MessageSenderBase.Send(new Message { Title = "About New Campaign!" });
            Console.WriteLine("Campaign Created...");
        }
    }
}
