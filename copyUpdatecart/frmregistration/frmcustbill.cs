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
    public partial class frmcustbill : Form
    {
        public frmcustbill()
        {
            InitializeComponent();
        }
        private static frmcustbill login_frm;
        public static frmcustbill getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmcustbill();
            }
            return login_frm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linklogout6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin l1 = frmlogin.getinstance();
            this.Hide();
            l1.Show();
        }

        private void linkHome6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frontpage l2 = frontpage.getinstance();
            this.Hide();
            l2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmdiscount k4 = frmdiscount.getinstance();
            this.Hide();
            k4.Show();
        }
    }
}
