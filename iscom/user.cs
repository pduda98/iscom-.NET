using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace iscom
{
    class User
    {
        public int id;
        public string name;
        public string password;
        public string description;

       
        public User(string name, string password) {
            this.name = name;
            this.password = password;
        }
        public User() { }
        public User(int id) { }
    }
}
