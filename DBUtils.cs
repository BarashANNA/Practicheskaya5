using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FlyBallon
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "FlyBalloon";
            string username = "root";
            string password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
