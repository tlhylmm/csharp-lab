namespace _152120211114_Lab5
{
    partial class Settings
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
            this.difficultyButton = new System.Windows.Forms.Button();
            this.adminPanelButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficultyButton
            // 
            this.difficultyButton.Location = new System.Drawing.Point(12, 175);
            this.difficultyButton.Name = "difficultyButton";
            this.difficultyButton.Size = new System.Drawing.Size(160, 73);
            this.difficultyButton.TabIndex = 0;
            this.difficultyButton.Text = "Difficulty Level";
            this.difficultyButton.UseVisualStyleBackColor = true;
            // 
            // adminPanelButton
            // 
            this.adminPanelButton.Location = new System.Drawing.Point(331, 175);
            this.adminPanelButton.Name = "adminPanelButton";
            this.adminPanelButton.Size = new System.Drawing.Size(160, 73);
            this.adminPanelButton.TabIndex = 0;
            this.adminPanelButton.Text = "Admin Panel";
            this.adminPanelButton.UseVisualStyleBackColor = true;
            this.adminPanelButton.Click += new System.EventHandler(this.adminPanelButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(628, 175);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(160, 73);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.adminPanelButton);
            this.Controls.Add(this.difficultyButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button difficultyButton;
        private System.Windows.Forms.Button adminPanelButton;
        private System.Windows.Forms.Button newGameButton;
    }
}