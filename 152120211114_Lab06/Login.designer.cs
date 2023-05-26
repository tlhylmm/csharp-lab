namespace _152120211114_Lab5
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.showPassBox = new System.Windows.Forms.CheckBox();
            this.rememberBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(174, 206);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(91, 60);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.TabStop = false;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(73, 56);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(192, 22);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(73, 109);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(192, 22);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 273);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 5;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(73, 206);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(91, 60);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.TabStop = false;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // showPassBox
            // 
            this.showPassBox.AutoSize = true;
            this.showPassBox.Location = new System.Drawing.Point(73, 144);
            this.showPassBox.Name = "showPassBox";
            this.showPassBox.Size = new System.Drawing.Size(125, 20);
            this.showPassBox.TabIndex = 7;
            this.showPassBox.Text = "Show Password";
            this.showPassBox.UseVisualStyleBackColor = true;
            this.showPassBox.CheckedChanged += new System.EventHandler(this.showPassBox_CheckedChanged);
            // 
            // rememberBox
            // 
            this.rememberBox.AutoSize = true;
            this.rememberBox.Location = new System.Drawing.Point(73, 170);
            this.rememberBox.Name = "rememberBox";
            this.rememberBox.Size = new System.Drawing.Size(119, 20);
            this.rememberBox.TabIndex = 8;
            this.rememberBox.Text = "Remember Me";
            this.rememberBox.UseVisualStyleBackColor = true;
            this.rememberBox.CheckedChanged += new System.EventHandler(this.rememberBox_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 298);
            this.Controls.Add(this.rememberBox);
            this.Controls.Add(this.showPassBox);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.CheckBox showPassBox;
        private System.Windows.Forms.CheckBox rememberBox;
    }
}

