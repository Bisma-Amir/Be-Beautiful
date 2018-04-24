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
using System.Runtime.Serialization;
namespace frmregistration
{
   
    public partial class frmcustomerproduct : Form
    {
        public frmcustomerproduct()
        {
            InitializeComponent();
        }
        private static frmcustomerproduct login_frm;
        public static frmcustomerproduct getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmcustomerproduct();
            }
            return login_frm;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdrange_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            shoppingcart k3 = shoppingcart.getinstance();
            this.Hide();
            k3.Show();
        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            List<Server2.Product> custlist = myserver.searchbyrange(cmdname.Text, cmdrange.Text).ToList<Server2.Product>();

            if (cmdname.Text != "")
            {
                /*DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
                c.ValueType = typeof(bool);
                c.Name = "Chk";
                c.HeaderText = "CheckBox";*/

                BindingSource s = new BindingSource();
                s.DataSource = custlist;
                dataGridView02.DataSource = s;
                /*dataGridView02.Columns.Add(c);*/


               
                List<Server2.Product> purchaselist = new List<Server2.Product>();
                foreach(Server2.Product p in custlist)
                {
                    if(p.Isselect == true)
                    {
                        purchaselist.Add(p);
                       
                    }
                }
                shoppingcart.purchaseL = purchaselist;
                
                



            }
        }
    }
}
