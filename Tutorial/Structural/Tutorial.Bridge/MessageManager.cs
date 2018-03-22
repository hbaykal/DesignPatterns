using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Bridge
{
    public abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved...");
        }

        public abstract void Send(Message message);
    }
    public class Message
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class MailSender : MessageSenderBase
    {
        public override void Send(Message message)
        {
            Console.WriteLine("Mail Message Title: {0}",message.Title);
        }
    }

    public class SmsSender : MessageSenderBase
    {
        public override void Send(Message message)
        {
            Console.WriteLine("Sms Message Title: {0}", message.Title);
        }
    }

}
