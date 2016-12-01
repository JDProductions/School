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

        private String  myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=Chicken12;database=pos;";

        public String GetConnectionString()
        {
            return myConnectionString;
        }
        public void Connect()
        {



            try
            {
                var conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static implicit operator SqlConnection(DatabaseConnect v)
        {
            throw new NotImplementedException();
        }
    }
}
