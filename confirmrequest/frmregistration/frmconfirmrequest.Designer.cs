﻿namespace frmregistration
{
	partial class frmconfirmrequest
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconfirmrequest));
			this.linkLabel07 = new System.Windows.Forms.LinkLabel();
			this.linkLabel08 = new System.Windows.Forms.LinkLabel();
			this.linkLabel02 = new System.Windows.Forms.LinkLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView04 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView04)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// linkLabel07
			// 
			this.linkLabel07.ActiveLinkColor = System.Drawing.Color.Fuchsia;
			this.linkLabel07.AutoSize = true;
			this.linkLabel07.BackColor = System.Drawing.Color.White;
			this.linkLabel07.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel07.ForeColor = System.Drawing.Color.Fuchsia;
			this.linkLabel07.LinkColor = System.Drawing.Color.Fuchsia;
			this.linkLabel07.Location = new System.Drawing.Point(42, 34);
			this.linkLabel07.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel07.Name = "linkLabel07";
			this.linkLabel07.Size = new System.Drawing.Size(90, 31);
			this.linkLabel07.TabIndex = 37;
			this.linkLabel07.TabStop = true;
			this.linkLabel07.Text = "Home";
			// 
			// linkLabel08
			// 
			this.linkLabel08.ActiveLinkColor = System.Drawing.Color.Fuchsia;
			this.linkLabel08.AutoSize = true;
			this.linkLabel08.BackColor = System.Drawing.Color.White;
			this.linkLabel08.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel08.ForeColor = System.Drawing.Color.Fuchsia;
			this.linkLabel08.LinkColor = System.Drawing.Color.Fuchsia;
			this.linkLabel08.Location = new System.Drawing.Point(529, 34);
			this.linkLabel08.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel08.Name = "linkLabel08";
			this.linkLabel08.Size = new System.Drawing.Size(103, 31);
			this.linkLabel08.TabIndex = 36;
			this.linkLabel08.TabStop = true;
			this.linkLabel08.Text = "Logout";
			// 
			// linkLabel02
			// 
			this.linkLabel02.ActiveLinkColor = System.Drawing.Color.Fuchsia;
			this.linkLabel02.AutoSize = true;
			this.linkLabel02.BackColor = System.Drawing.Color.White;
			this.linkLabel02.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel02.ForeColor = System.Drawing.Color.Fuchsia;
			this.linkLabel02.LinkColor = System.Drawing.Color.Fuchsia;
			this.linkLabel02.Location = new System.Drawing.Point(237, 111);
			this.linkLabel02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel02.Name = "linkLabel02";
			this.linkLabel02.Size = new System.Drawing.Size(209, 31);
			this.linkLabel02.TabIndex = 35;
			this.linkLabel02.TabStop = true;
			this.linkLabel02.Text = "View Requests";
			this.linkLabel02.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel02_LinkClicked);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Fuchsia;
			this.button1.Location = new System.Drawing.Point(406, 353);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(202, 32);
			this.button1.TabIndex = 34;
			this.button1.Text = "Send Request";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView04
			// 
			this.dataGridView04.BackgroundColor = System.Drawing.Color.Fuchsia;
			this.dataGridView04.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView04.Location = new System.Drawing.Point(76, 144);
			this.dataGridView04.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView04.Name = "dataGridView04";
			this.dataGridView04.RowTemplate.Height = 24;
			this.dataGridView04.Size = new System.Drawing.Size(549, 199);
			this.dataGridView04.TabIndex = 32;
			this.dataGridView04.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView04_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Fuchsia;
			this.label1.Location = new System.Drawing.Point(223, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 39);
			this.label1.TabIndex = 31;
			this.label1.Text = "MakeUp Artist";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(645, 427);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// frmconfirmrequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 396);
			this.Controls.Add(this.linkLabel07);
			this.Controls.Add(this.linkLabel08);
			this.Controls.Add(this.linkLabel02);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView04);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmconfirmrequest";
			this.Text = "frmconfirmrequest";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView04)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkLabel07;
		private System.Windows.Forms.LinkLabel linkLabel08;
		private System.Windows.Forms.LinkLabel linkLabel02;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView04;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}