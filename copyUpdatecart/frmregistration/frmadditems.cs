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
    public partial class frmadditems : Form
    {
        public frmadditems()
        {
            InitializeComponent();
        }
        private static frmadditems login_frm;
        public static frmadditems getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmadditems();
            }
            return login_frm;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmexistingrecords k = new frmexistingrecords();
            k.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdadditem_Click(object sender, EventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1(); 
            myserver.Additems(txtitemname.Text, comboboxcategosry.Text, txtcompanyname.Text, txtprice.Text);
            MessageBox.Show("Product has been added");





        }

        private void lblpaymentrecords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paymentrecord k4 = paymentrecord.getinstance();
            this.Hide();
            k4.Show();
        }

        private void linklogout1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin l1 = frmlogin.getinstance();
            this.Hide();
            l1.Show();
        }

        private void linkHome1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frontpage l2 = frontpage.getinstance();
            this.Hide();
            l2.Show();
        }
    }
}
