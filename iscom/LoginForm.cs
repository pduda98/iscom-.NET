using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iscom
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
            CurrentUser.id = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            
            CurrentUser.login(user_name, password);
            if(CurrentUser.id == -1)
            {
                MessageBox.Show("Błąd logowania");
                return;

            }
           
            MessageBox.Show("id="+CurrentUser.id);
            var frm = new MainForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
