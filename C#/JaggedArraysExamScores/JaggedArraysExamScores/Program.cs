using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static void ReadFile()
{
    using (TextReader reader = File.OpenText("Section1.txt"))
    {
        int x = int.Parse(reader.ReadLine());
        double y = double.Parse(reader.ReadLine());
        string z = reader.ReadLine();
    }
    int[][] jaggedArray = new int[3][]; 
    
    for (int i = 0; i < lines.Length; i++)
    {
        jaggedArray[0][0] = lines[i];
    }                    
                       


    while (!inputFile.EndOfStream)                                                  //While not at the end of the list.
    {
        PopulationList.Add(int.Parse(inputFile.ReadLine()));
        jaggedArray[0][0] = inputFile.ReadLine().ToString();
        //jaggedArray.[0]
    }
    var test = "";
namespace JaggedArraysExamScores
{
    class Program
    {

        

        static void Main(string[] args)
        {
        }
    }
}
