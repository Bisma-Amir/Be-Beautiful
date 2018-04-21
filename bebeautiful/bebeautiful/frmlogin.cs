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
            if (checkBox03.Checked)
            {
                Admin a = new Admin();
                if (textBox06.Text == a.Adminname && textBox07.Text == a.Adminpassword)
                {
                    MessageBox.Show("Login Successful!!!!");
                    Add_items k4 = Add_items.getinstance();
                    this.Hide();
                    k4.Show();
                }
             }
            else if(checkBox04.Checked)
            {
                Boolean isfound = false;
                foreach (Customer dc in CustomerDL.Customers)

                {
                    if (dc.Custname == textBox06.Text && dc.Custpassword == textBox07.Text)
                    {
                        isfound = true;
                        /*Myutil.Loginuser = dc;*/
                    }
                }
                if (isfound)
                {
                    MessageBox.Show("login successful");

                }
            }
            else
                MessageBox.Show("Login UNSuccessful!!!!");
        }
    }
}
