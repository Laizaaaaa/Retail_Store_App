using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EDP
{
    public static class DBConnection
    {
        private static readonly string connectionString = "server=localhost;user id=root;password=laiza07;database=retail_store;";
        private static MySqlConnection connection;

        public static MySqlConnection GetConnection()
        {
            if (connection == null)
                connection = new MySqlConnection(connectionString);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}

