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
            var connectionString = dbConnect.GetConnectionString();
            var customerID = textCustomerID.Text;

            using (var cmd = new System.Data.SqlClient.SqlCommand())
            {
                DatabaseConnect connect = new DatabaseConnect();
                connect.Connect();
                cmd.Connection = connect;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT firstname, lastname FROM customers WHERE cid = @CustomerID";
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
            }
        }
    }
}
