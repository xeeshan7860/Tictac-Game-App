using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//olebd Access connection
using System.Data.OleDb;

namespace DumyGame
{
    public partial class SignUp : Form
    {
        ConnectionClass conn = new ConnectionClass();
        public string Username ="";
        public string Password = "";
        public string Name = "";
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

         
        private void button1_Click(object sender, EventArgs e)
        {
            conn.connect.Open();
            //OleDbCommand cmd = new OleDbCommand("insert into [tictactbl] (username,password,playername) values (@username,@password,@playername)",conn.connect);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" & textBox4.Text != "")
            {
               // LoginForm F = new LoginForm();
               // cmd.Parameters.AddWithValue("@username", textBox1.Text);
                if (textBox2.Text == textBox3.Text)
                {
                    //cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    //cmd.Parameters.AddWithValue("@playername", textBox4.Text);
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up Successfully", "Execution", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    MessageBox.Show("Password does not match", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter text empty fields", "Alert!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.connect.Close();
        }
    }
}
