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

namespace _152120211114_Lab07
{
    public partial class Difficulty : Form
    {

        public Difficulty()
        {
            InitializeComponent();
        }

        private void easyBtn_MouseHover(object sender, EventArgs e)
        {
            infoLabel.Text = "Minimax algorithm will only calculate the next 2 moves.";
        }

        private void mediumBtn_MouseHover(object sender, EventArgs e)
        {
            infoLabel.Text = "Minimax algorithm will only calculate the next 5 moves.";
        }

        private void hardBtn_MouseHover(object sender, EventArgs e)
        {
            infoLabel.Text = "Minimax algorithm will only calculate the next 4 moves." +
                "\n(Reduced for performance)";
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            infoLabel.Text = "";
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            TicTacToeEasy newGame = new TicTacToeEasy();
            newGame.Show();
            this.Close();
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            TicTacToeMedium newGame = new TicTacToeMedium();
            newGame.Show();
            this.Close();
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            TicTacToeHard newGame = new TicTacToeHard();
            newGame.Show();
            this.Close();
        }
    }
}
