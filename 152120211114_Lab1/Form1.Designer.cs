namespace _152120211114_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelNo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelHata = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(12, 20);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(104, 16);
            this.labelNo.TabIndex = 0;
            this.labelNo.Text = "Öğrenci No (0-9)";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelName.Location = new System.Drawing.Point(12, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Ad (A-Z)";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 80);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(79, 16);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Soyad (A-Z)";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(22, 118);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(69, 16);
            this.labelTest.TabIndex = 3;
            this.labelTest.Text = "Test Metni";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(314, 20);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(61, 16);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Çıktılar ->";
            // 
            // labelHata
            // 
            this.labelHata.AutoSize = true;
            this.labelHata.Location = new System.Drawing.Point(378, 171);
            this.labelHata.Name = "labelHata";
            this.labelHata.Size = new System.Drawing.Size(0, 16);
            this.labelHata.TabIndex = 5;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(123, 20);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(126, 22);
            this.txtNo.TabIndex = 6;
            this.txtNo.Text = "20211114";
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 22);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Talha";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(123, 79);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(126, 22);
            this.txtSurname.TabIndex = 8;
            this.txtSurname.Text = "Yilmam";
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(15, 137);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(357, 170);
            this.txtTest.TabIndex = 9;
            this.txtTest.Text = resources.GetString("txtTest.Text");
            this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(381, 20);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(315, 148);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.Text = "Çıktılarınız çalıştırdıktan sonra burada gözükecektir.";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(381, 234);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(315, 73);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Çalıştır";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 330);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.labelHata);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNo);
            this.Name = "Form1";
            this.Text = "Uygulama-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelHata;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnRun;
    }
}

