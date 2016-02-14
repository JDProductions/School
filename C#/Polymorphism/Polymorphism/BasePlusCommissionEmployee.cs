using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;

        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary) :
            base(first, last, ssn, sales, rate)
        {
            baseSalary = salary; // Validate base salary via the property
        }

        // Property that gets and sets the salary
        public decimal BaseSalary
        {
            get { return baseSalary; }

            set
            {
                if (value >= 0)
                {
                    baseSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
                }
            }
        }

        // Calculate earnings
        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }

        // Return string represenation of BasePlusCommissionEmployee
        public override string ToString()
        {
            return string.Format("Base-salaried {0}\nBase salary:{1:C}", base.ToString(), BaseSalary);
        }
    }
}