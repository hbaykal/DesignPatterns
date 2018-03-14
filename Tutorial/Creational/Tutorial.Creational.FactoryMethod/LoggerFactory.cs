using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.FactoryMethod
{

    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    {
        void Log();
    }
    public class LoggerFactory: ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new TextLogger();
        }
    }

    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new DbLogger();
        }
    }

    public class TextLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with TextLogger");
        }
    }

    public class DbLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with DbLogger");
        }
    }

    public class CustomerManger
    {
        private ILoggerFactory _loggerFactory;
        public CustomerManger(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public void Save()
        {
            Console.WriteLine("Saved!");
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }

}
