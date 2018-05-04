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
using System.Threading;
using System.Diagnostics;



namespace frmregistration
{
   
    public partial class frmcustomerproduct : Form
    {
        public frmcustomerproduct()
        {
            InitializeComponent();
        }
        public static List<Server2.Product> custlist;
        public  static List<Server2.Product> purchaseL;
        private static frmcustomerproduct login_frm;
        static DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
        public static frmcustomerproduct getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmcustomerproduct();
            }
            return login_frm;
        }

       

        private void cmdrange_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
       
        private void cmdok_Click(object sender, EventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            custlist = myserver.searchbyrange(cmdname.Text, cmdrange.Text).ToList<Server2.Product>();

            if (cmdname.Text != "")
            {
                DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
                c.ValueType = typeof(bool);
                c.Name = "Chk";
                c.HeaderText = "CheckBox";
                
                BindingSource s = new BindingSource();
                s.DataSource = custlist;
                dataGridView02.DataSource = s;
                dataGridView02.Columns.Add(c);

                

                // int milliseconds = 10000;
                //Thread.Sleep(milliseconds);

            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            int i = 0;
            Server2.Service1 myserver = new Server2.Service1();

           //// List<Server2.Product> purchaselist = new List<Server2.Product>();
           foreach (DataGridViewRow row in dataGridView02.Rows)
               {
                 if (Convert.ToBoolean(row.Cells[4].Value))
                    {
                   purchaseL = myserver.purchased_product(custlist.ElementAt(i)).ToList<Server2.Product>();
                    }
                   i++;
                                    
               }
           shoppingcart k3 = shoppingcart.getinstance();
            this.Hide();
            k3.Show();
        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void linklogout4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin l1 = frmlogin.getinstance();
            this.Hide();
            l1.Show();
        }

        private void linkHome4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frontpage l2 = frontpage.getinstance();
            this.Hide();
            l2.Show();
        }
    }
}
