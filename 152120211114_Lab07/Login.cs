using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _152120211114_Lab5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            string line = File.ReadAllText(@"..\..\remember.txt");
            if(line != "") { 
                string[] info = line.Split(',');
                if (info.Length == 2)
                {
                    usernameBox.Text = info[0];
                    passwordBox.Text = info[1];
                    rememberBox.Checked = true;
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter buffer = new StreamWriter(@"..\..\remember.txt", false))
            {
                if (rememberBox.Checked)
                {
                    buffer.Write(usernameBox.Text + "," + passwordBox.Text);
                    buffer.Close();
                }
                else
                {
                    buffer.Write("");
                    buffer.Close();
                }
            }

            /* 4 cases:
             * admin login
             * user login
             * registered user
             * wrong input
             */

            //admin login
            if (usernameBox.Text == "admin" && passwordBox.Text == "admin")
            {
                Settings settingsForm = new Settings(true);
                this.Hide();
                settingsForm.ShowDialog();
                this.Close();
                return;
            }
            else if (usernameBox.Text == "user" && passwordBox.Text == "user")
            {
                Settings settingsForm = new Settings(false);
                this.Hide();
                settingsForm.ShowDialog();
                this.Close();
                return;
            }

            DataSet ds = new DataSet();
            ds.ReadXml(@"..\..\20211114.xml");


            DataTable table = ds.Tables["user"];
            //search for username password match in database
            foreach (DataRow row in table.Rows)
            {
                if (row["userName"].ToString() == usernameBox.Text &&
                    row["passWord"].ToString() == passwordBox.Text)
                {
                    Settings settingsForm;
                    //if it's a admin type user
                    if (row["userType"].ToString() == "admin") 
                        settingsForm = new Settings(true);
                    //if not an admin type user
                    else
                        settingsForm = new Settings(false);

                    this.Hide();
                    settingsForm.ShowDialog();
                    this.Close();
                    return;
                }

            }
            MessageBox.Show("Wrong credentials. You can login with \"admin\", \"user\" " +
                            "or with a registered username.");
        }

        private void showPassBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassBox.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar= true;
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"..\..\20211114.xml");
            UserInfo registerForm = new UserInfo(false, ds);
            registerForm.ShowDialog();
        }

        private void rememberBox_CheckedChanged(object sender, EventArgs e)
        {
            using (StreamWriter buffer = new StreamWriter(@"..\..\remember.txt", false))
            {
                if (rememberBox.Checked)
                {
                    buffer.Write(usernameBox.Text + "," + passwordBox.Text);
                    buffer.Close();
                }
                else
                {
                    buffer.Write("");
                    buffer.Close();
                }
            }
        }
    }
}
