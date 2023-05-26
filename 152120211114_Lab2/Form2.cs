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
using System.Security.Cryptography;
using testScript;

namespace _152120211114_Lab2
{
    public partial class Form2 : Form
    {
        public Form2(string username)
        {
            InitializeComponent();
            labelUsername.Text = username;
        }

        //hash function for SHA-256
        static string hashSHA256(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            testClass tst = new testClass();

            //start writing
            string fileName = labelUsername.Text + ".csv";
            using (StreamWriter buffer = new StreamWriter(fileName, true))
            {
                buffer.WriteLine(hashSHA256(boxText.Text));
                buffer.Close();
            }


            labelScore.Text = tst.testFuncApp2(labelUsername.Text, boxText.Text).ToString();
        }
    }
}
