namespace PhoneBookWinForm
{
    partial class PersonInformation
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
            this.txtPersonalInfo1 = new System.Windows.Forms.TextBox();
            this.txtPersonalInfo2 = new System.Windows.Forms.TextBox();
            this.txtPersonalInfo3 = new System.Windows.Forms.TextBox();
            this.txtPersonalInfo0 = new System.Windows.Forms.TextBox();
            this.txtPersonalInfo4 = new System.Windows.Forms.TextBox();
            this.txtPersonalInfo5 = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonalInfo6 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPersonalInfo1
            // 
            this.txtPersonalInfo1.Location = new System.Drawing.Point(100, 59);
            this.txtPersonalInfo1.Name = "txtPersonalInfo1";
            this.txtPersonalInfo1.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalInfo1.TabIndex = 0;
            // 
            // txtPersonalInfo2
            // 
            this.txtPersonalInfo2.Location = new System.Drawing.Point(100, 85);
            this.txtPersonalInfo2.Name = "txtPersonalInfo2";
            this.txtPersonalInfo2.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalInfo2.TabIndex = 1;
            // 
            // txtPersonalInfo3
            // 
            this.txtPersonalInfo3.Location = new System.Drawing.Point(100, 111);
            this.txtPersonalInfo3.Name = "txtPersonalInfo3";
            this.txtPersonalInfo3.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalInfo3.TabIndex = 2;
            // 
            // txtPersonalInfo0
            // 
            this.txtPersonalInfo0.Location = new System.Drawing.Point(100, 33);
            this.txtPersonalInfo0.Name = "txtPersonalInfo0";
            this.txtPersonalInfo0.ReadOnly = true;
            this.txtPersonalInfo0.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalInfo0.TabIndex = 3;
            // 
            // txtPersonalInfo4
            // 
            this.txtPersonalInfo4.Location = new System.Drawing.Point(100, 138);
            this.txtPersonalInfo4.Name = "txtPersonalInfo4";
            this.txtPersonalInfo4.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalInfo4.TabIndex = 4;
            // 
            // txtPersonalInfo5
            // 
            this.txtPersonalInfo5.Location = new System.Drawing.Point(100, 165);
            this.txtPersonalInfo5.Mask = "(999) 000-0000";
            this.txtPersonalInfo5.Name = "txtPersonalInfo5";
            this.txtPersonalInfo5.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalInfo5.TabIndex = 5;
            // 
            // txtPersonalInfo6
            // 
            this.txtPersonalInfo6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonalInfo6.Location = new System.Drawing.Point(6, 19);
            this.txtPersonalInfo6.Name = "txtPersonalInfo6";
            this.txtPersonalInfo6.Size = new System.Drawing.Size(504, 134);
            this.txtPersonalInfo6.TabIndex = 6;
            this.txtPersonalInfo6.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "LastName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPersonalInfo6);
            this.groupBox1.Location = new System.Drawing.Point(206, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 159);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneBookWinForm.Properties.Resources.chrome_b8B0RVyhOo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // PersonInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 198);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonalInfo5);
            this.Controls.Add(this.txtPersonalInfo4);
            this.Controls.Add(this.txtPersonalInfo0);
            this.Controls.Add(this.txtPersonalInfo3);
            this.Controls.Add(this.txtPersonalInfo2);
            this.Controls.Add(this.txtPersonalInfo1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(980, 384);
            this.MinimumSize = new System.Drawing.Size(750, 237);
            this.Name = "PersonInformation";
            this.Text = "PersonInformation";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtPersonalInfo1;
        internal System.Windows.Forms.TextBox txtPersonalInfo0;
        internal System.Windows.Forms.TextBox txtPersonalInfo2;
        internal System.Windows.Forms.TextBox txtPersonalInfo3;
        internal System.Windows.Forms.TextBox txtPersonalInfo4;
        internal System.Windows.Forms.MaskedTextBox txtPersonalInfo5;
        internal System.Windows.Forms.RichTextBox txtPersonalInfo6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}