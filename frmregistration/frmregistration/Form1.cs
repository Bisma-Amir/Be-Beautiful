using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmregistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {

        }

        private void cmdregister_Click(object sender, EventArgs e)
        {

            Server1.Service1 myserver = new Server1.Service1();
            if (admin.Checked)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    myserver.Addadmin(txtusername.Text, txtpassword.Text, txtphonenumber.Text, txtaddress.Text);
                    MessageBox.Show("Admin registered");
                }
                else
                {
                    MessageBox.Show("passsword does not match");
                }

            }
            else if (customer.Checked)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    myserver.Addcustomer(txtusername.Text, txtpassword.Text, txtphonenumber.Text, txtaddress.Text);
                    MessageBox.Show("Customer registered");
                }
                else
                {
                    MessageBox.Show("passsword does not match");
                }

            }
            else if (makeupArtist.Checked)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    myserver.Addmakeupartist(txtusername.Text, txtpassword.Text, txtphonenumber.Text, txtaddress.Text);
                    MessageBox.Show("Makeup Artist registered");
                }
                else
                {
                    MessageBox.Show("passsword does not match");
                }

            }
        }

        private void customer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void makeupArtist_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
