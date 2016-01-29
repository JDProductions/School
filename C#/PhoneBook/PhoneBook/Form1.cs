// Project: PhoneBook
// Filename: Form1.cs
// Author: James DuBois
// Date: 1/28/2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhoneBook
{
    // The C# structure
    struct PhonebookEntry
    {
        public string name;
        public string phone;
    }

   


    public partial class Form1 : Form
    {

        // Field to hold a list of PhonebookEntry objects
        private List<PhonebookEntry> phoneList = new List<PhonebookEntry>();

        public Form1()
        {
            InitializeComponent();
        }
        
        // The Readfile method reads the contents of the PhoneList.txt 
        private void ReadFile()
        {
            try {
                StreamReader inputFile; // to read the file
                string line; // to hold a line from the file

                // create an instance of PhonebookEntry structre
                PhonebookEntry entry = new PhonebookEntry();
                // create a delimiter array
                char[] delim = { ',' };
                // Open the Phonelist file
                inputFile = File.OpenText("PhoneList.txt");
                // Read the line from the file
                while (!inputFile.EndOfStream)
                {
                    // read a line from the file
                    line = inputFile.ReadLine();
                    // tokenize the line
                    string[] tokens = line.Split(delim);
                    // Store the tokens in entry object
                    entry.name = tokens[0];
                    entry.phone = tokens[1];
                    // add the entry object to the list
                    phoneList.Add(entry);
               } // end while

            } // end try
            catch (Exception e)
            {
                // Display an error message
                MessageBox.Show(e.Message);
            }
        } // end Readfile

        // The DisplayName method displays the list of names
        // nameListBox control

            private void DisplayNames()
        {
            foreach (PhonebookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);

            } 
            
        } // end DisplayNames()



        private void Form1_Load(object sender, EventArgs e)
        {
            // read the phoneList.txt file
            ReadFile();
            // Display the name
            DisplayNames();
        } // end form1_Load()

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item
            int index = nameListBox.SelectedIndex;
            // Display the corresponding phone number
            phoneNumLabel.Text = phoneList[index].phone;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
