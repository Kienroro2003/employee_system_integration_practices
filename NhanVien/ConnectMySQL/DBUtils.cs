using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NhanVien.ConnectMySQL
{
    public class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "human";
            string username = "root";
            string password = "12345678";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}