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
    public partial class frmcommission : Form
    {
        public frmcommission()
        {
            InitializeComponent();
        }
        private List<Server2.MakeupArtist> commisionmake;
       
        private static frmcommission login_frm;
        public static frmcommission getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmcommission();
            }
            return login_frm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkHome3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frontpage l2 = frontpage.getinstance();
            this.Hide();
            l2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.ColumnCount = 2;
            //dataGridView1.Columns[0].Name = "Makeup_artist_bill";
            //dataGridView1.Columns[1].Name = "My_Commission";
            
        }

        private void linkLabel09_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            string commisions;
            string a = frmcategory.pricemake;
            commisions=myserver.commission(a );

            commisionmake = myserver.commisionadmin(frmcategory.Namemakeup, commisions).ToList<Server2.MakeupArtist>();
            BindingSource S = new BindingSource();
            S.DataSource = commisionmake;
            dataGridView1.DataSource = S;
        }
    }
}
