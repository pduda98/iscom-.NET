using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace iscom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            string query = textBox1.Text;
            if (query == "")
            {
                MessageBox.Show("asjdoasjdoija");
                return;
            }
            else
            {
                string MysqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test";
                MySqlConnection databaseconnection = new MySqlConnection(MysqlConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconnection);
                databasecommand.CommandTimeout = 60;

                try
                {
                    databaseconnection.Open();
                    MySqlDataReader myReader = databasecommand.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        MessageBox.Show("resultat");
                        while (myReader.Read())
                        {
                            Console.WriteLine(myReader.GetString(0) + " " + myReader.GetString(1) + " " + myReader.GetString(2) + " " + myReader.GetString(3));
                        }
                    }
                    else
                    {
                        MessageBox.Show("query success");
                    }



                }
                catch (Exception e1)
                {
                    MessageBox.Show("query nie success" + e1.Message);
                }

            }*/
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            var frm = new SignupForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            var frm = new LoginForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
