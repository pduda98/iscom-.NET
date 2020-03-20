using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace iscom
{
    static class CurrentUser
    {
        public static int id;
        public static string name;
        public static string description;
        public static int createGroup()
        {
            return 0;
        }

        public static int updateDescription(string description)
        {
            return 0;
        }

        public static void login(string user_name, string password)
        {
            //string query = textBox1.Text;
            if (user_name == "" || password == "")
            {
                //MessageBox.Show("asjdoasjdoija");
                return;
            }
            else
            {
                //string MysqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test";
                //MySqlConnection databaseconnection = new MySqlConnection(DatabaseConnection.MysqlConnectionString);
                string query = "SELECT `id`, `username`, `password`, `description` FROM `users` WHERE username = '" + user_name + "' AND password = '" + password + "'";
                MySqlCommand databasecommand = new MySqlCommand(query, DatabaseConnection.databaseconnection);
                databasecommand.CommandTimeout = 60;

                try
                {
                    DatabaseConnection.databaseconnection.Open();
                    MySqlDataReader myReader = databasecommand.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        //MessageBox.Show("resultat");
                        while (myReader.Read())
                        {
                            id =(int)myReader["id"];
                            name = (string)myReader["username"];
                            description = (string)myReader["description"];//      
                            //Console.WriteLine(myReader.GetString(0) + " " + myReader.GetString(1) + " " + myReader.GetString(2) + " " + myReader.GetString(3));
                        }
                    }
                   
                   
                   // else
                    //{
                        //MessageBox.Show("query success");
                    //}



                }
                catch (Exception e1)
                {
                    Console.WriteLine("query nie success" + e1.Message);
                }
                DatabaseConnection.databaseconnection.Close();
                return;
            }
        }
    }
}
