using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120211114_Lab5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            /* 3 cases:
             * admin login
             * user login
             * wrong input
             */
            //admin login
            if (usernameBox.Text == "admin" && passwordBox.Text == "admin")
            {
                Settings settingsForm = new Settings(true);
                this.Hide();
                settingsForm.ShowDialog();
                this.Close();
            }
            else if (usernameBox.Text == "user" && passwordBox.Text == "user")
            {
                Settings settingsForm = new Settings(false);
                this.Hide();
                settingsForm.ShowDialog();
                this.Close();
            }
            else
            {
                errorLabel.Text = "Wrong credentials. Please login as user or admin.";
            }
        }
    }
}
