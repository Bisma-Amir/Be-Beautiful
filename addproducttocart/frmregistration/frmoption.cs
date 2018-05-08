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

        private void frmoption_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmartist k3 = new frmartist();
            this.Hide();
            k3.Show();
        }
    }
}
