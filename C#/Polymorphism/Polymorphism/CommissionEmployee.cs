using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class CommissionEmployee : Object
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal commissionRate;

        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            grossSales = sales;
            commissionRate = rate;
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
        }

        public decimal GrossSales
        {
            get { return grossSales; }

            set
            {
                if (value >= 0)
                {
                    grossSales = value;
                }
                else
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >= 0");
            }

        }

        public decimal CommissionRate
        {
            get { return commissionRate; }

            set
            {
                if (value > 0 && value < 1)
                {
                    commissionRate = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Commission Rate", value, "Commission Rate must be > 0 and < 1");
            }
        }

        public virtual decimal Earnings()
        {
            return commissionRate * grossSales;
        }

        // To return string rep
        public override string ToString()
        {
            return string.Format("{0}: {1}  {2}\n{3}: {4}\n{5}: {6:C}\n{7}:  {8:F2}", "CommissionEmployee", FirstName, LastName, "Social Security Number", SocialSecurityNumber,
                "Gross Sales", GrossSales, "Commission rate", CommissionRate);
        }

    }
}
