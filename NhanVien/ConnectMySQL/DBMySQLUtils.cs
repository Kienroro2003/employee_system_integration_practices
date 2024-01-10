using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace NhanVien.ConnectMySQL
{
    public class DBMySQLUtils
    {
        public static MySqlConnection
                GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;
            string connStr = "server=127.0.0.1;user=root;database=human;password=12345678;";
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "127.0.0.1";
            conn_string.UserID = "root";
            conn_string.Password = "12345678";
            conn_string.Database = "human";
            conn_string.Port = 3306;
            string connectionString = "SERVER=" + host + ";" + "DATABASE=" +
        database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }
    }
}