using System.Collections.Generic;
using System.Drawing.Printing;
using testScript;

namespace _152120191021_Recep_Kırtay_Lab4
{
    public partial class Form1 : Form
    {

        char[,] board = new char[3, 3];
        char humanSymbol = 'x';
        char computerSymbol = 'o';

        public Form1()
        {
            InitializeComponent();
            initializeBoard();
        }

        private void initializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            display();
        }

        private void display()
        {
            button1.Text = board[0, 0].ToString();
            button2.Text = board[0, 1].ToString();
            button3.Text = board[0, 2].ToString();
            button4.Text = board[1, 0].ToString();
            button5.Text = board[1, 1].ToString();
            button6.Text = board[1, 2].ToString();
            button7.Text = board[2, 0].ToString();
            button8.Text = board[2, 1].ToString();
            button9.Text = board[2, 2].ToString();
        }

        private bool isGameOver()
        {
            if (isWin(humanSymbol) || isWin(computerSymbol) || getEmptyCells().Length == 0)
            {
                return true;
            }
            return false;
        }

        private bool isWin(char symbol)
        {
            if (board[0, 0] == symbol && board[0, 1] == symbol && board[0, 2] == symbol ||
                board[1, 0] == symbol && board[1, 1] == symbol && board[1, 2] == symbol ||
                board[2, 0] == symbol && board[2, 1] == symbol && board[2, 2] == symbol ||
                board[0, 0] == symbol && board[1, 0] == symbol && board[2, 0] == symbol ||
                board[0, 1] == symbol && board[1, 1] == symbol && board[2, 1] == symbol ||
                board[0, 2] == symbol && board[1, 2] == symbol && board[2, 2] == symbol ||
                board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol ||
                board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
            {
                return true;
            }
            return false;
        }

        private int evaluate()
        {
            if (isWin(computerSymbol))
            {
                return 10;
            }
            else if (isWin(humanSymbol))
            {
                return -10;
            }
            else
            {
                return 0;
            }
        }

        private int minimax(int depth, bool isMaximizer)
        {
            int score = evaluate();
            if (score == 10 || score == -10)
            {
                return score;
            }
            if (getEmptyCells().Length == 0)
            {
                return 0;
            }
            if (isMaximizer)
            {
                int maxScore = int.MinValue;
                foreach (int cell in getEmptyCells())
                {
                    board[cell / 3, cell % 3] = computerSymbol;
                    maxScore = Math.Max(maxScore, minimax(depth + 1, false));
                    board[cell / 3, cell % 3] = ' ';
                }
                return maxScore;
            }
            else
            {
                int minScore = int.MaxValue;
                foreach (int cell in getEmptyCells())
                {
                    board[cell / 3, cell % 3] = humanSymbol;
                    minScore = Math.Min(minScore, minimax(depth + 1, true));
                    board[cell / 3, cell % 3] = ' ';
                }
                return minScore;
            }
        }

        private int[] getEmptyCells()
        {
            List<int> emptyCells = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        emptyCells.Add(i * 3 + j);
                    }
                }
            }
            return emptyCells.ToArray();
        }

        private void whichPlayed(int x, int y)
        {
            x *= 10;
            x += y;
            if (x == 00)
                button1.Enabled = false;
            else if (x == 01)
                button2.Enabled = false;
            else if (x == 02)
                button3.Enabled = false;
            else if (x == 10)
                button4.Enabled = false;
            else if (x == 11)
                button5.Enabled = false;
            else if (x == 12)
                button6.Enabled = false;
            else if (x == 20)
                button7.Enabled = false;
            else if (x == 21)
                button8.Enabled = false;
            else if (x == 22)
                button9.Enabled = false;
        }

        private void makeComputerMove()
        {
            int bestScore = int.MinValue;
            int bestCell = -1;
            foreach (int cell in getEmptyCells())
            {
                board[cell / 3, cell % 3] = computerSymbol;
                int score = minimax(0, false);
                board[cell / 3, cell % 3] = ' ';
                if (score > bestScore)
                {
                    bestScore = score;
                    bestCell = cell;
                }
            }
            board[bestCell / 3, bestCell % 3] = computerSymbol;
            whichPlayed(bestCell / 3, bestCell % 3);
        }

        private void declareWinner()
        {
            testClass testClass = new testClass();
            if (isWin(humanSymbol))
            {
                MessageBox.Show("You Win !");
                label2.Text = "Score : ";
                label2.Text += testClass.testFuncXoX(textBox1.Text, "x", button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
                initializeBoard();
                display();

            }
            else if (isWin(computerSymbol))
            {
                MessageBox.Show("Computer Wins!");
                label2.Text = "Score : ";
                label2.Text += testClass.testFuncXoX(textBox1.Text, "o", button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
                initializeBoard();
                display();
            }
            else
            {
                MessageBox.Show("Draw!");
                label2.Text = "Score : ";
                label2.Text += testClass.testFuncXoX(textBox1.Text, "draw", button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
                initializeBoard();
                display();
            }
        }

        private void Click(object sender, EventArgs e)
        {
            display();
            Button button = (Button)sender;
            int koordinat = int.Parse(button.Tag.ToString());

            int col = (koordinat % 10);
            int row = (koordinat /= 10);

            board[row, col] = humanSymbol;
            display();
            button.Enabled = false;
            if (isGameOver())
                declareWinner();
            makeComputerMove();
            display();
            if (isGameOver())
                declareWinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            initializeBoard();
            display();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}