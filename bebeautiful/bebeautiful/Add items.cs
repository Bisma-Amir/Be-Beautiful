using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bebeautiful
{
    public partial class Add_items : Form
    {
        public Add_items()
        {
            InitializeComponent();
        }
        private static Add_items login_frm;
        public static Add_items getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new Add_items();
            }
            return login_frm;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
