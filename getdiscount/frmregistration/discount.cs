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
    public partial class discount : Form
    {
        public discount()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmddiscount_Click(object sender, EventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            int discountrate;
            bool billpassed=true;
            bool id = true;
            int bill = int.Parse(textbill.Text);
            myserver.calculatediscount(bill,billpassed,out discountrate,out id); 
            textbill.Text = bill.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textdiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbill_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
