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
    public partial class UserInfo : Form
    {
        bool isUpdate;
        DataSet ds;
        string username;
        public UserInfo(bool isUpdate, DataSet ds)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.ds = ds;
        }

        public UserInfo(string id, string userType, string username,
                        string password, string nameSurname, string mail,
                        bool isUpdate, DataSet ds)
        {
            InitializeComponent();
            idBox.Text = id;
            usertypeBox.Text = userType;
            usernameBox.Text = username;
            passwordBox.Text = password;
            nameBox.Text = nameSurname;
            mailBox.Text = mail;
            this.isUpdate = isUpdate;
            this.ds = ds;
            this.username = username;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {
                MessageBox.Show("Username can not be empty.");
                return;
            }

            //create new person
            if (!isUpdate)
            {
                DataRow newRow;
                newRow = ds.Tables["user"].NewRow();
                newRow["ID"] = idBox.Text;
                newRow["userType"] = usertypeBox.Text;
                newRow["userName"] = usernameBox.Text;
                newRow["userSurname"] = nameBox.Text;
                newRow["passWord"] = passwordBox.Text;
                newRow["userMail"] = mailBox.Text;
                ds.Tables["user"].Rows.Add(newRow);

                ds.AcceptChanges();
                ds.WriteXml(@"..\..\20211114.xml");
            }
            //update the selected user
            else
            {
                string search = "userName = '" + username + "'";
                DataRow[] foundRows = ds.Tables["user"].Select(search);
                foreach (DataRow dr in foundRows)
                {
                    dr["ID"] = idBox.Text;
                    dr["userType"] = usertypeBox.Text;
                    dr["userName"] = usernameBox.Text;
                    dr["userSurname"] = nameBox.Text;
                    dr["passWord"] = passwordBox.Text;
                    dr["userMail"] = mailBox.Text;
                }

                ds.AcceptChanges();
                ds.WriteXml(@"..\..\20211114.xml");
            }
            this.Close();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }
    }
}
