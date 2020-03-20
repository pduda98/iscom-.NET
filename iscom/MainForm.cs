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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = (string)CurrentUser.name;
            descriptionTextBox.Text = (string)CurrentUser.description;
            this.Controls.Add(descriptionTextBox);
            this.Controls.Add(nameTextBox);
            /*
            User u = UserHandler.get(CurrentUser.id);
            nameTextBox.Text = (string)u.name;
            descriptionTextBox.Text = (string)u.description;*/
        }
    }
}
