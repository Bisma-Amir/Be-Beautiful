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
    public partial class frmcategory : Form
    {
        public frmcategory()
        {
            InitializeComponent();
        }
        private static frmcategory login_frm;
        public static frmcategory getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmcategory();
            }
            return login_frm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdadditem_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void comboboxcategosry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblcategory_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linklogout1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkHome1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblexistingrecords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtphonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
            frmlogin k3 = frmlogin.getinstance();
            this.Hide();
            k3.Show();
        }

        private void cmdregister_Click(object sender, EventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            if (txtpassword.Text == txtconfirmpassword.Text)
            {
                myserver.Addmakeupartist(txtusername.Text, txtpassword.Text, txtphonenumber.Text, txtaddress.Text,textBox1.Text,textBox2.Text);
                MessageBox.Show("Makeup Artist registered");
            }
            else
            {
                MessageBox.Show("passsword does not match");
            }
        }
    }
}
