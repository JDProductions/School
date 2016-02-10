using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a BasePlusCommissionEmployee object
            BasePlusCommissionEmployee employee = new BasePlusCommissionEmployee("Bob", "Jones", "555-555-5555", 5000.00M, 0.05M, 50000);

            // Display BasePlussCommissionEmployee
            Console.WriteLine("Employee information obtained by properties and methods:\n");
            Console.WriteLine("First name is {0}", employee.FirstName);
            Console.WriteLine("Last name is {0}", employee.LastName);
            Console.WriteLine("Socal Security Number is {0}", employee.SocialSecurityNumber);
            Console.WriteLine("Gross sales are {0:C}", employee.GrossSales);
            Console.WriteLine("Commission rate is {0:F2}", employee.CommissionRate);
            Console.WriteLine("Earnings are {0:C}", employee.Earnings());
            Console.WriteLine("Base Salary is {0:C}", employee.BaseSalary);

            employee.BaseSalary = 1000.00M; // set base salary

            Console.WriteLine("\n{0}:\n\n{1}",
                "Updated employee information obtained by ToString method", employee);
            Console.WriteLine("Earnings: {0:C}", employee.Earnings());




        }
    }
}
