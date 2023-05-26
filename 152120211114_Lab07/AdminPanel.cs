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
    public partial class AdminPanel : Form
    {
        DataSet ds;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds.ReadXml(@"..\..\20211114.xml");
            dataGridView1.DataSource = ds.Tables[0];
            addBtn.Enabled = true;
            updateBtn.Enabled = true;
            dataGridView1.ClearSelection();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(false, ds);
            userInfo.ShowDialog();
            dataGridView1.ClearSelection();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please make a selection");
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string userType = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string username = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string nameSurname = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string password = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string mail = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            UserInfo userInfo = new UserInfo(id, userType, username, password, nameSurname, mail,
                                             true, ds);
            userInfo.ShowDialog();
            dataGridView1.ClearSelection();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (deleteBox.Text == "")
            {
                MessageBox.Show("Please enter a username for delete operation.");   
                return;
            }

            string username = deleteBox.Text;
            string search = "userName = '" + username + "'";
            DataRow[] findRows = ds.Tables["user"].Select(search);
            if (findRows.Length == 0) 
            {
                MessageBox.Show("The user could not been found");
                return;
            }

            foreach (DataRow dr in findRows)
                dr.Delete();
            ds.WriteXml(@"..\..\20211114.xml");

            MessageBox.Show("Succesfully deleted");
        }
    }
}
