using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cek_login(object sender, EventArgs e)
        {
            try
            {
                string connectionSQL = "server=localhost;database=bmkg;uid=root;password=;";
                MySqlConnection myConn = new MySqlConnection(connectionSQL);

                MySqlCommand SelectCommand = new MySqlCommand("select * from bmkg.user_ms where username='" + this.username_txt.Text + "' and pass='" + this.password_txt.Text + "' ", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and Password Correct");
                    this.Hide();
                    Form frm2 = new adminpage(username_txt.Text);
                    frm2.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and User, access denied");
                }
                else
                    MessageBox.Show("Username and Password is incorrect, try again");
                myConn.Close();
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            /*{
                if ((username_txt.Text.Equals("putri")) && (password_txt.Text.Equals("password")))
                {
                    MessageBox.Show("You are now Logged in");
                    this.Hide();
                    Form frm2 = new BMKG();
                    frm2.Show();

                }
                else if ((username_txt.Text.Equals("putri")) && (password_txt.Text != "password"))
                {
                    MessageBox.Show("You have entered the wrong password! Try again");
                    password_txt.Clear();
                    password_txt.Focus();
                }
                else if ((username_txt.Text != "putri") && (password_txt.Text.Equals("password")))
                {
                    MessageBox.Show("You have entered the wrong username! Try again");
                    username_txt.Clear();
                    username_txt.Focus();
                }
                else
                {
                    MessageBox.Show("You have entered the wrong username and password! Try again");
                    username_txt.Clear();
                    password_txt.Clear();
                }
            }*/
        }

        private void login_Load(object sender, EventArgs e)
        {
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

      
    }
}
