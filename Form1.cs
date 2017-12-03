using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DumyGame
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckForWinner();
        }
        #region CheckForWinner
        private void CheckForWinner()
        {
            bool ThereIsAWinner = false;
            String MessageText = null;
            //horizontal Checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                MessageText = "Horizontal";
                ThereIsAWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                MessageText = "Horizontal";
                ThereIsAWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                MessageText = "Horizontal";
                ThereIsAWinner = true;
            }

            //Vertical Checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                MessageText = "Vertical";
                ThereIsAWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                MessageText = "Vertical";
                ThereIsAWinner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                MessageText = "Vertical";
                ThereIsAWinner = true;
            }

             //Diagnol Checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                MessageText = "Diagnol";
                ThereIsAWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                MessageText = "Diagnol";
                ThereIsAWinner = true;
            }

            //Winner Check
            if (ThereIsAWinner)
            {
                DissableButtons();
                string Winner = "";
                if (turn)
                {
                    Winner = "O";
                }
                else
                {
                    Winner = "X";
                }//end if
               DialogResult DR= MessageBox.Show(Winner +" Player"+" Wins"+Environment.NewLine+" Do You want to play again ?", "Yahoo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Asterisk);
               if(DR==DialogResult.Yes)
               {
                   ResetGame();
               }
               else if (DR == DialogResult.No) 
               { 
                   Application.Exit(); 
               }
               else if (DR == DialogResult.Cancel)
               {
                   //No Action
               }
            }
            else
            {
                if (turn_count == 9)
                {
                    DialogResult DR = MessageBox.Show("Game Over"+Environment.NewLine+ turn_count +" turns is Over"+Environment.NewLine+" Try Again for press yes", "Game Over", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if (DR == DialogResult.Yes)
                    {
                        ResetGame();
                    }
                    else if (DR == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if (DR == DialogResult.Cancel)
                    {
                        //No Action
                    }
                }
            }
        }
        #endregion
        #region DissableButtons
        private void DissableButtons()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    Button b = (Button)c;
                    if(b!=null)
                    b.Enabled = false;
                }//end foreach loop
            }
            catch { }//try catch Block Becouse it is control to Controls
        }
        #endregion
        private void A2_Click(object sender, EventArgs e)
        {
            
        }
        #region ResetGame
        private void ResetGame()
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in this.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end foreach loop
            }
            catch { }//try catch block becouse it is control to controls
        }
        #endregion

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instructionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

       private void newGameToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instructionToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("xxxx" + Environment.NewLine + "", "Instructions Game", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void aboutUsToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("This game is developed by Shazia." + Environment.NewLine + "", "TICTAC Game", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Log = new LoginForm();
            Log.ShowDialog();
        }
    }
}