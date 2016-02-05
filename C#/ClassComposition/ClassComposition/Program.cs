using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birth = new Date(5, 5, 1994);
            Date hire = new Date(3, 12, 2014);
            Employee employee = new Employee("Bob", "Blue", birth, hire);

            Console.WriteLine(employee);
        }
    }
}
