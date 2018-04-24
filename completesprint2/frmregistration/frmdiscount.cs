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
    public partial class frmdiscount : Form
    {
        public frmdiscount()
        {
            InitializeComponent();
        }
        private static frmdiscount login_frm;
        public static frmdiscount getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmdiscount();
            }
            return login_frm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmddiscount_Click(object sender, EventArgs e)
        {
            if (int.Parse(textbill.Text) <= 3000)
            {
                MessageBox.Show("you can't get discount...");
            }
            else
            {
                if (int.Parse(textbill.Text) >= 3000)
                {
                    MessageBox.Show("you get discount of Rs.500...");
                    Server2.Service1 myserver = new Server2.Service1();
                    int discountrate;
                    bool billpassed = true;
                    bool id = true;
                    int bill = int.Parse(textbill.Text);
                    myserver.calculatediscount(bill, billpassed, out discountrate, out id);
                    textdiscount.Text = discountrate.ToString();

                }

            }
        }
}
