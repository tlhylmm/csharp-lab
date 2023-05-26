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
using _152120211114_Lab5;
using _152120211114_Lab07;

namespace _152120211114_Lab4
{
    public partial class TicTacToeEasy : Form
    {
        public TicTacToeEasy()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button[] btnArr = new Button[] {button1,button2,button3,
                                            button4,button5,button6,
                                            button7,button8,button9};

            //board with 1 dimensional indexing:
            string[] board = { button1.Text, button2.Text, button3.Text,
                               button4.Text, button5.Text, button6.Text,
                               button7.Text, button8.Text, button9.Text };




            Button button = (Button)sender;
            int index = Array.IndexOf(btnArr, button);

            if (board[index] == "") //if the button is not pressed
            {
                button.Text = "x"; //turn clicked button to x
                board[index] = "x";
                button.Enabled = false; //disable since it is clicked

                Game myGame = new Game();
                testClass tst = new testClass();

                if (!myGame.isMovesLeft(board))
                //if no moves left, check if there's a winner
                {
                    int winner = myGame.evaluate(board);
                    if (winner < 0) 
                    { 
                        labelScore.Text =  tst.testFuncXoX(noBox.Text, "x",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                        MessageBox.Show("You won!");
                        disableAllButtons();
                    }
                    else if (winner > 0)
                    {
                        labelScore.Text = tst.testFuncXoX(noBox.Text, "0",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                        MessageBox.Show("Computer won!");
                        disableAllButtons();
                    }
                    else 
                    {
                        labelScore.Text = tst.testFuncXoX(noBox.Text, "draw",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                        MessageBox.Show("It's a draw!");
                        disableAllButtons();
                    }
                }
                if (myGame.evaluate(board) < 0)
                {
                    labelScore.Text = tst.testFuncXoX(noBox.Text, "x",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                    MessageBox.Show("You won!");
                    disableAllButtons();
                }
                else if (myGame.evaluate(board) > 0)
                {
                    labelScore.Text = tst.testFuncXoX(noBox.Text, "o",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                    MessageBox.Show("Computer won!");
                    disableAllButtons();
                }
                else if (myGame.isMovesLeft(board))//if there are still moves left, let computer do it's move

                {
                    Game.Move pcMove = myGame.findBestMove(board);
                    btnArr[(pcMove.row * 3) + pcMove.col].Text = "o";
                    board[(pcMove.row * 3) + pcMove.col] = "o";
                    btnArr[(pcMove.row * 3) + pcMove.col].Enabled = false;

                    //check again if there are any moves left
                    if (myGame.evaluate(board) < 0)
                    {
                        labelScore.Text = tst.testFuncXoX(noBox.Text, "x",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                        MessageBox.Show("You won!");
                        disableAllButtons();
                    }
                    else if (myGame.evaluate(board) > 0)
                    {
                        labelScore.Text = tst.testFuncXoX(noBox.Text, "o",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                        MessageBox.Show("Computer won!");
                        disableAllButtons();
                    }
                    else if (!myGame.isMovesLeft(board))
                    //if no moves left, check if there's a winner

                    {
                        int winner = myGame.evaluate(board);
                        if (winner < 0)
                        {
                            labelScore.Text = tst.testFuncXoX(noBox.Text, "x",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                            MessageBox.Show("You won!");
                            disableAllButtons();
                        }
                        else if (winner > 0)
                        {
                            labelScore.Text = tst.testFuncXoX(noBox.Text, "o",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                            MessageBox.Show("Computer won!");
                            disableAllButtons();
                        }
                        else
                        {
                            labelScore.Text = tst.testFuncXoX(noBox.Text, "draw",
                                                           button1.Text, button2.Text, button3.Text,
                                                           button4.Text, button5.Text, button6.Text,
                                                           button7.Text, button8.Text, button9.Text).ToString();
                            MessageBox.Show("It's a draw!");
                            disableAllButtons();
                        }

                    }
                }
            }
        }

        public class Game
        {
            // "" empty string means the button is not pressed

            public class Move
            {
                public int row, col;
            }

            static string player = "x";
            static string opponent = "o";

            //A function to check if there are any moves left
            public bool isMovesLeft(string[] board)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i] == "") { return true; }
                }
                return false;
            }

            //A function to check if the current board status has any winners
            public int evaluate(string[] board)
            {
                // check the rows for triple match
                for (int row = 0; row < 3; row++)
                {
                    if (board[row * 3 + 0] == board[row * 3 + 1] &&
                        board[row * 3 + 1] == board[row * 3 + 2] && board[row * 3 + 0] != "")
                    {
                        if (board[row * 3 + 0] == opponent)
                            return +10;
                        else if (board[row * 3 + 0] == player)
                            return -10;
                    }
                }

                // check the columns for triple match
                for (int col = 0; col < 3; col++)
                {
                    if (board[0 * 3 + col] == board[1 * 3 + col] &&
                        board[1 * 3 + col] == board[2 * 3 + col] && board[0 * 3 + col] != "")
                    {
                        if (board[0 * 3 + col] == opponent)
                            return +10;

                        else if (board[0 * 3 + col] == player)
                            return -10;
                    }
                }

                // check first diagonal (\) for triple match
                if (board[0 * 3 + 0] == board[1 * 3 + 1] && board[1 * 3 + 1] == board[2 * 3 + 2] && board[0 * 3 + 0] != "")
                {
                    if (board[0 * 3 + 0] == opponent)
                        return +10;
                    else if (board[0 * 3 + 0] == player)
                        return -10;
                }

                // check second diagonal (/) for triple match
                if (board[0 * 3 + 2] == board[1 * 3 + 1] && board[1 * 3 + 1] == board[2 * 3 + 0] && board[0 * 3 + 2] != "")
                {
                    if (board[0 * 3 + 2] == opponent)
                        return +10;
                    else if (board[0 * 3 + 2] == player)
                        return -10;
                }

                // if there are no winning situations return 0
                return 0;
            }

            public int minimax(string[] board, int depth, bool isMax)
            {
                int score = evaluate(board);

                // If Maximizer has won the game 
                // return his/her evaluated score
                if (score == -10)
                    return score;

                // If Minimizer has won the game 
                // return his/her evaluated score
                if (score == +10)
                    return score;

                // If there are no more moves and 
                // no winner then it is a tie
                if (isMovesLeft(board) == false || depth == 2)
                    return 0;

                // If this maximizer's move
                if (isMax)
                {
                    int best = -1000;

                    // Traverse all cells
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            // Check if cell is empty
                            if (board[i * 3 + j] == "")
                            {
                                // Make the move
                                board[i * 3 + j] = opponent;

                                // Call minimax recursively and choose
                                // the maximum value
                                best = Math.Max(best, minimax(board,
                                                             depth + 1, !isMax));
                                //score = minimax(board, depth + 1, !isMax);

                                // Undo the move
                                board[i * 3 + j] = "";
                                //best = Math.Max(best, score);
                            }
                        }
                    }
                    return best;
                }

                // If this minimizer's move
                else
                {
                    int best = 1000;

                    // Traverse all cells
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            // Check if cell is empty
                            if (board[i * 3 + j] == "")
                            {
                                // Make the move
                                board[i * 3 + j] = player;

                                // Call minimax recursively and choose
                                // the minimum value
                                best = Math.Min(best, minimax(board,
                                                depth + 1, !isMax));

                                // Undo the move
                                board[i * 3 + j] = "";
                            }
                        }
                    }
                    return best;
                }
            }

            public Move findBestMove(string[] board)
            {
                int bestVal = -1000;
                Move bestMove = new Move();
                bestMove.row = -1;
                bestMove.col = -1;

                // Traverse all cells, evaluate minimax function 
                // for all empty cells. And return the cell 
                // with optimal value.
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty
                        if (board[i * 3 + j] == "")
                        {
                            // Make the move
                            board[i * 3 + j] = opponent;

                            // compute evaluation function for this
                            // move.
                            int moveVal = minimax(board, 0, false);

                            // Undo the move
                            board[i * 3 + j] = "";

                            // If the value of the current move is
                            // more than the best value, then update
                            // best/
                            if (moveVal > bestVal)
                            {
                                bestMove.row = i;
                                bestMove.col = j;
                                bestVal = moveVal;
                            }
                        }
                    }
                }

                return bestMove;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Button[] btnArr = new Button[] {button1,button2,button3,
                                            button4,button5,button6,
                                            button7,button8,button9};
            for (int i = 0; i < 9; i++)
            {
                btnArr[i].Text = "";
                btnArr[i].Enabled = true;
                labelScore.Text = "";
            }
        }

        public void disableAllButtons()
        {
            Button[] btnArr = new Button[] {button1,button2,button3,
                                            button4,button5,button6,
                                            button7,button8,button9};

            for(int i = 0;i < 9; i++)
            {
                btnArr[i].Enabled = false;
            }
        }

        public void enableAllButtons()
        {
            Button[] btnArr = new Button[] {button1,button2,button3,
                                            button4,button5,button6,
                                            button7,button8,button9};

            for (int i = 0; i < 9; i++)
            {
                btnArr[i].Enabled = true;
            }
        }

        private void boxNo_TextChanged(object sender, EventArgs e)
        {
            if (noBox.Text.Length != 8)
            {
                noBox.ForeColor = Color.Red;
                warnLabel.Text = "8 karakterden oluşmalıdır.";
                disableAllButtons();
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(noBox.Text, "[^0-9]"))
                {
                    disableAllButtons();
                    noBox.ForeColor = Color.Red;
                    warnLabel.Text = "Lütfen sadece rakam giriniz.";
                }
                else
                {
                    noBox.ForeColor = Color.Black;
                    warnLabel.Text = "";
                    enableAllButtons();
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Difficulty newForm = new Difficulty();
            newForm.Show();
            this.Close();
        }
    }


}
