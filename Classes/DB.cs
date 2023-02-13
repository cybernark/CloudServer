using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServer
{
    internal class DB
    {
        private MySqlConnection connection;

        public void openConnection()
        {
            connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=cloudserver");
            if (connection.State == System.Data.ConnectionState.Closed) 
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
                connection.Dispose();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
