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
    public partial class frmoption : Form
    {
        public frmoption()
        {
            InitializeComponent();
        }
        private static frmoption login_frm;
        public static frmoption getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmoption();
            }
            return login_frm;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmartist k3 = frmartist.getinstance();
            this.Hide();
            k3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmcustomerproduct k4 = frmcustomerproduct.getinstance();
            this.Hide();
            k4.Show();
        }
    }
}
