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

namespace frmregistration
{
    public partial class frmexistingrecords : Form
    {
        public frmexistingrecords()
        {
            InitializeComponent();
        }
        private static frmexistingrecords login_frm;
        public static frmexistingrecords getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmexistingrecords();
            }
            return login_frm;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            List<Server2.Product> list = myserver.get_products().ToList<Server2.Product>();
            
                BindingSource s = new BindingSource();
            s.DataSource = list;
                dataGridView1.DataSource = s;

            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmadditems m = frmadditems.getinstance();
            m.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmexistingrecords_Load(object sender, EventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            List<Server2.Product> list = myserver.get_products().ToList<Server2.Product>();
            
                BindingSource s = new BindingSource();
            s.DataSource = list;
                dataGridView1.DataSource = s;

           
        }
    }
}
