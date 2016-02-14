using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            CommissionEmployee commissionEmployee = new CommissionEmployee(
                "Bob", "Jones", "555-55-5555",10000.00M, 0.6M);

            // Assign derived class reference to derived class variable
            BasePlusCommissionEmployee basePlusCommissionEmployee =
                new BasePlusCommissionEmployee("Lu", "Lous", "222-22-2222", 5000.00M, 0.04M,300.00M);

            // Invoke ToString and Earnings on base class object using base class variable
            Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
                "Call Commission Employee's ToString and Earnings methods",
                "with base class referenced to base class object",
            commissionEmployee.ToString(), "Earnings",
            commissionEmployee.Earnings());

            // Invoke ToString and Earnings on derived class object using dervied class variable
         Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
        "Call Base Plus Commission Employee's ToString and Earnings methods",
        "with derived referenced to base class object",
        basePlusCommissionEmployee.ToString(), "Earnings",
        basePlusCommissionEmployee.Earnings());

            // Invoke ToString and Earnings on derived class object using base class variable
            CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;
            Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
            "Call Base Plus Commission Employee's ToString and Earnings methods",
            "with base class referenced to base class object",
            commissionEmployee2.ToString(), "Earnings",
            commissionEmployee2.Earnings());

            // It is error to use a reference of the child class on a parent class object:
            //BasePlusCommissionEmployee bcpEmployee2 = CommissionEmployee;

        }
    }
}
