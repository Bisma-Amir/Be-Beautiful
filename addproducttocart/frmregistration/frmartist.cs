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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    
    }
}
