using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeersBought
{
    class DatabaseConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string query = null;
        private static Form1 form1 = new Form1();
        private TextBox box;
        private TextBox pbeerName, pcompanyName;
        private TextBox mDeleteTextBox;

        public String getstring()
        {
            return query;
        }

        public DatabaseConnect(Form1 form)
        {
           
        }

        public void GeTextBox(TextBox something)
        {
            box = something;
           

        }

        public void GetCompanyInfo(TextBox beerName, TextBox companyName)
        {
            pbeerName = beerName;
            pcompanyName = companyName;
        }

        public void GetCustomerIDToDelete(TextBox customer)
        {
            mDeleteTextBox = customer;
            var test = "sweet";
        }



        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "pos";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public DatabaseConnect()
        {
            Initialize();
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert()
        {
            query = string.Format("INSERT INTO `pos`.`beers` (`title`, `brewery`) VALUES ('{0}', '{1}');",pbeerName.Text,pcompanyName.Text);

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            query = string.Format("UPDATE `pos`.`beersbought` SET `quanitybought`= quanitybought+1 WHERE `cid`= {0} ;",box.Text);

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    

        //Delete statement
        public void Delete()
        {
            query = string.Format("DELETE FROM customers WHERE `cid`= {0};", mDeleteTextBox.Text);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<string>[] Select()
        {
            //string query = "SELECT firstname, lastname, quanitybought FROM customers s, beersbought a WHERE exists(SELECT 'x' FROM beersbought b WHERE b.cid = s.cid)";
            //var customerID = form1.GetText();
            query = string.Format("SELECT firstname, lastname, quanitybought FROM customers s, beersbought a WHERE exists(SELECT 'x' FROM beersbought b WHERE b.cid = {0} AND  s.cid = {1})",box.Text,box.Text);



            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["firstname"] + "");
                    list[1].Add(dataReader["lastname"] + "");
                    list[2].Add(dataReader["quanitybought"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            
}
        }

        ////Count statement
        //public int Count()
        //{
        //}

        ////Backup
        //public void Backup()
        //{
        //}

        ////Restore
        //public void Restore()
        //{
        //}
    }

