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
            frmdiscount k4 = frmdiscount.getinstance();
            this.Hide();
            k4.Show();
        }
    }
}
