using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Adapter
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class DbLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(string.Format("DbLog writed: {0}",message));
        }
    }
    //Log4Net class'ı bir dll class ve Log() metodunun içerisini göremiyoruz. Aşağıdaki kod bir varsayım
    public class Log4Net
    {
        public void Log(string message)
        {
            Console.WriteLine(string.Format("Log4Net writed: {0}", message));
        }
    }
    //Burada adapter bir uyarlayıcı-ara katman gibi görev görüyor
    public class Lo4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.Log(message);
        }
    }


}
