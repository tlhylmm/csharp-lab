namespace _152120211114_Lab3
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
            this.label1 = new System.Windows.Forms.Label();
            this.noBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vigenereBtn = new System.Windows.Forms.RadioButton();
            this.caesarBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.decryptBtn = new System.Windows.Forms.RadioButton();
            this.encryptBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.warnLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // noBox
            // 
            this.noBox.Location = new System.Drawing.Point(212, 35);
            this.noBox.Name = "noBox";
            this.noBox.Size = new System.Drawing.Size(156, 22);
            this.noBox.TabIndex = 1;
            this.noBox.Text = "20211114";
            this.noBox.TextChanged += new System.EventHandler(this.noBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vigenereBtn);
            this.groupBox1.Controls.Add(this.caesarBtn);
            this.groupBox1.Location = new System.Drawing.Point(94, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritmalar";
            // 
            // vigenereBtn
            // 
            this.vigenereBtn.AutoSize = true;
            this.vigenereBtn.Location = new System.Drawing.Point(19, 71);
            this.vigenereBtn.Name = "vigenereBtn";
            this.vigenereBtn.Size = new System.Drawing.Size(83, 20);
            this.vigenereBtn.TabIndex = 1;
            this.vigenereBtn.TabStop = true;
            this.vigenereBtn.Text = "Vigenère";
            this.vigenereBtn.UseVisualStyleBackColor = true;
            // 
            // caesarBtn
            // 
            this.caesarBtn.AutoSize = true;
            this.caesarBtn.Checked = true;
            this.caesarBtn.Location = new System.Drawing.Point(19, 32);
            this.caesarBtn.Name = "caesarBtn";
            this.caesarBtn.Size = new System.Drawing.Size(72, 20);
            this.caesarBtn.TabIndex = 0;
            this.caesarBtn.TabStop = true;
            this.caesarBtn.Text = "Caesar";
            this.caesarBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.decryptBtn);
            this.groupBox2.Controls.Add(this.encryptBtn);
            this.groupBox2.Location = new System.Drawing.Point(402, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifreleme/Deşifreleme";
            // 
            // decryptBtn
            // 
            this.decryptBtn.AutoSize = true;
            this.decryptBtn.Location = new System.Drawing.Point(19, 71);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(101, 20);
            this.decryptBtn.TabIndex = 1;
            this.decryptBtn.Text = "Deşifreleme";
            this.decryptBtn.UseVisualStyleBackColor = true;
            // 
            // encryptBtn
            // 
            this.encryptBtn.AutoSize = true;
            this.encryptBtn.Checked = true;
            this.encryptBtn.Location = new System.Drawing.Point(19, 32);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(85, 20);
            this.encryptBtn.TabIndex = 0;
            this.encryptBtn.TabStop = true;
            this.encryptBtn.Text = "Şifreleme";
            this.encryptBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifrelenecek/Şifresi Çözülecek Metin:";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(94, 100);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(521, 22);
            this.inputBox.TabIndex = 5;
            this.inputBox.Text = "MERHABA DUNYALI NASILSIN";
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifrelenmiş/Deşifrelenmiş Metin:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(294, 314);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 16);
            this.resultLabel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Not: Çıkan sonuç metnine çift tıklayarak kopyalayabilirsiniz.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Skor:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(582, 38);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 16);
            this.scoreLabel.TabIndex = 10;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(541, 314);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(135, 52);
            this.runBtn.TabIndex = 11;
            this.runBtn.Text = "Şifrele/Deşifrele";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.Location = new System.Drawing.Point(374, 38);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(0, 16);
            this.warnLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warnLabel);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.noBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton vigenereBtn;
        private System.Windows.Forms.RadioButton caesarBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton decryptBtn;
        private System.Windows.Forms.RadioButton encryptBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label warnLabel;
    }
}

