﻿using System;
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
	public partial class frmconfirmrequest : Form
	{
		public frmconfirmrequest()
		{
			InitializeComponent();
		}
		private static frmconfirmrequest login_frm;
		public static frmconfirmrequest getinstance()
		{
			if (login_frm == null)
			{
				login_frm = new frmconfirmrequest();
			}
			return login_frm;
		}
		Server2.Service1 myserver = new Server2.Service1();
		public static ArrayList cust = new ArrayList();
		static DataGridViewCheckBoxColumn o = new DataGridViewCheckBoxColumn();
		private void linkLabel02_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			DataGridViewCheckBoxColumn o = new DataGridViewCheckBoxColumn();
			o.ValueType = typeof(bool);
			o.Name = "Chk";
			o.HeaderText = "CheckBox";

			Server2.Service1 myserver = new Server2.Service1();
			BindingSource s = new BindingSource();
			s.DataSource = CustomerDL.confirmcust;
			dataGridView04.DataSource = s;
			dataGridView04.Columns.Add(o);

		}

		private void dataGridView04_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i = 0;
			foreach (DataGridViewRow row in dataGridView04.Rows)
			{
				if (Convert.ToBoolean(row.Cells[4].Value))
				{
					CustomerDL.confirmrequest.Add(CustomerDL.confirmcust.ElementAt(i));
				}
				i++;
			}
			MessageBox.Show("I will come on the given date");
		}
	}
}