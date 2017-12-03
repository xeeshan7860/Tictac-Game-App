using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumyGame
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp S = new SignUp();
            S.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp S = new SignUp();
            if (S.Username != "") 
            {
                if (textBox1.Text == S.Username && textBox2.Text == S.Password)
                {
                    MessageBox.Show("Welcome to the tictac game", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your username & password is invalid","Incorrect!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.TabIndex = 0;
                }
            }
            else
            {
                if (textBox1.Text == "tictac" && textBox2.Text == "tictac")
                {
                    MessageBox.Show("Welcome to the tictac game", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
