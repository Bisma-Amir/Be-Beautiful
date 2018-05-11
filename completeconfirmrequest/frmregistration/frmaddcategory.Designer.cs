namespace frmregistration
{
    partial class frmaddcategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddcategory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkHome1 = new System.Windows.Forms.LinkLabel();
            this.linklogout1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // linkHome1
            // 
            this.linkHome1.AutoSize = true;
            this.linkHome1.BackColor = System.Drawing.Color.White;
            this.linkHome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHome1.ForeColor = System.Drawing.Color.Fuchsia;
            this.linkHome1.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkHome1.Location = new System.Drawing.Point(12, 19);
            this.linkHome1.Name = "linkHome1";
            this.linkHome1.Size = new System.Drawing.Size(82, 29);
            this.linkHome1.TabIndex = 41;
            this.linkHome1.TabStop = true;
            this.linkHome1.Text = "Home";
            // 
            // linklogout1
            // 
            this.linklogout1.AutoSize = true;
            this.linklogout1.BackColor = System.Drawing.Color.White;
            this.linklogout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklogout1.ForeColor = System.Drawing.Color.Fuchsia;
            this.linklogout1.LinkColor = System.Drawing.Color.Fuchsia;
            this.linklogout1.Location = new System.Drawing.Point(531, 19);
            this.linklogout1.Name = "linklogout1";
            this.linklogout1.Size = new System.Drawing.Size(93, 29);
            this.linklogout1.TabIndex = 42;
            this.linklogout1.TabStop = true;
            this.linklogout1.Text = "Logout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(216, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 51);
            this.label1.TabIndex = 43;
            this.label1.Text = "Add Items";
            // 
            // frmaddcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklogout1);
            this.Controls.Add(this.linkHome1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmaddcategory";
            this.Text = "frmaddcategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkHome1;
        private System.Windows.Forms.LinkLabel linklogout1;
        private System.Windows.Forms.Label label1;
    }
}