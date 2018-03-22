using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hakki = new Employee() { Name = "Hakkı Baykal" };
            Employee sedat = new Employee() { Name = "Sedat Karakaş" };
            Employee ceren = new Employee() { Name = "Ceren Baykal" };
            Employee serkan = new Employee() { Name = "Serkan Karakaş" };

            hakki.AddEmployee(sedat);
            hakki.AddEmployee(ceren);

            sedat.AddEmployee(serkan);

            Console.WriteLine(hakki.Name);
            foreach (Employee manager in hakki)
            {
                Console.WriteLine("--" + manager.Name);

                foreach (Employee employee in manager)
                {
                    Console.WriteLine("----" + employee.Name);
                }
                Console.WriteLine("...............");
            }
            Console.ReadLine();

        }
    }
}
