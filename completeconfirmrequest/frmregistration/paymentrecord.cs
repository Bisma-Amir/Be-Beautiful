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
    public partial class paymentrecord : Form
    {
        public paymentrecord()
        {
            InitializeComponent();
        }
        private static paymentrecord login_frm;
        public static paymentrecord getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new paymentrecord();
            }
            return login_frm;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void paymentrecord_Load(object sender, EventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            List<Server2.Product> list = myserver.get_products().ToList<Server2.Product>();
            BindingSource S = new BindingSource();
            S.DataSource = list;
            dataGridView1.DataSource = S;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Product";
            dataGridView1.Columns[1].Name = "Category";
            dataGridView1.Columns[2].Name = "Quantity";
            dataGridView1.Columns[3].Name = "Price";

            ArrayList m = new ArrayList();
            m.Add("lip stick");
            m.Add("Lip stick and glose");
            m.Add("3");
            m.Add("1000");
            m.Add("lip stick");
            m.Add("Lip stick and glose");
            m.Add("3");
            m.Add("1000");





        }

        private void linklogout3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin l1 = frmlogin.getinstance();
            this.Hide();
            l1.Show();
        }

        private void linkHome3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frontpage l2 = frontpage.getinstance();
            this.Hide();
            l2.Show();
        }

        private void linkLabel09_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();

            BindingSource s = new BindingSource();
            s.DataSource = frmcustbill.Billes;
            dataGridView1.DataSource = s;
        }
    }
}
