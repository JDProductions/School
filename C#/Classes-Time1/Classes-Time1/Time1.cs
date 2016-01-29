using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definition of class Time

namespace Classes_Time1
{
    class Time1
    {
        // Fields
        private int hour; // 0 - 23
        private int minute; // 0 - 59
        private int second; // 0 -59;

        // Methods
        public void setTime(int h, int m, int s)
        {
            // Validate hours, minute, second
            if ((h >= 0 && h < 24) && (m >= 0 && m < 60) && (s >= 0 && s < 60))
                {
                hour = h;
                minute = m;
                second = s;
            } // end if
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        } // end setTime()

        // convert to string in universsal time format
        public string ToUniversalString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:D2}:{2:D2} {3}", ((hour == 0 || hour == 12) ? 12 : hour % 12),
            minute, second, (hour < 12 ? "AM" : "PM"));
        }

    }
}
