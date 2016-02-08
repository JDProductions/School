using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamScores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter section2;
            StreamWriter section3;
            StreamReader section1read;
            StreamReader section2read;
            StreamReader section3read;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Section1.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception etext)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(etext.Message);
            }



            section2 = File.CreateText("Section2.txt");
            section3 = File.CreateText("Section3.txt");


            int[][] Scores = new int[3][];


            Scores[0] = new int[12];
            Scores[1] = new int[8];
            Scores[2] = new int[10];




            


            for (int i = 0; i < 12; ++i)
            {
                
                
            }


            for (int j = 0; j < 8; ++j)
            {
               
            
            }


            for (int k = 0; k < 10; ++k)
            {
                
          
            }


           
            section2.Close();
            section3.Close();


            section1read = File.OpenText("Section1.txt");


            int nums = 0;
            while (!section1read.EndOfStream && Scores[0][nums] != null)
            {
                Scores[0][nums] = int.Parse(section1read.ReadLine());
                ++nums;
            }
            for (int i = 0; i < Scores.Length; ++i)
            {
                listBox1.Items.Add(Scores[0][i]);
            }
            section1read.Close();
        }
    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
