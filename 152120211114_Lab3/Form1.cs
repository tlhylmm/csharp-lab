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
using System.IO;


namespace _152120211114_Lab3
{

    public partial class Form1 : Form
    {
        //Caesar ciphering begin
        private static char CipherCaesar(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }

        public static string EncipherCaesar(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += CipherCaesar(ch, key);

            return output;
        }

        public static string DecipherCaesar(string input, int key)
        {
            return EncipherCaesar(input, 26 - key);
        }

        //Caesar ciphering end

        //Vigenere ciphering begin

        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        private static string CipherVigenere(string input, string key, bool encipher)
        {
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return null; // Error

            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool cIsUpper = char.IsUpper(input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }

            return output;
        }

        public static string EncipherVigenere(string input, string key)
        {
            return CipherVigenere(input, key, true);
        }

        public static string DecipherVigenere(string input, string key)
        {
            return CipherVigenere(input, key, false);
        }

        //Vigenere ciphering end

        public Form1()
        {
            InitializeComponent();
        }

        private void noBox_TextChanged(object sender, EventArgs e)
        {
            if (noBox.Text.Length != 8) 
            {
                noBox.ForeColor = Color.Red;
                warnLabel.Text = "8 karakterden oluşmalıdır.";
                runBtn.Enabled = false;
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(noBox.Text, "[^0-9]"))
                {
                    runBtn.Enabled = false;
                    noBox.ForeColor = Color.Red;
                    warnLabel.Text = "Lütfen sadece rakam";
                }
                else
                {
                    noBox.ForeColor = Color.Black;
                    warnLabel.Text = "";
                    runBtn.Enabled = true;
                }
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                runBtn.Enabled = false;
            }
            else
            {
                runBtn.Enabled = true;
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            //set algorithm type
            string algorithm;
            if (caesarBtn.Checked == true)
            {
                algorithm = "Caesar";
            }
            else
            {
                algorithm = "Vigenere";
            }

            //set operation type
            string operation;

            if (encryptBtn.Checked == true)
            {
                operation = "encrypt";   
            }
            else
            {
                operation = "decrypt";
            }

            string encCaesar = EncipherCaesar(inputBox.Text, 7);
            string decCaesar = DecipherCaesar(inputBox.Text, 7);
            string encVigenere = EncipherVigenere(inputBox.Text, "esoguce");
            string decVigenere = DecipherVigenere(inputBox.Text, "esoguce");

            string output = "null";

            if (algorithm == "Caesar")
            {
                if (operation == "encrypt")
                {
                    output = encCaesar;
                }
                else //decrypt
                {
                    output = decCaesar;
                }
            }
            else //vigenere
            {
                if (operation == "encrypt")
                {
                    output = encVigenere;
                }
                else //decrypt
                {
                    output = decVigenere;
                }
            }

            testClass tst = new testClass();

            resultLabel.Text = output;
            
            
            //start file writing
            string filename = noBox.Text + ".csv";
            using (StreamWriter buffer = new StreamWriter(filename, false))
            {
                buffer.WriteLine(output);
                buffer.Close();
            }

            scoreLabel.Text = tst.testFuncApp3(noBox.Text, inputBox.Text, algorithm,
                                                operation, output,
                                                encCaesar, encVigenere,
                                                decCaesar, decVigenere).ToString();


        }
    }
}
