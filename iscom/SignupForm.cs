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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string user_name = usernameTextBox.Text;
            string password1 = passwordTextBox1.Text;
            string password2 = passwordTextBox2.Text;

            //CurrentUser.login(user_name, password);
            if (user_name == "" || password1 == "")
            {
                MessageBox.Show("Niepoprawne dane");
                return;
            }

            if (password1 != password2)
            {
                MessageBox.Show("Hasła nie sa takie same");
                return;
            }

            User u = new User(user_name,password1);
            if (UserHandler.add(u))
            {

                MessageBox.Show("zarejestrowano pomyslnie");
                var frm = new LoginForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Błąd podczas rejestracji");
            return;

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
