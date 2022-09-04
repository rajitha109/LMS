namespace LibraryManagementSystem
{
    partial class frmsettingsnew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsettingsnew));
            this.lnkset_bkcat = new MetroFramework.Controls.MetroLink();
            this.lnkset_crs = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtlrestore = new MetroFramework.Controls.MetroLink();
            this.mtlbackup = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkset_bkcat
            // 
            this.lnkset_bkcat.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkset_bkcat.Location = new System.Drawing.Point(33, 30);
            this.lnkset_bkcat.Name = "lnkset_bkcat";
            this.lnkset_bkcat.Size = new System.Drawing.Size(179, 29);
            this.lnkset_bkcat.TabIndex = 11;
            this.lnkset_bkcat.Text = "Add Book Category";
            this.lnkset_bkcat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkset_bkcat.UseSelectable = true;
            this.lnkset_bkcat.Click += new System.EventHandler(this.lnkset_bkcat_Click);
            // 
            // lnkset_crs
            // 
            this.lnkset_crs.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkset_crs.Location = new System.Drawing.Point(33, 80);
            this.lnkset_crs.Name = "lnkset_crs";
            this.lnkset_crs.Size = new System.Drawing.Size(110, 23);
            this.lnkset_crs.TabIndex = 12;
            this.lnkset_crs.Text = "Add Course";
            this.lnkset_crs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkset_crs.UseSelectable = true;
            this.lnkset_crs.Click += new System.EventHandler(this.lnkset_crs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.settingsicon;
            this.pictureBox1.Location = new System.Drawing.Point(109, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // mtlrestore
            // 
            this.mtlrestore.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtlrestore.Location = new System.Drawing.Point(33, 173);
            this.mtlrestore.Name = "mtlrestore";
            this.mtlrestore.Size = new System.Drawing.Size(161, 23);
            this.mtlrestore.TabIndex = 15;
            this.mtlrestore.Text = "Restore Database";
            this.mtlrestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlrestore.UseSelectable = true;
            this.mtlrestore.Click += new System.EventHandler(this.mtlrestore_Click);
            // 
            // mtlbackup
            // 
            this.mtlbackup.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtlbackup.Location = new System.Drawing.Point(33, 123);
            this.mtlbackup.Name = "mtlbackup";
            this.mtlbackup.Size = new System.Drawing.Size(179, 29);
            this.mtlbackup.TabIndex = 14;
            this.mtlbackup.Text = "Backup Database";
            this.mtlbackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlbackup.UseSelectable = true;
            this.mtlbackup.Click += new System.EventHandler(this.mtlbackup_Click);
            // 
            // frmsettingsnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(262, 280);
            this.Controls.Add(this.mtlrestore);
            this.Controls.Add(this.mtlbackup);
            this.Controls.Add(this.lnkset_crs);
            this.Controls.Add(this.lnkset_bkcat);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmsettingsnew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmsettingsnew_FormClosed);
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkset_bkcat;
        private MetroFramework.Controls.MetroLink lnkset_crs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink mtlrestore;
        private MetroFramework.Controls.MetroLink mtlbackup;

    }
}