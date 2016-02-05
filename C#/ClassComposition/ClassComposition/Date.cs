using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassComposition
{
    class Date
    {
        private int month; // 1 - 12
        private int day; // 1 - 31 based on month

        // auto implemented property Year
        public int Year { get; private set; }

        // Constructor: use property Month to confirm propper value for month;
        // use proper Day to confirm proper value for day.
        public Date(int theMonth, int theDay, int theYear)
        {
            Month = theMonth;
            Day = theDay;
            Year = theYear;
            Console.WriteLine("Date Object constructor for date {0}", this);
        }

        public int Month
        {
            get
            {
                return month;
            } // end get
            private set // make writing inaccessible outside the class
            {
                if(value > 0 && value <= 12)
                {
                    month = value;
                }
                else // invalid month
                {
                    throw new ArgumentOutOfRangeException("Month", value, "Month must be between 1-12");
                }
            } // end set
        }

        public int Day
        {
            get
            {
                return day;
            }
            private set
            {
                int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                // Check if day in range for month
                if (value > 0 && value <= daysPerMonth[Month])
                {
                    day = value;
                }
                // Check for leap year
                else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                {
                    day = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Day", value, "Day out of range for current month/year");
                }
            }
        }

            public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Month, Day, Year);
        }
    }

 }

