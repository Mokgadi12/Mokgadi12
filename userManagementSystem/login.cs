using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace userManagementSystem
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(" "); 
        public login()
        {
            InitializeComponent();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register rf = new register();
            rf.Show();
            this.Hide();
        }

        private void forgotpasswordBtn_Click(object sender, EventArgs e)
        {
            Forgot_password fpf = new Forgot_password();
            fpf.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (emailtxb.Text.Length > 0 && passwordtxb.Text.Length > 0)
            {
                try
                {
                    con.Open();
                   // SqlCommand com = new SqlCommand("INSERT INTO VALUES", con);
                   
                    con.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to connect to database.");
                }

            }
            else
                MessageBox.Show("All fields are required.");
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void passwordtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void forgotpasswordBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emailtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
