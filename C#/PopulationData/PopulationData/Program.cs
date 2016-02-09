using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationData
{
    struct YearEntry
    {
        public int year;
    }


    class Program
    {
        private static List<YearEntry> entryList = new List<YearEntry>();
        
        public static void ReadFile()
        {
            StreamReader inputFile = File.OpenText("USPopulation.txt");
            List<int> PopulationList = new List<int>();                                     

            var startingYear = 1950;                                                        

            while (!inputFile.EndOfStream)                                                 
            {
                PopulationList.Add(int.Parse(inputFile.ReadLine()));                       
            }

            var numberOfYears = PopulationList.Count();
            var biggest = startingYear + GreatestIncrease(PopulationList);
            var least = startingYear + LeastIncrease(PopulationList);
            var average = Average(PopulationList);
            Console.WriteLine("The Biggest is: " + biggest);
            Console.WriteLine("The Least is: " + least);
            Console.WriteLine("The Average is: " + average);



        } // end Readfile



        private static int GreatestIncrease(List<int> PopulationList)                             

        {
            var amountOfChange = 0;
            var changeInYears = 0;
            int i;
            var theChange = 0;
            var currentYear = 0;

            for (i = 1; i < PopulationList.Count(); i++)
            {
                theChange = PopulationList[i] - PopulationList[i - 1];
                currentYear = i;

                if (theChange > amountOfChange)
                {
                    amountOfChange = theChange;
                    changeInYears = i;
                }
            }

            return changeInYears;
        
        }

        // The average annual change in population during the time period
        private static int Average(List<int> PopulationList)

        {
            int total = 0;
            int average = 0;

            for (int i  = 0; i < PopulationList.Count(); i++)
            {
                total += PopulationList[i];
                //theChange = PopulationList[i] + PopulationList[i/ PopulationList.Count();
                

            }
            average = total / PopulationList.Count();


            return average;

        }

        private static int LeastIncrease(List<int> PopulationList)                                 
        {
            int firstItem = PopulationList.First();
            int lastItem = PopulationList.Last();

            int amountOfChange = (lastItem - firstItem);
            int changeInYears = 0;
            int i;
            int theChange = 0;
            int CurrentYear = 0;

            for (i = 1; i < PopulationList.Count(); i++)
            {
                theChange = PopulationList[i] - PopulationList[i - 1];
                CurrentYear = i;

                if (theChange < amountOfChange)
                {
                    amountOfChange = theChange;
                    changeInYears = i;
                }
            }

            return changeInYears;
        }



        static void Main(string[] args)
        {
            ReadFile();
        }


    }
}