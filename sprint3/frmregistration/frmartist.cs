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
    public partial class frmartist : Form
    {
        public frmartist()
        {
            InitializeComponent();
        }
        private static frmartist login_frm;
        public static frmartist getinstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmartist();
            }
            return login_frm;
        }


        private void frmartist_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView04_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel02_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Server2.Service1 myserver = new Server2.Service1();
            List<Server2.MakeupArtist> get_makeupartist = new List<Server2.MakeupArtist>();
            get_makeupartist = myserver.getmakeupartist().ToList<Server2.MakeupArtist>();
            BindingSource s = new BindingSource();
            s.DataSource = get_makeupartist;
            dataGridView04.DataSource = s;
            dataGridView04.Columns.RemoveAt(3);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
