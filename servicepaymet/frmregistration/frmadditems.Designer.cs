namespace frmregistration
{
    partial class frmadditems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadditems));
            this.lblexistingrecords = new System.Windows.Forms.LinkLabel();
            this.cmdadditem = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.comboboxcategosry = new System.Windows.Forms.ComboBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblpaymentrecords = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblexistingrecords
            // 
            this.lblexistingrecords.AutoSize = true;
            this.lblexistingrecords.BackColor = System.Drawing.Color.White;
            this.lblexistingrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexistingrecords.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblexistingrecords.LinkColor = System.Drawing.Color.Fuchsia;
            this.lblexistingrecords.Location = new System.Drawing.Point(272, 559);
            this.lblexistingrecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblexistingrecords.Name = "lblexistingrecords";
            this.lblexistingrecords.Size = new System.Drawing.Size(320, 36);
            this.lblexistingrecords.TabIndex = 35;
            this.lblexistingrecords.TabStop = true;
            this.lblexistingrecords.Text = "View Existing Record";
            this.lblexistingrecords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cmdadditem
            // 
            this.cmdadditem.BackColor = System.Drawing.Color.White;
            this.cmdadditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdadditem.ForeColor = System.Drawing.Color.Fuchsia;
            this.cmdadditem.Location = new System.Drawing.Point(589, 482);
            this.cmdadditem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdadditem.Name = "cmdadditem";
            this.cmdadditem.Size = new System.Drawing.Size(277, 57);
            this.cmdadditem.TabIndex = 33;
            this.cmdadditem.Text = "ADD ITEM";
            this.cmdadditem.UseVisualStyleBackColor = false;
            this.cmdadditem.Click += new System.EventHandler(this.cmdadditem_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(421, 404);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(285, 20);
            this.txtprice.TabIndex = 32;
            this.txtprice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(421, 340);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtquantity.Multiline = true;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(285, 20);
            this.txtquantity.TabIndex = 31;
            this.txtquantity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Location = new System.Drawing.Point(421, 265);
            this.txtcompanyname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcompanyname.Multiline = true;
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(285, 20);
            this.txtcompanyname.TabIndex = 30;
            this.txtcompanyname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(421, 191);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtitemname.Multiline = true;
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(285, 20);
            this.txtitemname.TabIndex = 29;
            this.txtitemname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboboxcategosry
            // 
            this.comboboxcategosry.FormattingEnabled = true;
            this.comboboxcategosry.Items.AddRange(new object[] {
            "Lip sticks and glose",
            "Eye Liner and Eye Lashes",
            "Face Powder",
            "Base Stick",
            "Eye Shades",
            "Whitening Products",
            "Contoner",
            "Nail products",
            "Hair products",
            "",
            "",
            "",
            ""});
            this.comboboxcategosry.Location = new System.Drawing.Point(421, 117);
            this.comboboxcategosry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboboxcategosry.Name = "comboboxcategosry";
            this.comboboxcategosry.Size = new System.Drawing.Size(285, 24);
            this.comboboxcategosry.TabIndex = 28;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.White;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblprice.Location = new System.Drawing.Point(57, 404);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(100, 39);
            this.lblprice.TabIndex = 27;
            this.lblprice.Text = "Price";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.White;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblquantity.Location = new System.Drawing.Point(57, 340);
            this.lblquantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(151, 39);
            this.lblquantity.TabIndex = 26;
            this.lblquantity.Text = "Quantity";
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.BackColor = System.Drawing.Color.White;
            this.lblcompanyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyname.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblcompanyname.Location = new System.Drawing.Point(55, 265);
            this.lblcompanyname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(275, 39);
            this.lblcompanyname.TabIndex = 25;
            this.lblcompanyname.Text = "Company Name";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.BackColor = System.Drawing.Color.White;
            this.lblitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblitemname.Location = new System.Drawing.Point(57, 191);
            this.lblitemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(112, 39);
            this.lblitemname.TabIndex = 24;
            this.lblitemname.Text = "Name";
            this.lblitemname.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.BackColor = System.Drawing.Color.White;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblcategory.Location = new System.Drawing.Point(57, 117);
            this.lblcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(192, 39);
            this.lblcategory.TabIndex = 23;
            this.lblcategory.Text = "Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(305, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 64);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add Items";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblpaymentrecords
            // 
            this.lblpaymentrecords.AutoSize = true;
            this.lblpaymentrecords.BackColor = System.Drawing.Color.White;
            this.lblpaymentrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaymentrecords.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblpaymentrecords.LinkColor = System.Drawing.Color.Fuchsia;
            this.lblpaymentrecords.Location = new System.Drawing.Point(56, 482);
            this.lblpaymentrecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaymentrecords.Name = "lblpaymentrecords";
            this.lblpaymentrecords.Size = new System.Drawing.Size(249, 36);
            this.lblpaymentrecords.TabIndex = 38;
            this.lblpaymentrecords.TabStop = true;
            this.lblpaymentrecords.Text = "Payment Record";
            this.lblpaymentrecords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblpaymentrecords_LinkClicked);
            // 
            // frmadditems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 591);
            this.Controls.Add(this.lblpaymentrecords);
            this.Controls.Add(this.lblexistingrecords);
            this.Controls.Add(this.cmdadditem);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtcompanyname);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.comboboxcategosry);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.lblitemname);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmadditems";
            this.Text = "frmadditems";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblexistingrecords;
        private System.Windows.Forms.Button cmdadditem;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.ComboBox comboboxcategosry;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblpaymentrecords;
    }
}