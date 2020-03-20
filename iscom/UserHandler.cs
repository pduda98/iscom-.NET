using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace iscom
{
    static class UserHandler
    {
        public static bool add(User user)
        {
            if (user.name == "" || user.password == "")
            {

                return false;
            }
            else
            {

                string query = "INSERT INTO `users`(`id`, `username`, `password`, `description`) VALUES(NULL,'" + user.name + "','" + user.password + "',NULL)";
                MySqlCommand databasecommand = new MySqlCommand(query, DatabaseConnection.databaseconnection);
                databasecommand.CommandTimeout = 60;

                try
                {
                    DatabaseConnection.databaseconnection.Open();
                    MySqlDataReader myReader = databasecommand.ExecuteReader();

                    //if (myReader.HasRows)
                    ///{
                    return true;

                }
                catch (Exception e1)
                {
                    Console.WriteLine("blad: " + e1.Message);
                }
                DatabaseConnection.databaseconnection.Close();
                return false;
            }
        }

        public static User get(int  id)
        { 
            User u = new User();
            u.id = id;
            string query = "SELECT name,description FROM `users` WHERE id = " + id + ";";
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
                        u.name = (string)myReader["name"];
                        u.description = (string)myReader["description"];
                        //Console.WriteLine(myReader.GetString(0) + " " + myReader.GetString(1) + " " + myReader.GetString(2) + " " + myReader.GetString(3));
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine("blad: " + e1.Message);
            }
            DatabaseConnection.databaseconnection.Close();
            return u;
        }
    }
}
    

