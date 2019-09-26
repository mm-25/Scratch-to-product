using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            c++;
            if (button1.Text == "")
            {

                if (label1.Text == "Player 1's Turn")
                {
                    button1.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button1.Text = "O";
                    label1.Text = "Player 1's Turn";

                }
            }
            else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if(c>=5 && c<8)
            {
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "X") || (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "X") || (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "O") || (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "O") || (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "O"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }else if (c>8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            c++;
            if (button2.Text == "")
            {
                if (label1.Text == "Player 1's Turn")
                {
                    button2.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button2.Text = "O";
                    label1.Text = "Player 1's Turn";
                }
            }else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if (c >= 5 && c <= 8)
            {
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "X") || (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "O") || (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "O"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }
            else if (c > 8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            c++;
            if (button3.Text == "")
            {
                if (label1.Text == "Player 1's Turn")
                {
                    button3.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button3.Text = "O";
                    label1.Text = "Player 1's Turn";
                }
            } else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if (c >= 5 && c <= 8)
            {
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "X") || (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "X") || (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "O") || (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "O") || (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text == "O"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }
            else if (c > 8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            c++;
            if (button6.Text == "")
            {
                if (label1.Text == "Player 1's Turn")
                {
                    button6.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button6.Text = "O";
                    label1.Text = "Player 1's Turn";
                }
            }
            else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if (c >= 5 && c <= 8)
            {
                if ((button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "X") || (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "O") || (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "O"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }
            else if (c > 8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            c++;
            if (button4.Text == "")
            {
                if (label1.Text == "Player 1's Turn")
                {
                    button4.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button4.Text = "O";
                    label1.Text = "Player 1's Turn";
                }
            }
            else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if (c >= 5 && c <= 8)
            {
                if ((button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "X") || (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "O") || (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "O"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }
            else if (c > 8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            c++;
            if (button5.Text == "")
            {
                if (label1.Text == "Player 1's Turn")
                {
                    button5.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button5.Text = "O";
                    label1.Text = "Player 1's Turn";
                }
            }
            else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if (c >= 5 && c <= 8)
            {
                if ((button3.Text == button5.Text && button5.Text == button7.Text && button7.Text == "X") || (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "X") || (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "X")|| (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button3.Text == button5.Text && button5.Text == button7.Text && button7.Text == "O") || (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "O") || (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "O") || (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "o"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }
            else if (c > 8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            c++;
            if (button7.Text == "")
            {
                if (label1.Text == "Player 1's Turn")
                {
                    button7.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button7.Text = "O";
                    label1.Text = "Player 1's Turn";
                }
            }
            else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if (c >= 5 && c <= 8)
            {
                if ((button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == "X") || (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "X") || (button7.Text == button5.Text && button5.Text == button3.Text && button3.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == "O") || (button7.Text == button4.Text && button4.Text == button1.Text && button1.Text == "O") || (button7.Text == button5.Text && button5.Text == button3.Text && button3.Text == "O"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }
            else if (c > 8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }

        }
        private void Button8_Click(object sender, EventArgs e)
            {
            c++;
            if (button8.Text == "")
            {
                if (label1.Text == "Player 1's Turn")
                {
                    button8.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button8.Text = "O";
                    label1.Text = "Player 1's Turn";
                }
            }
            else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if (c >= 5 && c <= 8)
            {
                if ((button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "X") || (button8.Text == button5.Text && button5.Text == button2.Text && button8.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "O") || (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "O"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }
            else if (c > 8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            c++;
            if (button9.Text == "")
            {
                if (label1.Text == "Player 1's Turn")
                {
                    button9.Text = "X";
                    label1.Text = "Player 2's Turn";

                }
                else
                {
                    button9.Text = "O";
                    label1.Text = "Player 1's Turn";
                }
            }
            else
            {
                MessageBox.Show("kahi aur try kar");
            }
            if (c >= 5 && c <= 8)
            {
                if ((button9.Text == button8.Text && button8.Text == button7.Text && button7.Text == "X") || (button9.Text == button5.Text && button5.Text == button9.Text && button9.Text == "X") || (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "X"))
                {
                    MessageBox.Show("Winner is player 1");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
                else if ((button9.Text == button8.Text && button8.Text == button7.Text && button7.Text == "O") || (button9.Text == button6.Text && button6.Text == button3.Text && button3.Text == "O") || (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "O"))
                {
                    MessageBox.Show("Winner is player 2");
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    c = 0;
                }
            }
            else if (c > 8)
            {
                MessageBox.Show("Draw");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                c = 0;
            }

        }
    }
    }

