using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeersBought
{
    public partial class Form1 : Form
    {

        public TextBox test = new TextBox();
        public TextBox beerName, companyName = new TextBox();
        public TextBox deleteCustomer = new TextBox();


        private DatabaseConnect dbConnect = new DatabaseConnect();
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonSearchID_Click(object sender, EventArgs e)
        {
            // Take text from the user
            // Set id in placeholder
            // Retrieve data and set quantity text
            DatabaseConnect connect = new DatabaseConnect();
            test.Text = textCustomerID.Text;
            connect.GeTextBox(test);
            var list = connect.Select();
            lblFirstName.Text = list[0][0].ToString();
            lblLastName.Text = list[1][0].ToString();
            quantityBought.Text = list[2][0].ToString();

        }

        private void btnBudLight_Click(object sender, EventArgs e)
        {
            DatabaseConnect connect = new DatabaseConnect();
            connect.GeTextBox(test);
            connect.Update();
            MessageBox.Show("Database Quanity Updated, Please Check your database");
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DatabaseConnect connect = new DatabaseConnect();
            deleteCustomer = txtDeleteCustomer;
            connect.GetCustomerIDToDelete(deleteCustomer);
            connect.Delete();
        }

        private void btnAddBeer_Click(object sender, EventArgs e)
        {
            DatabaseConnect  connect = new DatabaseConnect();
            beerName = txtBeerName;
            companyName = txtBreweryName;
            connect.GetCompanyInfo(beerName,companyName);
            connect.Insert();
            MessageBox.Show("New Beer Added, Check your Database!");
        }
    }
}
