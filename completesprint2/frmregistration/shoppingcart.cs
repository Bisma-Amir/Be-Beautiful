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
    public partial class shoppingcart : Form
    {
        public static List<Server2.Product> purchaseL;
        public shoppingcart()
        {
            InitializeComponent();
        }
        private static shoppingcart login_frm;
        public static shoppingcart getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new shoppingcart();
            }
            return login_frm;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmcustomerproduct k5 = frmcustomerproduct.getinstance();
            this.Hide();
            k5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmcustbill k6 = new frmcustbill();
            this.Hide();
            k6.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shoppingcart_Load(object sender, EventArgs e)
        {
            BindingSource s = new BindingSource();
            s.DataSource = purchaseL;
            dataGridView1.DataSource = s;
            
        }
    }
}
