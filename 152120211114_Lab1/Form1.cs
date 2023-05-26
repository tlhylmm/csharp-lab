using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testScript;

namespace _152120211114_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //create new test object
        testClass test = new testClass();

        //create new student object
        Student ogrenci = new Student();

        int studentNo;
        private void txtNo_TextChanged(object sender, EventArgs e)
        {

            //check if string is all numbers and 8 characters long
            if ( !int.TryParse(txtNo.Text, out studentNo) || txtNo.Text.Length != 8)
            {
                btnRun.Enabled = false;
                labelNo.ForeColor = Color.Red;
                labelHata.Text = "Öğrenci no sadece rakam içermeli\nve uzunluğu 8 olmalıdır";
            }
            else 
            {  
                btnRun.Enabled = true;
                labelNo.ForeColor = Color.Black;
                labelHata.Text = ""; 
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //check if it contains only letters
            if ( !txtName.Text.All(Char.IsLetter) )
            {
                btnRun.Enabled= false;
                labelName.ForeColor = Color.Red;
                labelHata.Text= "İsim tek olmalı ve sadece harflerden oluşmalıdır";
            }
            else
            {
                btnRun.Enabled = true;
                labelName.ForeColor = Color.Black;
                labelHata.Text = "";
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            //check if it contains only letters
            if (!txtSurname.Text.All(Char.IsLetter))
            {
                btnRun.Enabled = false;
                labelSurname.ForeColor = Color.Red;
                labelHata.Text = "Soyisim tek olmalı ve sadece harflerden oluşmalıdır";
            }
            else
            {
                btnRun.Enabled = true;
                labelSurname.ForeColor = Color.Black;
                labelHata.Text = "";
            }
        }

        int letterCount;
        int numberCount;
        private void txtTest_TextChanged(object sender, EventArgs e)
        {
            //count numbers and letters in string
            letterCount = txtTest.Text.Count(Char.IsLetter);
            numberCount = txtTest.Text.Count(Char.IsDigit);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //set student object properties:
            int.TryParse(txtNo.Text, out studentNo);
            ogrenci.studentNo = studentNo;
            ogrenci.studentName = txtName.Text;
            ogrenci.studentSurname = txtSurname.Text;

            letterCount = txtTest.Text.Count(Char.IsLetter);
            numberCount = txtTest.Text.Count(Char.IsDigit);

            txtOutput.Text = "Öğrenci No: " + ogrenci.studentNo
                            + "\r\nAd: " + ogrenci.studentName
                            + "\r\nSoyadı: " + ogrenci.studentSurname
                            + "\r\nMetindeki Rakam Sayısı: " + numberCount
                            + "\r\nMetindeki Harf Sayısı: " + letterCount
                            + "\r\nÖğrencinin Skoru: " + test.testFunc(ogrenci.studentNo,
                                                                       ogrenci.studentName,
                                                                       ogrenci.studentSurname,
                                                                       txtTest.Text,
                                                                       numberCount,
                                                                       letterCount);
            labelHata.Text = "Uyarı: İsim ve Soyisimde Türkçe karakter kullanımı" +
                             "\nSkorda 10 puanlık bir azalmaya sebep olabilir." +
                             "\nLütfen kontrol ediniz.";
        }
    }
}
