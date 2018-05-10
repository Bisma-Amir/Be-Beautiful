namespace frmregistration
{
    partial class paymentrecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentrecord));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linklogout3 = new System.Windows.Forms.LinkLabel();
            this.linkHome3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel09 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(173, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 51);
            this.label2.TabIndex = 29;
            this.label2.Text = "Payment Records";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(381, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 53);
            this.button1.TabIndex = 28;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(21, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 264);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(66, -162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Payment Records";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linklogout3
            // 
            this.linklogout3.AutoSize = true;
            this.linklogout3.BackColor = System.Drawing.Color.White;
            this.linklogout3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklogout3.ForeColor = System.Drawing.Color.Fuchsia;
            this.linklogout3.LinkColor = System.Drawing.Color.Fuchsia;
            this.linklogout3.Location = new System.Drawing.Point(484, 9);
            this.linklogout3.Name = "linklogout3";
            this.linklogout3.Size = new System.Drawing.Size(93, 29);
            this.linklogout3.TabIndex = 41;
            this.linklogout3.TabStop = true;
            this.linklogout3.Text = "Logout";
            this.linklogout3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklogout3_LinkClicked);
            // 
            // linkHome3
            // 
            this.linkHome3.AutoSize = true;
            this.linkHome3.BackColor = System.Drawing.Color.White;
            this.linkHome3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHome3.ForeColor = System.Drawing.Color.Fuchsia;
            this.linkHome3.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkHome3.Location = new System.Drawing.Point(16, 9);
            this.linkHome3.Name = "linkHome3";
            this.linkHome3.Size = new System.Drawing.Size(82, 29);
            this.linkHome3.TabIndex = 42;
            this.linkHome3.TabStop = true;
            this.linkHome3.Text = "Home";
            this.linkHome3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHome3_LinkClicked);
            // 
            // linkLabel09
            // 
            this.linkLabel09.AutoSize = true;
            this.linkLabel09.BackColor = System.Drawing.Color.White;
            this.linkLabel09.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel09.ForeColor = System.Drawing.Color.Fuchsia;
            this.linkLabel09.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkLabel09.Location = new System.Drawing.Point(178, 88);
            this.linkLabel09.Name = "linkLabel09";
            this.linkLabel09.Size = new System.Drawing.Size(277, 29);
            this.linkLabel09.TabIndex = 43;
            this.linkLabel09.TabStop = true;
            this.linkLabel09.Text = "Show Payment Record";
            this.linkLabel09.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel09_LinkClicked);
            // 
            // paymentrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 443);
            this.Controls.Add(this.linkLabel09);
            this.Controls.Add(this.linkHome3);
            this.Controls.Add(this.linklogout3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paymentrecord";
            this.Text = "paymentrecord";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linklogout3;
        private System.Windows.Forms.LinkLabel linkHome3;
        private System.Windows.Forms.LinkLabel linkLabel09;
    }
}