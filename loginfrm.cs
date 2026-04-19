using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoprojrect
{
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close?",
                "Confirm Close",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
            else return;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int counter = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "sta001" && txtPassword.Text == "givemethekeys123")
            {
                dashboard frm = new dashboard();
                frm.ShowDialog();

            }
            else if (txtUsername.Text == null)
            {
                MessageBox.Show("Please enter the Username");
            }
            else if (txtPassword.Text == null)
            {
                MessageBox.Show("Please enter the Password");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                counter++;
                if (counter == 5)
                {
                    MessageBox.Show("You have made 5 unsuccessfull attemps");
                    this.Close();
                }
            }
        }

            

                private void chkShowPassword_CheckStateChanged(object sender, EventArgs e)
                {
                    if (chkShowPassword.Checked == true)
                    {
                        txtPassword.UseSystemPasswordChar = false;
                    }
                    else
                    {
                        txtPassword.UseSystemPasswordChar = true;
                    }
                }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
