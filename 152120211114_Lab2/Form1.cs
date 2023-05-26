using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using testScript;

namespace _152120211114_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        //search function to match username from database
        static bool searchStudent(Student student)
        {
            string[] lines = File.ReadAllLines("UserInfo.csv");

            foreach (string line in lines)
            {
                string[] cells = line.Split(',');
                if (cells[0] == student.username)
                {
                    return true;
                }
            }
            return false;
        }

        //search function to check database and match username, password:
        static bool canLogin(Student student)
        {
            string[] lines = File.ReadAllLines("UserInfo.csv");

            foreach (string line in lines)
            {
                string[] cells = line.Split(',');
                if (cells[0] == student.username && cells[1] == hashSHA256(student.password))
                {
                    return true;
                }
            }
            return false;
        }

        //a function to open the second window if login is succesfull:
        public void popUpForm2(string username)
        {
            Form2  form2 = new Form2(username);
            form2.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //check if the credentials are in correct form:
            //if empty
            if(boxUsername.Text == "" || boxPass.Text == "") 
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Please fill in all the boxes.";
                return;
            }
            else 
            {
                //check username length
                if (boxUsername.Text.Length < 6)
                {
                    labelWarning.ForeColor = Color.Red;
                    labelWarning.Text = "Username must be at least 6 characters long.";
                    return;
                }
                else
                {
                    //check password length
                    if(boxPass.Text.Length < 6) 
                    {
                        labelWarning.ForeColor = Color.Red;
                        labelWarning.Text = "Password must be at least 6 characters long.";
                        return;
                    }
                }
            }

            //if all in correct form, ask confirmation:
            labelWarning.Text = "";

            if (!boxConfirm.Visible)
            {
                boxConfirm.Visible = true;
                return;
            }

            if (boxConfirm.Text != boxPass.Text)
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Passwords doesn't match.";
                return;
            }

            //construct a student object:
            Student student = new Student(boxUsername.Text, boxPass.Text);

            //do hashing:
            string hashedPass = hashSHA256(student.password);

            //look for the student in UserInfo.csv:
            if (!searchStudent(student))
            {
                //start writing
                string fileName = "UserInfo.csv";
                using (StreamWriter buffer = new StreamWriter(fileName, true))
                {
                    buffer.WriteLine(student.username + "," + hashedPass);
                    buffer.Close();
                    labelWarning.ForeColor = Color.Black;
                    labelWarning.Text = "Successfully signed up. You can now login.";
                }
            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "User already exists. Please Login.";
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //check if the credentials are in correct form:
            //if empty
            if (boxUsername.Text == "" || boxPass.Text == "")
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Please fill in all the boxes.";
                return;
            }
            else
            {
                //check username length
                if (boxUsername.Text.Length < 6)
                {
                    labelWarning.ForeColor = Color.Red;
                    labelWarning.Text = "Username must be at least 6 characters long.";
                    return;
                }
                else
                {
                    //check password length
                    if (boxPass.Text.Length < 6)
                    {
                        labelWarning.ForeColor = Color.Red;
                        labelWarning.Text = "Password must be at least 6 characters long.";
                        return;
                    }
                }
            }


            //construct a new Student object:
            Student student = new Student(boxUsername.Text, boxPass.Text);

            testClass tst = new testClass();

            //check if user exists in database
            if (!searchStudent(student) )
            {
                if (!tst.testUserCheck(student.username, hashSHA256(student.password)))
                {
                    labelWarning.ForeColor = Color.Red;
                    labelWarning.Text = "User not found in database or admin credentials incorrect.";
                    return;
                }
            }

            //check if existing user's password is correct:
            if (!canLogin(student) )
            {
                if (!tst.testUserCheck(student.username, hashSHA256(student.password)))
                {
                    labelWarning.ForeColor = Color.Red;
                    labelWarning.Text = "Incorrect password. Try again.";
                    return;
                }
            }

            popUpForm2(student.username);
        }
    }
}
