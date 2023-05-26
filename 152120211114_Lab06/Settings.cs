using _152120211114_Lab4;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public Settings(bool isAdmin) 
        {
            InitializeComponent();
            if (!isAdmin)
            {
                adminPanelButton.Visible = false;
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            TicTacToe game = new TicTacToe();
            game.Show();
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }
    }
}
