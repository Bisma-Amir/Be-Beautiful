using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace bebeautiful
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        private static frmlogin login_frm;
        public static frmlogin getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmlogin();
            }
            return login_frm;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                        /*Myutil.Loginuser = dc;*/
                    }
                
        }
    }

