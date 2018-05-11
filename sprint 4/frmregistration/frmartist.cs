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
        
        static DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
        public static List<Server2.MakeupArtist> sendrequests;
        public static  List<Server2.Customer> customerrequest;
        public static List<Server2.MakeupArtist> get_makeupartist;
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
            int i = 0;
			Server2.Service1 myserver = new Server2.Service1();

			foreach (DataGridViewRow row in dataGridView04.Rows)
            {
                if (Convert.ToBoolean(row.Cells[6].Value))
                {
                    sendrequests = myserver.sendrequest(get_makeupartist.ElementAt(i)).ToList<Server2.MakeupArtist>();
                    
                  
                    //m.Custname = Name;
                    //m.Custpassword = frmlogin.PWD2;
                    //m.Custphone = "";
                    //m.Custaddress = "";
                    //m.Custcity = " ";
                   
                    
                   
                }
                i++;
            }
            customerrequest = myserver.addrequestedcustomer(frmlogin.Name1).ToList<Server2.Customer>();

           
            MessageBox.Show("request sent to the makeup artist");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView04_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel02_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGridViewCheckBoxColumn d = new DataGridViewCheckBoxColumn();
            d.ValueType = typeof(bool);
            d.Name = "Chk";
            d.HeaderText = "CheckBox";

            Server2.Service1 myserver = new Server2.Service1();
            get_makeupartist = myserver.getmakeupartist().ToList<Server2.MakeupArtist>();
            BindingSource s = new BindingSource();

            s.DataSource = get_makeupartist;
            dataGridView04.DataSource = s;
            dataGridView04.Columns.RemoveAt(4);
            dataGridView04.Columns.Add(d);
       


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel07_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frontpage f4 = frontpage.getinstance();
            this.Hide();
            f4.Show();
        }

        private void linkLabel08_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin f5 = frmlogin.getinstance();
            this.Hide();
            f5.Show();
        }
    }
}
