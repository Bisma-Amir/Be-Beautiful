namespace frmregistration
{
    partial class discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(discount));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmddiscount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textdiscount = new System.Windows.Forms.TextBox();
            this.textbill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkLabel1.Location = new System.Drawing.Point(56, 375);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(194, 43);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Shop More!!!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmddiscount
            // 
            this.cmddiscount.BackColor = System.Drawing.Color.White;
            this.cmddiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmddiscount.ForeColor = System.Drawing.Color.Fuchsia;
            this.cmddiscount.Location = new System.Drawing.Point(309, 368);
            this.cmddiscount.Name = "cmddiscount";
            this.cmddiscount.Size = new System.Drawing.Size(244, 50);
            this.cmddiscount.TabIndex = 39;
            this.cmddiscount.Text = "Get discount";
            this.cmddiscount.UseVisualStyleBackColor = false;
            this.cmddiscount.Click += new System.EventHandler(this.cmddiscount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(95, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Discount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textdiscount
            // 
            this.textdiscount.Location = new System.Drawing.Point(309, 267);
            this.textdiscount.Multiline = true;
            this.textdiscount.Name = "textdiscount";
            this.textdiscount.Size = new System.Drawing.Size(209, 30);
            this.textdiscount.TabIndex = 37;
            this.textdiscount.TextChanged += new System.EventHandler(this.textdiscount_TextChanged);
            // 
            // textbill
            // 
            this.textbill.Location = new System.Drawing.Point(309, 165);
            this.textbill.Multiline = true;
            this.textbill.Name = "textbill";
            this.textbill.Size = new System.Drawing.Size(209, 31);
            this.textbill.TabIndex = 36;
            this.textbill.TextChanged += new System.EventHandler(this.textbill_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(95, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Your Bill";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(-31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(667, 51);
            this.label3.TabIndex = 34;
            this.label3.Text = "Avail Discount on our Exciting Collection!!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 448);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmddiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textdiscount);
            this.Controls.Add(this.textbill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "discount";
            this.Text = "discount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button cmddiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textdiscount;
        private System.Windows.Forms.TextBox textbill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}