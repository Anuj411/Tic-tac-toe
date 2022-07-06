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
    
    public partial class Form1 : Form
    {
        Boolean logic;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTip.Text = "Player 1 starts the game.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                if (logic == false)
                {
                    ((Button)sender).Text = "X";
                    ((Button)sender).BackColor = Color.LightCoral;
                    lblTip.Text = "Player 2 turn...";
                }
                else
                {
                    ((Button)sender).Text = "O";
                    ((Button)sender).BackColor = Color.MediumSlateBlue;
                    lblTip.Text = "Player 1 turn...";
                }

                checkWinner();
                logic = !logic;
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

            if (logic == false)
                lblTip.Text = "Player 1 starts the game.";
            else
                lblTip.Text = "Player 2 starts the game.";

            logic = !logic;
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
                player = "Player 2";
                sym = "O";
            }

            if (button1.Text == sym && button2.Text == sym && button3.Text == sym)
            {
                lblTip.Text = "";
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button4.Text == sym && button5.Text == sym && button6.Text == sym)
            {
                lblTip.Text = "";
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button7.Text == sym && button8.Text == sym && button9.Text == sym)
            {
                lblTip.Text = "";
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button1.Text == sym && button4.Text == sym && button7.Text == sym)
            {
                lblTip.Text = "";
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button2.Text == sym && button5.Text == sym && button8.Text == sym)
            {
                lblTip.Text = "";
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button3.Text == sym && button6.Text == sym && button9.Text == sym)
            {
                lblTip.Text = "";
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button1.Text == sym && button5.Text == sym && button9.Text == sym)
            {
                lblTip.Text = "";
                MessageBox.Show(player + " Winner !!!");
                clearAll();
            }
            else if (button3.Text == sym && button5.Text == sym && button7.Text == sym)
            {
                lblTip.Text = "";
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
                clearAll();
                MessageBox.Show("Game Draw !!!");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            welcome wlcm = new welcome();
            wlcm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
