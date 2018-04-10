using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Observer
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Customer message: price updated");
        }
    }

    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Employee message: price updated");
        }
    }
}
