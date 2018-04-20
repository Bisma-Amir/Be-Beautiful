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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
        private static registration login_frm;
        public static registration getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new registration();
            }
            return login_frm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                    
        }
        
        
        private void cmdlogin_Click(object sender, EventArgs e)
        {

            frmlogin k3 = frmlogin.getinstance();
            this.Hide();
            k3.Show();
        }

        private void checkBox01_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
