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
    public partial class Forgot_password : Form
    {
        public Forgot_password()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            login lf = new login();
            lf.Show();
            this.Hide();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register rf = new register();
            rf.Show();
            this.Hide();
        }
    }
}
