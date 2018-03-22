using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Composite
{
    public class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _employees = new List<IPerson>();

        public void AddEmployee(IPerson person)
        {
            _employees.Add(person);
        }

        public void RemoveEmployee(IPerson person)
        {
            _employees.Remove(person);
        }

        public IPerson GetEmployee(int index)
        {
            return _employees[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var employee in _employees)
            {
                yield return employee; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
