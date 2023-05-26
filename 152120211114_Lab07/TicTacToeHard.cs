using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _152120211114_Lab5;

namespace _152120211114_Lab07
{
    public partial class TicTacToeHard : Form
    {
        public TicTacToeHard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button[] btnArr = new Button[] {button1,button2,button3,button4,button5,
                                            button6,button7,button8,button9,button10,
                                            button11,button12,button13,button14,button15,
                                            button16,button17,button18,button19,button20,
                                            button21,button22,button23,button24,button25};

            //board with 1 dimensional indexing:
            string[] board = {button1.Text,button2.Text,button3.Text,button4.Text,button5.Text,
                              button6.Text,button7.Text,button8.Text,button9.Text,button10.Text,
                              button11.Text,button12.Text,button13.Text,button14.Text,button15.Text,
                              button16.Text,button17.Text,button18.Text,button19.Text,button20.Text,
                              button21.Text,button22.Text,button23.Text,button24.Text,button25.Text};

            Button button = (Button)sender;
            int index = Array.IndexOf(btnArr, button);

            if (board[index] == "") //if the button is not pressed
            {
                button.Text = "x"; //turn clicked button to x
                board[index] = "x";
                button.Enabled = false; //disable since it is clicked

                Game myGame = new Game();

                if (!myGame.isMovesLeft(board))
                //if no moves left, check if there's a winner
                {
                    int winner = myGame.evaluate(board);
                    if (winner < 0)
                    {
                        MessageBox.Show("You won!");
                        disableAllButtons();
                    }
                    else if (winner > 0)
                    {
                        MessageBox.Show("Computer won!");
                        disableAllButtons();
                    }
                    else
                    {
                        MessageBox.Show("It's a draw!");
                        disableAllButtons();
                    }
                }
                if (myGame.evaluate(board) < 0)
                {
                    MessageBox.Show("You won!");
                    disableAllButtons();
                }
                else if (myGame.evaluate(board) > 0)
                {
                    MessageBox.Show("Computer won!");
                    disableAllButtons();
                }
                else if (myGame.isMovesLeft(board))//if there are still moves left, let computer do it's move

                {
                    Game.Move pcMove = myGame.findBestMove(board);
                    btnArr[(pcMove.row * 5) + pcMove.col].Text = "o";
                    board[(pcMove.row * 5) + pcMove.col] = "o";
                    btnArr[(pcMove.row * 5) + pcMove.col].Enabled = false;

                    //check again if there are any moves left
                    if (myGame.evaluate(board) < 0)
                    {
                        MessageBox.Show("You won!");
                        disableAllButtons();
                    }
                    else if (myGame.evaluate(board) > 0)
                    {
                        MessageBox.Show("Computer won!");
                        disableAllButtons();
                    }
                    else if (!myGame.isMovesLeft(board))
                    //if no moves left, check if there's a winner

                    {
                        int winner = myGame.evaluate(board);
                        if (winner < 0)
                        {
                            MessageBox.Show("You won!");
                            disableAllButtons();
                        }
                        else if (winner > 0)
                        {
                            MessageBox.Show("Computer won!");
                            disableAllButtons();
                        }
                        else
                        {
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
                for (int i = 0; i < 25; i++)
                {
                    if (board[i] == "") { return true; }
                }
                return false;
            }

            //A function to check if the current board status has any winners
            public int evaluate(string[] board)
            {
                // check the rows for triple match
                for (int row = 0; row < 4; row++)
                {
                    if (
                         (
                          board[row * 5 + 0] == board[row * 5 + 1] &&
                          board[row * 5 + 1] == board[row * 5 + 2] &&
                          board[row * 5+ 0] != ""
                         )
                         ||
                         (
                          board[row * 5 + 1] == board[row * 5 + 2] &&
                          board[row * 5 + 2] == board[row * 5 + 3] &&
                          board[row * 5 + 1] != ""
                         )
                         ||
                         (
                          board[row * 5 + 2] == board[row * 5 + 3] &&
                          board[row * 5 + 3] == board[row * 5 + 4] &&
                          board[row * 5 + 2] != ""
                         )
                       )
                    {
                        if (
                            (
                             board[row * 5 + 0] == opponent &&
                             board[row * 5 + 1] == opponent &&
                             board[row * 5 + 2] == opponent
                            )
                            ||
                            (
                             board[row * 5 + 1] == opponent &&
                             board[row * 5 + 2] == opponent &&
                             board[row * 5 + 3] == opponent
                            )
                            ||
                            (
                             board[row * 5 + 2] == opponent &&
                             board[row * 5 + 3] == opponent &&
                             board[row * 5 + 4] == opponent
                            )
                           )
                            return +10;
                        else if (
                                 (
                                  board[row * 5 + 0] == player &&
                                  board[row * 5 + 1] == player &&
                                  board[row * 5 + 2] == player
                                 )
                                 ||
                                 (
                                  board[row * 5 + 1] == player &&
                                  board[row * 5 + 2] == player &&
                                  board[row * 5 + 3] == player
                                 )
                                 ||
                                 (
                                  board[row * 5 + 2] == player &&
                                  board[row * 5 + 3] == player &&
                                  board[row * 5 + 4] == player
                                 )
                                )
                            return -10;
                    }
                }

                // check the columns for triple match
                for (int col = 0; col < 4; col++)
                {
                    if (
                        (
                         board[0 * 5 + col] == board[1 * 5 + col] &&
                         board[1 * 5 + col] == board[2 * 5 + col] &&
                         board[0 * 5 + col] != ""
                        )
                        ||
                        (
                         board[1 * 5 + col] == board[2 * 5 + col] &&
                         board[2 * 5 + col] == board[3 * 5 + col] &&
                         board[0 * 5 + col] != ""
                        )
                        ||
                        (
                         board[2 * 5 + col] == board[3 * 5 + col] &&
                         board[3 * 5 + col] == board[4 * 5 + col] &&
                         board[2 * 5 + col] != ""
                        )
                       )
                    {
                        if (
                            (
                             board[0 * 5 + col] == opponent &&
                             board[1 * 5 + col] == opponent &&
                             board[2 * 5 + col] == opponent
                            )
                            ||
                            (
                             board[1 * 5 + col] == opponent &&
                             board[2 * 5 + col] == opponent &&
                             board[3 * 5 + col] == opponent
                            )
                            ||
                            (
                             board[2 * 5 + col] == opponent &&
                             board[3 * 5 + col] == opponent &&
                             board[4 * 5 + col] == opponent
                            )
                           )
                            return +10;

                        else if (
                            (
                             board[0 * 5 + col] == player &&
                             board[1 * 5 + col] == player &&
                             board[2 * 5 + col] == player
                            )
                            ||
                            (
                             board[1 * 5 + col] == player &&
                             board[2 * 5 + col] == player &&
                             board[3 * 5 + col] == player
                            )
                            ||
                            (
                             board[2 * 5 + col] == player &&
                             board[3 * 5 + col] == player &&
                             board[4 * 5 + col] == player
                            )
                           )
                            return -10;
                    }
                }

                // check first diagonal (\) for triple match
                if (
                    (
                     board[0 * 5 + 0] == board[1 * 5 + 1] &&
                     board[1 * 5 + 1] == board[2 * 5 + 2] &&
                     board[0 * 5 + 0] != ""
                    )
                    ||
                    (
                     board[1 * 5 + 1] == board[2 * 5 + 2] &&
                     board[2 * 5 + 2] == board[3 * 5 + 3] &&
                     board[1 * 5 + 1] != ""
                    )
                    ||
                    (
                     board[2 * 5 + 2] == board[3 * 5 + 3] &&
                     board[3 * 5 + 3] == board[4 * 5 + 4] &&
                     board[2 * 5 + 2] != ""
                    )
                    ||
                    (
                     board[0 * 5 + 1] == board[1 * 5 + 2] &&
                     board[1 * 5 + 2] == board[2 * 5 + 3] &&
                     board[0 * 5 + 1] != ""
                    )
                    ||
                    (
                     board[2 * 5 + 2] == board[2 * 5 + 3] &&
                     board[2 * 5 + 3] == board[3 * 5 + 4] &&
                     board[2 * 5 + 2] != ""
                    )
                    ||
                    (
                     board[1 * 5 + 0] == board[2 * 5 + 1] &&
                     board[2 * 5 + 1] == board[3 * 5 + 2] &&
                     board[1 * 5 + 0] != ""
                    )
                    ||
                    (
                     board[2 * 5 + 1] == board[3 * 5 + 2] &&
                     board[3 * 5 + 2] == board[4 * 5 + 3] &&
                     board[2 * 5 + 1] != ""
                    )
                    ||
                    (
                     board[0 * 5 + 2] == board[1 * 5 + 3] &&
                     board[1 * 5 + 3] == board[2 * 5 + 4] &&
                     board[0 * 5 + 2] != ""
                    )
                    ||
                    (
                     board[2 * 5 + 0] == board[3 * 5 + 1] &&
                     board[3 * 5 + 1] == board[4 * 5 + 2] &&
                     board[2 * 5 + 0] != ""
                    )
                   )
                {
                    if (
                        (
                         board[0 * 5 + 0] == opponent &&
                         board[1 * 5 + 1] == opponent &&
                         board[2 * 5 + 2] == opponent
                        )
                        ||
                        (
                         board[1 * 5 + 1] == opponent &&
                         board[2 * 5 + 2] == opponent &&
                         board[3 * 5 + 3] == opponent
                        )
                        ||
                        (
                         board[2 * 5 + 2] == opponent &&
                         board[3 * 5 + 3] == opponent &&
                         board[4 * 5 + 4] == opponent
                        )
                        ||
                        (
                         board[0 * 5 + 1] == opponent &&
                         board[1 * 5 + 2] == opponent &&
                         board[2 * 5 + 3] == opponent
                        )
                        ||
                        (
                         board[1 * 5 + 2] == opponent &&
                         board[2 * 5 + 3] == opponent &&
                         board[3 * 5 + 4] == opponent
                        )
                        ||
                        (
                         board[2 * 5 + 1] == opponent &&
                         board[3 * 5 + 2] == opponent &&
                         board[4 * 5 + 3] == opponent
                        )
                        ||
                        (
                         board[0 * 5 + 2] == opponent &&
                         board[1 * 5 + 3] == opponent &&
                         board[2 * 5 + 4] == opponent
                        )
                        ||
                        (
                         board[2 * 5 + 0] == opponent &&
                         board[3 * 5 + 1] == opponent &&
                         board[4 * 5 + 2] == opponent
                        )
                       )
                        return +10;
                    else if (
                             (
                              board[0 * 5 + 0] == player &&
                              board[1 * 5 + 1] == player &&
                              board[2 * 5 + 2] == player
                             )
                             ||
                             (
                              board[1 * 5 + 1] == player &&
                              board[2 * 5 + 2] == player &&
                              board[3 * 5 + 3] == player
                             )
                             ||
                             (
                              board[2 * 5 + 2] == player &&
                              board[3 * 5 + 3] == player &&
                              board[4 * 5 + 4] == player
                             )
                             ||
                             (
                              board[0 * 5 + 1] == player &&
                              board[1 * 5 + 2] == player &&
                              board[2 * 5 + 3] == player
                             )
                             ||
                             (
                              board[1 * 5 + 2] == player &&
                              board[2 * 5 + 3] == player &&
                              board[3 * 5 + 4] == player
                             )
                             ||
                             (
                              board[2 * 5 + 1] == player &&
                              board[3 * 5 + 2] == player &&
                              board[4 * 5 + 3] == player
                             )
                             ||
                             (
                              board[0 * 5 + 2] == player &&
                              board[1 * 5 + 3] == player &&
                              board[2 * 5 + 4] == player
                             )
                             ||
                             (
                              board[2 * 5 + 0] == player &&
                              board[3 * 5 + 1] == player &&
                              board[4 * 5 + 2] == player
                             )
                            )
                        return -10;
                }

                // check second diagonal (/) for triple match
                if (
                    (
                     board[0 * 5 + 2] == board[1 * 5 + 1] &&
                     board[1 * 5 + 1] == board[2 * 5 + 0] &&
                     board[0 * 5 + 2] != ""
                    )
                    ||
                    (
                     board[0 * 5 + 3] == board[1 * 5 + 2] &&
                     board[1 * 5 + 2] == board[2 * 5 + 1] &&
                     board[0 * 5 + 3] != ""
                    )
                    ||
                    (
                     board[1 * 5 + 2] == board[2 * 5 + 1] &&
                     board[2 * 5 + 1] == board[3 * 5 + 0] &&
                     board[1 * 5 + 2] != ""
                    )
                    ||
                    (
                     board[0 * 5 + 4] == board[1 * 5 + 3] &&
                     board[1 * 5 + 3] == board[2 * 5 + 2] &&
                     board[0 * 5 + 4] != ""
                    )
                    ||
                    (
                     board[1 * 5 + 3] == board[2 * 5 + 2] &&
                     board[2 * 5 + 2] == board[3 * 5 + 1] &&
                     board[1 * 5 + 3] != ""
                    )
                    ||
                    (
                     board[2 * 5 + 2] == board[3 * 5 + 1] &&
                     board[3 * 5 + 1] == board[4 * 5 + 0] &&
                     board[2 * 5 + 2] != ""
                    )
                    ||
                    (
                     board[1 * 5 + 4] == board[2 * 5 + 3] &&
                     board[2 * 5 + 3] == board[3 * 5 + 2] &&
                     board[1 * 5 + 4] != ""
                    )
                    ||
                    (
                     board[2 * 5 + 3] == board[3 * 5 + 2] &&
                     board[3 * 5 + 2] == board[4 * 5 + 1] &&
                     board[2 * 5 + 3] != ""
                    )
                    ||
                    (
                     board[2 * 5 + 4] == board[3 * 5 + 3] &&
                     board[3 * 5 + 3] == board[4 * 5 + 2] &&
                     board[2 * 5 + 4] != ""
                    )
                   )
                {
                    if (
                        (
                         board[0 * 5 + 2] == opponent &&
                         board[1 * 5 + 1] == opponent &&
                         board[2 * 5 + 0] == opponent
                        )
                        ||
                        (
                         board[0 * 5 + 3] == opponent &&
                         board[1 * 5 + 2] == opponent &&
                         board[2 * 5 + 1] == opponent
                        )
                        ||
                        (
                         board[1 * 5 + 2] == opponent &&
                         board[2 * 5 + 1] == opponent &&
                         board[3 * 5 + 0] == opponent
                        )
                        ||
                        (
                         board[0 * 5 + 4] == opponent &&
                         board[1 * 5 + 3] == opponent &&
                         board[2 * 5 + 2] == opponent
                        )
                        ||
                        (
                         board[1 * 5 + 3] == opponent &&
                         board[2 * 5 + 2] == opponent &&
                         board[3 * 5 + 1] == opponent
                        )
                        ||
                        (
                         board[2 * 5 + 2] == opponent &&
                         board[3 * 5 + 1] == opponent &&
                         board[4 * 5 + 0] == opponent
                        )
                        ||
                        (
                         board[1 * 5 + 4] == opponent &&
                         board[2 * 5 + 3] == opponent &&
                         board[3 * 5 + 2] == opponent
                        )
                        ||
                        (
                         board[2 * 5 + 3] == opponent &&
                         board[3 * 5 + 2] == opponent &&
                         board[4 * 5 + 1] == opponent
                        )
                        ||
                        (
                         board[2 * 5 + 4] == opponent &&
                         board[3 * 5 + 3] == opponent &&
                         board[4 * 5 + 2] == opponent
                        )
                       )
                        return +10;
                    else if (
                             (
                              board[0 * 5 + 2] == player &&
                              board[1 * 5 + 1] == player &&
                              board[2 * 5 + 0] == player
                             )
                             ||
                             (
                              board[0 * 5 + 3] == player &&
                              board[1 * 5 + 2] == player &&
                              board[2 * 5 + 1] == player
                             )
                             ||
                             (
                              board[1 * 5 + 2] == player &&
                              board[2 * 5 + 1] == player &&
                              board[3 * 5 + 0] == player
                             )
                             ||
                             (
                              board[0 * 5 + 4] == player &&
                              board[1 * 5 + 3] == player &&
                              board[2 * 5 + 2] == player
                             )
                             ||
                             (
                              board[1 * 5 + 3] == player &&
                              board[2 * 5 + 2] == player &&
                              board[3 * 5 + 1] == player
                             )
                             ||
                             (
                              board[2 * 5 + 2] == player &&
                              board[3 * 5 + 1] == player &&
                              board[4 * 5 + 0] == player
                             )
                             ||
                             (
                              board[1 * 5 + 4] == player &&
                              board[2 * 5 + 3] == player &&
                              board[3 * 5 + 2] == player
                             )
                             ||
                             (
                              board[2 * 5 + 3] == player &&
                              board[3 * 5 + 2] == player &&
                              board[4 * 5 + 1] == player
                             )
                             ||
                             (
                              board[2 * 5 + 4] == player &&
                              board[3 * 5 + 3] == player &&
                              board[4 * 5 + 2] == player
                             )
                            )
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
                if (isMovesLeft(board) == false || depth == 4)
                    return 0;

                // If this maximizer's move
                if (isMax)
                {
                    int best = -1000;

                    // Traverse all cells
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            // Check if cell is empty
                            if (board[i * 5 + j] == "")
                            {
                                // Make the move
                                board[i * 5 + j] = opponent;

                                // Call minimax recursively and choose
                                // the maximum value
                                best = Math.Max(best, minimax(board,
                                                             depth + 1, !isMax));
                                //score = minimax(board, depth + 1, !isMax);

                                // Undo the move
                                board[i * 5 + j] = "";
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
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            // Check if cell is empty
                            if (board[i * 5 + j] == "")
                            {
                                // Make the move
                                board[i * 5 + j] = player;

                                // Call minimax recursively and choose
                                // the minimum value
                                best = Math.Min(best, minimax(board,
                                                depth + 1, !isMax));

                                // Undo the move
                                board[i * 5 + j] = "";
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
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        // Check if cell is empty
                        if (board[i * 5 + j] == "")
                        {
                            // Make the move
                            board[i * 5 + j] = opponent;

                            // compute evaluation function for this
                            // move.
                            int moveVal = minimax(board, 0, false);

                            // Undo the move
                            board[i * 5 + j] = "";

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
            Button[] btnArr = new Button[] {button1,button2,button3,button4,button5,
                                            button6,button7,button8,button9,button10,
                                            button11,button12,button13,button14,button15,
                                            button16,button17,button18,button19,button20,
                                            button21,button22,button23,button24,button25};
            for (int i = 0; i < 25; i++)
            {
                btnArr[i].Text = "";
                btnArr[i].Enabled = true;
                labelScore.Text = "";
            }
        }

        public void disableAllButtons()
        {
            Button[] btnArr = new Button[] {button1,button2,button3,button4,button5,
                                            button6,button7,button8,button9,button10,
                                            button11,button12,button13,button14,button15,
                                            button16,button17,button18,button19,button20,
                                            button21,button22,button23,button24,button25};

            for (int i = 0; i < 25; i++)
            {
                btnArr[i].Enabled = false;
            }
        }

        public void enableAllButtons()
        {
            Button[] btnArr = new Button[] {button1,button2,button3,button4,button5,
                                            button6,button7,button8,button9,button10,
                                            button11,button12,button13,button14,button15,
                                            button16,button17,button18,button19,button20,
                                            button21,button22,button23,button24,button25};

            for (int i = 0; i < 25; i++)
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
            Difficulty   newForm = new Difficulty();
            newForm.Show();
            this.Close();
        }
    }
}
