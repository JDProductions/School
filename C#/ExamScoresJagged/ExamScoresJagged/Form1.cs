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

namespace ExamScoresJagged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ReadFile()
        {
            // Create an array of 3 int arrays.
            int[][] jaggedScores = new int[3][];

            string examScores;

            // Create 3 arrays within jaggedScores
            jaggedScores[0] = new int[12];
            jaggedScores[1] = new int[8];
            jaggedScores[2] = new int[10];

            // Create StreamReader objects to reference our data files.
            StreamReader section1, section2, section3;

            //Open the files

            section1 = File.OpenText("Section1.txt");
            section2 = File.OpenText("Section2.txt");
            section3 = File.OpenText("Section3.txt");

            double strAllSectionAverageMarks = 0.0;
            double strAllSectionHighestMaxMars = 0.0;
            double  strAllSectionLowestMaxMars = 0.0;
            double sec1avg = 0.0;  //section 1 average
            double sec2avg = 0.0;  //section 2 average
            double sec3avg = 0.0;   //section 3 average
            int minindex = 0;   //to keep track of the section with the min marks
            int maxindex = 0;   //to keep track of the section with the maximum marks


            // Write the files' contents into our jagged array
            int index = 0;
            int sum1 = 0;    //to take the sum of the elements of the first array to calculate the average
            while (!section1.EndOfStream)// First Section's file
            {
                jaggedScores[0][index] = int.Parse(section1.ReadLine());
                sum1 = sum1 + jaggedScores[0][index];
                if (jaggedScores[0][index] > strAllSectionHighestMaxMars)
                {
                    strAllSectionHighestMaxMars = jaggedScores[0][index];
                    maxindex = 1;
                }
                if (jaggedScores[0][index] < strAllSectionLowestMaxMars || strAllSectionLowestMaxMars == 0){
                    strAllSectionLowestMaxMars = jaggedScores[0][index];
                    minindex = 1;
                }
                index++;
            }
            sec1avg = sum1 / 12;

            MessageBox.Show("The average exam score for section 1 " + sec1avg);
            index = 0; // Reset the index for the next file
            int sum2 = 0;
            while (!section2.EndOfStream)// Second Section's file
            {
                jaggedScores[1][index] = int.Parse(section2.ReadLine());
                sum2 = sum2 + jaggedScores[1][index];
                if (jaggedScores[1][index] > strAllSectionHighestMaxMars)
                {
                    strAllSectionHighestMaxMars = jaggedScores[1][index];
                    maxindex = 2;
                }
                if (jaggedScores[1][index] < strAllSectionLowestMaxMars || strAllSectionLowestMaxMars == 0){
                    strAllSectionLowestMaxMars = jaggedScores[1][index];
                    minindex = 2;
                }

                index++;
            }
            sec2avg = sum2 / 8;
            MessageBox.Show("The average exam score for section 2 " + sec2avg);

            index = 0; // Reset the index for the next file
            int sum3 = 0;
            while (!section3.EndOfStream)// Second Section's file
            {
                jaggedScores[2][index] = int.Parse(section3.ReadLine());
                sum3 = sum3 + jaggedScores[2][index];
                if (jaggedScores[2][index] > strAllSectionHighestMaxMars)
                {
                    strAllSectionHighestMaxMars = jaggedScores[2][index];
                    maxindex = 3;
                }
                if (jaggedScores[2][index] < strAllSectionLowestMaxMars || strAllSectionLowestMaxMars == 0){
                    strAllSectionLowestMaxMars = jaggedScores[2][index];
                    minindex = 3;
                }

                index++;
            }
            sec3avg = sum3 / 10;
            MessageBox.Show("The average exam score for section 3 " + sec3avg);

            strAllSectionAverageMarks = (sum1 + sum2 + sum3) / 30;
            MessageBox.Show("The average exam score for all sections " + strAllSectionAverageMarks);

            MessageBox.Show("The highest marks are" +strAllSectionHighestMaxMars +"and that student is from section" +maxindex);
            MessageBox.Show("The lowest marks are "+strAllSectionHighestMaxMars +"and that student is from section" +minindex);


            // Throw our newly acquired test scores into a ListBox
            for (int i = 0; i < 12; i++)
            {
                listBox1.Items.Add(jaggedScores[0][i]);
            }
            for (int i = 0; i < 8; i++)
            {
                listBox2.Items.Add(jaggedScores[1][i]);
            }
            for (int i = 0; i < 10; i++)
            {
                listBox3.Items.Add(jaggedScores[2][i]);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
