using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.AbstractFactory
{
    public abstract class Logging
    {
        public abstract void Log(string message);
    }

    public class TextLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("TextLogger message:{0}", message));
        }
    }

    public class DbLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine(string.Format("DbLogger message:{0}", message));
        }
    }

    public abstract class Caching
    {
        public abstract void Cache(string data);
    }

    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Memcache caching...");
        }
    }

    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Redis caching...");
        }
    }

}
