namespace _152120211114_Lab07
{
    partial class Difficulty
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
            this.easyBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyBtn
            // 
            this.easyBtn.Location = new System.Drawing.Point(51, 73);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(132, 71);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            this.easyBtn.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.easyBtn.MouseHover += new System.EventHandler(this.easyBtn_MouseHover);
            // 
            // mediumBtn
            // 
            this.mediumBtn.Location = new System.Drawing.Point(189, 73);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(132, 71);
            this.mediumBtn.TabIndex = 1;
            this.mediumBtn.Text = "Medium";
            this.mediumBtn.UseVisualStyleBackColor = true;
            this.mediumBtn.Click += new System.EventHandler(this.mediumBtn_Click);
            this.mediumBtn.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.mediumBtn.MouseHover += new System.EventHandler(this.mediumBtn_MouseHover);
            // 
            // hardBtn
            // 
            this.hardBtn.Location = new System.Drawing.Point(327, 73);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(132, 71);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            this.hardBtn.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.hardBtn.MouseHover += new System.EventHandler(this.hardBtn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select difficulty:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(51, 163);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 16);
            this.infoLabel.TabIndex = 4;
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 215);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardBtn);
            this.Controls.Add(this.mediumBtn);
            this.Controls.Add(this.easyBtn);
            this.Name = "Difficulty";
            this.Text = "Difficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
    }
}