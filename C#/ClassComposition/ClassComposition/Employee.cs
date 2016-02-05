using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassComposition
{
    class Employee
    {
        public string LastName { get; private set; }
        public Date BirthDate { get; private set; }
        public Date HireDate { get; private set; }
        public string FirstName { get; private set; }
        // The backing variable for FirstName is _firstName

        public Employee(string first, string last, Date dateOfBirth, Date dateOfHire)
        {
            FirstName = first;
            LastName = last;
            BirthDate = dateOfBirth;
            HireDate = dateOfHire;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} Hired: {2}:    Birth:{3}", LastName, FirstName, HireDate, BirthDate);
        }
    }
}
