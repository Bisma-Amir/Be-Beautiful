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
       
        public shoppingcart()
        {
            InitializeComponent();
        }
        static DataGridViewCheckBoxColumn n = new DataGridViewCheckBoxColumn();
        public static List<Server2.Product> confirmproduct;
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
            frmdiscount k6 = new frmdiscount();
            this.Hide();
            k6.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //BindingSource s = new BindingSource();
            //s.DataSource = frmcustomerproduct.purchaseL;
            //dataGridView03.DataSource = s;


        }

        private void shoppingcart_Load(object sender, EventArgs e)
        {
           
            
        }

        private void linkLabel09_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGridViewCheckBoxColumn n = new DataGridViewCheckBoxColumn();
            n.ValueType = typeof(bool);
            n.Name = "Chk";
            n.HeaderText="CheckBox";

            BindingSource s = new BindingSource();
            s.DataSource = frmcustomerproduct.purchaseL;
            dataGridView03.DataSource = s;
            dataGridView03.Columns.Add(n);

        }
         private void linklogout5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin l1 = frmlogin.getinstance();
            this.Hide();
            l1.Show();
        }

        private void linkHome5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frontpage l2 = frontpage.getinstance();
            this.Hide();
            l2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            //c.ValueType = typeof(bool);
            //c.Name = "Chk";
            //c.HeaderText = "CheckBox";
            int i = 0;
            Server2.Service1 myserver = new Server2.Service1();

            foreach (DataGridViewRow row in dataGridView03.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                {
                    myserver.deleteproduct(row.Cells[0].ToString(), row.Cells[1].ToString(), row.Cells[2].ToString(), row.Cells[3].ToString());

                  

                }
                i++;
            }
            foreach (DataGridViewRow row in dataGridView03.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value) )
                { 
                    dataGridView03.Rows.RemoveAt(row.Index);
                }


            }
        }
    }
}
