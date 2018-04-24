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

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalid_admin;
            bool isvalid_adminpassed;
            bool isvalid_cust;
            bool isvalid_custpassed;
            bool isvalid_make;
            bool isvalid_makepassed;
            Server2.Service1 myserver = new Server2.Service1();
            if (checkBox03.Checked)
            {
                myserver.isvalidadmin(textBox06.Text, textBox07.Text, out isvalid_admin, out isvalid_adminpassed);
                if (isvalid_admin)
                {
                    MessageBox.Show("Login Successful!!!!");
                    frmadditems k3 = new frmadditems();
                    this.Hide();
                    k3.Show();


                }
            }
            else if (checkBox04.Checked)
            {
                myserver.isvalidcust(textBox06.Text, textBox07.Text, out isvalid_cust, out isvalid_custpassed);
                if (isvalid_cust)
                {
                    MessageBox.Show("login successful");
                   


                }
            }
            else if (checkBox05.Checked)
            {
                myserver.isvalidmake(textBox06.Text, textBox07.Text, out isvalid_make, out isvalid_makepassed);
                if (isvalid_make)
                {
                    MessageBox.Show("login successful");
                    


                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 k3 = Form1.getinstance();
            this.Hide();
            k3.Show();
        }
    }
}
