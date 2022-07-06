using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Hard : Form
    {
        Boolean logic = false;
        int n = 1;

        public Hard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome w1 = new welcome();
            w1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                if (logic == false)
                {
                    ((Button)sender).Text = "X";
                    ((Button)sender).BackColor = Color.LightCoral;
                    checkWinner();
                    logic = !logic;
                }
                if (logic == true)
                {
                    EnterCpu();
                    checkWinner();
                }
                logic = !logic;
            }
        }

        void EnterCpu()
        {
            //Winner
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "")
            {
                button3.Text = "O";
                button3.BackColor = Color.MediumSlateBlue;
            }
            else if (button1.Text == "O" && button3.Text == "O" && button2.Text == "")
            {
                button2.Text = "O";
                button2.BackColor = Color.MediumSlateBlue;
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "")
            {
                button7.Text = "O";
                button7.BackColor = Color.MediumSlateBlue;
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "")
            {
                button9.Text = "O";
                button9.BackColor = Color.MediumSlateBlue;
            }
            else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "")
            {
                button4.Text = "O";
                button4.BackColor = Color.MediumSlateBlue;
            }
            else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "")
            {
                button5.Text = "O";
                button5.BackColor = Color.MediumSlateBlue;
            }
            else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "")
            {
                button1.Text = "O";
                button1.BackColor = Color.MediumSlateBlue;
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "")
            {
                button8.Text = "O";
                button8.BackColor = Color.MediumSlateBlue;
            }
            else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "")
            {
                button5.Text = "O";
                button5.BackColor = Color.MediumSlateBlue;
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "")
            {
                button7.Text = "O";
                button7.BackColor = Color.MediumSlateBlue;
            }
            else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "")
            {
                button5.Text = "O";
                button5.BackColor = Color.MediumSlateBlue;
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "")
            {
                button9.Text = "O";
                button9.BackColor = Color.MediumSlateBlue;
            }
            else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "")
            {
                button6.Text = "O";
                button6.BackColor = Color.MediumSlateBlue;
            }
            else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "")
            {
                button1.Text = "O";
                button1.BackColor = Color.MediumSlateBlue;
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "")
            {
                button6.Text = "O";
                button6.BackColor = Color.MediumSlateBlue;
            }
            else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "")
            {
                button5.Text = "O";
                button5.BackColor = Color.MediumSlateBlue;
            }
            else if (button5.Text == "O" && button6.Text == "O" && button4.Text == "")
            {
                button4.Text = "O";
                button4.BackColor = Color.MediumSlateBlue;
            }
            else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "")
            {
                button3.Text = "O";
                button3.BackColor = Color.MediumSlateBlue;
            }
            else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "")
            {
                button2.Text = "O";
                button2.BackColor = Color.MediumSlateBlue;
            }
            else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "")
            {
                button1.Text = "O";
                button1.BackColor = Color.MediumSlateBlue;
            }
            else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "")
            {
                button3.Text = "O";
                button3.BackColor = Color.MediumSlateBlue;
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "")
            {
                button9.Text = "O";
                button9.BackColor = Color.MediumSlateBlue;
            }
            else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "")
            {
                button8.Text = "O";
                button8.BackColor = Color.MediumSlateBlue;
            }
            else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "")
            {
                button7.Text = "O";
                button7.BackColor = Color.MediumSlateBlue;
            }
            else
            {
                //Defense
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "")
                {
                    button3.Text = "O";
                    button3.BackColor = Color.MediumSlateBlue;
                }
                else if (button1.Text == "X" && button3.Text == "X" && button2.Text == "")
                {
                    button2.Text = "O";
                    button2.BackColor = Color.MediumSlateBlue;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "")
                {
                    button7.Text = "O";
                    button7.BackColor = Color.MediumSlateBlue;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "")
                {
                    button9.Text = "O";
                    button9.BackColor = Color.MediumSlateBlue;
                }
                else if (button1.Text == "X" && button7.Text == "X" && button4.Text == "")
                {
                    button4.Text = "O";
                    button4.BackColor = Color.MediumSlateBlue;
                }
                else if (button1.Text == "X" && button9.Text == "X" && button5.Text == "")
                {
                    button5.Text = "O";
                    button5.BackColor = Color.MediumSlateBlue;
                }
                else if (button2.Text == "X" && button3.Text == "X" && button1.Text == "")
                {
                    button1.Text = "O";
                    button1.BackColor = Color.MediumSlateBlue;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "")
                {
                    button8.Text = "O";
                    button8.BackColor = Color.MediumSlateBlue;
                }
                else if (button2.Text == "X" && button8.Text == "X" && button5.Text == "")
                {
                    button5.Text = "O";
                    button5.BackColor = Color.MediumSlateBlue;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "")
                {
                    button7.Text = "O";
                    button7.BackColor = Color.MediumSlateBlue;
                }
                else if (button3.Text == "X" && button7.Text == "X" && button5.Text == "")
                {
                    button5.Text = "O";
                    button5.BackColor = Color.MediumSlateBlue;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "")
                {
                    button9.Text = "O";
                    button9.BackColor = Color.MediumSlateBlue;
                }
                else if (button3.Text == "X" && button9.Text == "X" && button6.Text == "")
                {
                    button6.Text = "O";
                    button6.BackColor = Color.MediumSlateBlue;
                }
                else if (button4.Text == "X" && button7.Text == "X" && button1.Text == "")
                {
                    button1.Text = "O";
                    button1.BackColor = Color.MediumSlateBlue;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "")
                {
                    button6.Text = "O";
                    button6.BackColor = Color.MediumSlateBlue;
                }
                else if (button4.Text == "X" && button6.Text == "X" && button5.Text == "")
                {
                    button5.Text = "O";
                    button5.BackColor = Color.MediumSlateBlue;
                }
                else if (button5.Text == "X" && button6.Text == "X" && button4.Text == "")
                {
                    button4.Text = "O";
                    button4.BackColor = Color.MediumSlateBlue;
                }
                else if (button5.Text == "X" && button7.Text == "X" && button3.Text == "")
                {
                    button3.Text = "O";
                    button3.BackColor = Color.MediumSlateBlue;
                }
                else if (button5.Text == "X" && button8.Text == "X" && button2.Text == "")
                {
                    button2.Text = "O";
                    button2.BackColor = Color.MediumSlateBlue;
                }
                else if (button5.Text == "X" && button9.Text == "X" && button1.Text == "")
                {
                    button1.Text = "O";
                    button1.BackColor = Color.MediumSlateBlue;
                }
                else if (button6.Text == "X" && button9.Text == "X" && button3.Text == "")
                {
                    button3.Text = "O";
                    button3.BackColor = Color.MediumSlateBlue;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "")
                {
                    button9.Text = "O";
                    button9.BackColor = Color.MediumSlateBlue;
                }
                else if (button7.Text == "X" && button9.Text == "X" && button8.Text == "")
                {
                    button8.Text = "O";
                    button8.BackColor = Color.MediumSlateBlue;
                }
                else if (button8.Text == "X" && button9.Text == "X" && button7.Text == "")
                {
                    button7.Text = "O";
                    button7.BackColor = Color.MediumSlateBlue;
                    
                }
                else
                {
                    //Start
                    if (button1.Text == "" && n == 1)
                    {
                        n = 2;
                        button1.Text = "O";
                        button1.BackColor = Color.MediumSlateBlue;
                    }
                    else if (button2.Text == "" && (n == 1 || n == 2))
                    {
                        n = 3;
                        button2.Text = "O";
                        button2.BackColor = Color.MediumSlateBlue;
                    }
                    else if (button3.Text == "" && (n == 1 || n == 2 || n == 3))
                    {
                        n = 4;
                        button3.Text = "O";
                        button3.BackColor = Color.MediumSlateBlue;
                    }
                    else if (button4.Text == "" && (n == 1 || n == 2 || n == 3 || n == 4))
                    {
                        n = 5;
                        button4.Text = "O";
                        button4.BackColor = Color.MediumSlateBlue;
                    }
                    else if (button5.Text == "" && (n == 1 || n == 2 || n == 3 || n == 4 || n == 5))
                    {
                        n = 6;
                        button5.Text = "O";
                        button5.BackColor = Color.MediumSlateBlue;
                    }
                    else if (button6.Text == "" && (n == 1 || n == 2 || n == 3 || n == 4 || n == 5 || n == 6))
                    {
                        n = 7;
                        button6.Text = "O";
                        button6.BackColor = Color.MediumSlateBlue;
                    }
                    else if (button7.Text == "" && (n == 1 || n == 2 || n == 3 || n == 4 || n == 5 || n == 6 || n == 7))
                    {
                        n = 8;
                        button7.Text = "O";
                        button7.BackColor = Color.MediumSlateBlue;
                    }
                    else if (button8.Text == "" && (n == 1 || n == 2 || n == 3 || n == 4 || n == 5 || n == 6 || n == 7 || n == 8))
                    {
                        n = 9;
                        button8.Text = "O";
                        button8.BackColor = Color.MediumSlateBlue;
                    }
                    else if (button9.Text == "" && (n == 1 || n == 2 || n == 3 || n == 4 || n == 5 || n == 6 || n == 7 || n == 8 || n == 9))
                    {
                        n = 1;
                        button9.Text = "O";
                        button9.BackColor = Color.MediumSlateBlue;
                    }
                    else
                    {

                    }
                }
            }
        }

        void clearAll()
        {
            button1.Text = "";
            button1.BackColor = Color.LightGray;
            button2.Text = "";
            button2.BackColor = Color.LightGray;
            button3.Text = "";
            button3.BackColor = Color.LightGray;
            button4.Text = "";
            button4.BackColor = Color.LightGray;
            button5.Text = "";
            button5.BackColor = Color.LightGray;
            button6.Text = "";
            button6.BackColor = Color.LightGray;
            button7.Text = "";
            button7.BackColor = Color.LightGray;
            button8.Text = "";
            button8.BackColor = Color.LightGray;
            button9.Text = "";
            button9.BackColor = Color.LightGray;
        }

        void checkWinner()
        {
            String player, sym;

            if (logic == false)
            {
                player = "Player 1";
                sym = "X";
            }
            else
            {
                player = "CPU";
                sym = "O";
            }

            if (button1.Text == sym && button2.Text == sym && button3.Text == sym)
            {
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button4.Text == sym && button5.Text == sym && button6.Text == sym)
            {
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button7.Text == sym && button8.Text == sym && button9.Text == sym)
            {
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button1.Text == sym && button4.Text == sym && button7.Text == sym)
            {
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button2.Text == sym && button5.Text == sym && button8.Text == sym)
            {
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button3.Text == sym && button6.Text == sym && button9.Text == sym)
            {
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button1.Text == sym && button5.Text == sym && button9.Text == sym)
            {
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button3.Text == sym && button5.Text == sym && button7.Text == sym)
            {
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else
            {
                checkDraw();
            }
        }

        void checkDraw()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Game Draw !!!");
                clearAll();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void Hard_Load(object sender, EventArgs e)
        {

        }
    }
}
