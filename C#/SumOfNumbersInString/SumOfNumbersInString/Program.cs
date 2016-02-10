using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbersInString
{
    class Program
    {
         public static void Main(string[] args)
        {

            GetInput();
        }

    public static bool AreAllDigits(string Raw) {
        string s = Raw.Trim();
        if (s.Length == 0) {
            return false;
        }

        for (int index = 0; index < s.Length; index++) {
            if (Char.IsDigit(s[index]) == false) {
                return false;
            }
        }

        return true;
    }

        public static void GetInput()
        {
            Console.WriteLine("Please input a lst of numbers seperated by commas!");
            string input = Console.ReadLine();
            char[] Dividers = { ',', ' ' };
            string[] chunks = input.Split(Dividers);
            int Sum = 0;
            foreach (string s in chunks)
            {
                if (s.Length > 0)
                {
                    if (AreAllDigits(s))
                    {
                        int num = Int32.Parse(s);
                        Console.WriteLine("The next number is = {0}", num);
                        Sum += num;
                    }
                }
            }
            Console.WriteLine("Sum = {0}", Sum);
        }
}
    }
