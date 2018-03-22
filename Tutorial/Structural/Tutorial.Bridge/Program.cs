using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.MessageSenderBase = new SmsSender();
            customerManager.UpdateCustomer();
            Console.WriteLine("*****************");
            SpecialCustomerManager specialManager = new SpecialCustomerManager();
            specialManager.MessageSenderBase = new MailSender();
            specialManager.CreateCamapaign();

            Console.ReadLine();
        }
    }
}
