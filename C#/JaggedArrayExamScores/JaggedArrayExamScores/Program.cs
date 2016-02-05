using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExamScores
{
    class Program
    {
        public static  void ReadFile()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[12]; // Section 1
            jaggedArray[1] = new int[8];  // Section 2
            jaggedArray[2] = new int[10];  // Section 3

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Section1.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    var line = sr.ReadToEnd();
                    var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    //Console.WriteLine(line);
                    for (int row = 0; row < jaggedArray.Length; row++)
                        {
                        
                        Console.WriteLine(jaggedArray[0][0] = line[row]);
                        var test = " "; // Breakpoint
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                             {
                            //Console.WriteLine(jaggedArray[row][col].ToString());
                            
                             }
                         }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            ReadFile();
        }
    }
}
