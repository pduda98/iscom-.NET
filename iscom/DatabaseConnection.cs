using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace iscom
{
    static class DatabaseConnection
    {
        static public string MysqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=iscom";
       // static public string MysqlConnectionString = "datasource=sql3.5v.pl; port=3306; username=db-user55964; password=wtekcefjnvwt3omk; database=db-user55964";
        static public MySqlConnection databaseconnection = new MySqlConnection(MysqlConnectionString);
        //MySqlCommand databasecommand = new MySqlCommand(query, databaseconnection);
        //databasecommand.CommandTimeout = 60;
    }
}
