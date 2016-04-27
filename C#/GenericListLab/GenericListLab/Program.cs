using System;
using System.Collections.Generic;

namespace GenericListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            List<int> randomList = new List<int>();
            int randomNumber = 0;
            int Sum = 0, count = 0;
            double Average;
            while (count < 25)
            {
                randomNumber = a.Next(0, 100);

                if (!randomList.Contains(randomNumber))
                {
                    randomList.Add(randomNumber);
                    count++;
                }
            }
            Console.Write("\nThe numbers in the list are: ");
            for (int i = 0; i < randomList.Count; i++)
            {
                Console.Write(randomList[i] + " ");
                Sum = Sum + randomList[i];
            }
            Average = Sum / 25;
            Console.Write("\n\nSum of the elements is : " + Sum);
            Console.Write("\n\nAverage of the elements is : " + Average);
            Console.Read();
        }
    }
}