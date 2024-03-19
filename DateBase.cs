using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    internal class DateBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=firstdb");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connection.Open() " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public void closeConnection()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
