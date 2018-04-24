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
    }
}
