using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Time1
{
    class Program
    {
        static void Main(string[] args)
        {
            Time1 time = new Time1(); // Invokes Constructor

            // Output string representation of the time
            Console.Write("The initial universal time is: ");
            Console.WriteLine(time.ToUniversalString());
            Console.WriteLine("The initial standard time is: ");
            Console.WriteLine(time.ToString());
            Console.WriteLine();

            time.setTime(13, 27, 6);

            Console.Write("universal time is: ");
            Console.WriteLine(time.ToUniversalString());
            Console.WriteLine("standard time is: ");
            Console.WriteLine(time.ToString());
            Console.WriteLine();

            // Attempt to set time to invalid values
            try
            {
                time.setTime(99, 99, 99);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
            // Output string representation of the time
            Console.Write("universal time after invalid setting attempt is: ");
            Console.WriteLine(time.ToUniversalString());
            Console.WriteLine("standard time after invalid setting attempt is: ");
            Console.WriteLine(time.ToString());
            Console.WriteLine();

        }
    }
}
