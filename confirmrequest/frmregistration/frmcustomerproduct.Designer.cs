namespace frmregistration
{
    partial class frmcustomerproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomerproduct));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView02 = new System.Windows.Forms.DataGridView();
            this.cmdrange = new System.Windows.Forms.TextBox();
            this.cmdname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdok = new System.Windows.Forms.Button();
            this.linklogout4 = new System.Windows.Forms.LinkLabel();
            this.linkHome4 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkLabel1.Location = new System.Drawing.Point(459, 470);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 25);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show my Cart";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView02
            // 
            this.dataGridView02.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView02.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView02.Location = new System.Drawing.Point(27, 188);
            this.dataGridView02.Name = "dataGridView02";
            this.dataGridView02.Size = new System.Drawing.Size(589, 264);
            this.dataGridView02.TabIndex = 16;
            this.dataGridView02.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdrange
            // 
            this.cmdrange.Location = new System.Drawing.Point(424, 134);
            this.cmdrange.Multiline = true;
            this.cmdrange.Name = "cmdrange";
            this.cmdrange.Size = new System.Drawing.Size(155, 29);
            this.cmdrange.TabIndex = 15;
            this.cmdrange.TextChanged += new System.EventHandler(this.cmdrange_TextChanged);
            // 
            // cmdname
            // 
            this.cmdname.Location = new System.Drawing.Point(154, 134);
            this.cmdname.Multiline = true;
            this.cmdname.Name = "cmdname";
            this.cmdname.Size = new System.Drawing.Size(155, 29);
            this.cmdname.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(329, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(32, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Papyrus", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(226, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 76);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdok
            // 
            this.cmdok.Location = new System.Drawing.Point(585, 134);
            this.cmdok.Name = "cmdok";
            this.cmdok.Size = new System.Drawing.Size(36, 23);
            this.cmdok.TabIndex = 19;
            this.cmdok.Text = "Ok";
            this.cmdok.UseVisualStyleBackColor = true;
            this.cmdok.Click += new System.EventHandler(this.cmdok_Click);
            // 
            // linklogout4
            // 
            this.linklogout4.AutoSize = true;
            this.linklogout4.BackColor = System.Drawing.Color.White;
            this.linklogout4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklogout4.ForeColor = System.Drawing.Color.Fuchsia;
            this.linklogout4.LinkColor = System.Drawing.Color.Fuchsia;
            this.linklogout4.Location = new System.Drawing.Point(509, 25);
            this.linklogout4.Name = "linklogout4";
            this.linklogout4.Size = new System.Drawing.Size(93, 29);
            this.linklogout4.TabIndex = 42;
            this.linklogout4.TabStop = true;
            this.linklogout4.Text = "Logout";
            this.linklogout4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklogout4_LinkClicked);
            // 
            // linkHome4
            // 
            this.linkHome4.AutoSize = true;
            this.linkHome4.BackColor = System.Drawing.Color.White;
            this.linkHome4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHome4.ForeColor = System.Drawing.Color.Fuchsia;
            this.linkHome4.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkHome4.Location = new System.Drawing.Point(22, 25);
            this.linkHome4.Name = "linkHome4";
            this.linkHome4.Size = new System.Drawing.Size(82, 29);
            this.linkHome4.TabIndex = 43;
            this.linkHome4.TabStop = true;
            this.linkHome4.Text = "Home";
            this.linkHome4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHome4_LinkClicked);
            // 
            // frmcustomerproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 504);
            this.Controls.Add(this.linkHome4);
            this.Controls.Add(this.linklogout4);
            this.Controls.Add(this.cmdok);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView02);
            this.Controls.Add(this.cmdrange);
            this.Controls.Add(this.cmdname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcustomerproduct";
            this.Text = "frmcustomerproduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView02;
        private System.Windows.Forms.TextBox cmdrange;
        private System.Windows.Forms.TextBox cmdname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdok;
        private System.Windows.Forms.LinkLabel linklogout4;
        private System.Windows.Forms.LinkLabel linkHome4;
    }
}