using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }


       
 



    private void ChShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        { string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

  
            if (username == "admin") { }

            else
            {
                MessageBox.Show("enter the correct username");
            }
            if (password == "12345") { }

            else
            {
                MessageBox.Show("enter the correct password");
            }

        }
    }
}
