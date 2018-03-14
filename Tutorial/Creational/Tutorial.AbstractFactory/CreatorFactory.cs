using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.AbstractFactory
{
    public abstract class CreatorFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCache();
    }

    public class Factory1 : CreatorFactory
    {
        public override Caching CreateCache()
        {
            return new MemCache();
        }

        public override Logging CreateLogger()
        {
            return new TextLogger();
        }
    }

    public class Factory2 : CreatorFactory
    {
        public override Caching CreateCache()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new DbLogger();
        }
    }
}
