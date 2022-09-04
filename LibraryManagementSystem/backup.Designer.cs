namespace LibraryManagementSystem
{
    partial class backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrestore = new DevComponents.DotNetBar.ButtonX();
            this.btnempM_add = new DevComponents.DotNetBar.ButtonX();
            this.txtpath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnrestore);
            this.groupBox1.Controls.Add(this.btnempM_add);
            this.groupBox1.Controls.Add(this.txtpath);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Database";
            // 
            // btnrestore
            // 
            this.btnrestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnrestore.Enabled = false;
            this.btnrestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestore.Location = new System.Drawing.Point(494, 95);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(89, 26);
            this.btnrestore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrestore.TabIndex = 2;
            this.btnrestore.Text = "Back Up";
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // btnempM_add
            // 
            this.btnempM_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnempM_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnempM_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempM_add.Location = new System.Drawing.Point(494, 52);
            this.btnempM_add.Name = "btnempM_add";
            this.btnempM_add.Size = new System.Drawing.Size(89, 26);
            this.btnempM_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnempM_add.TabIndex = 1;
            this.btnempM_add.Text = "Browse";
            this.btnempM_add.Click += new System.EventHandler(this.btnempM_add_Click);
            // 
            // txtpath
            // 
            this.txtpath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.txtpath.Border.Class = "TextBoxBorder";
            this.txtpath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpath.Location = new System.Drawing.Point(92, 52);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(396, 26);
            this.txtpath.TabIndex = 0;
            this.txtpath.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtpath.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpath.WatermarkText = "Browse and select path to backup database..";
            this.txtpath.TextChanged += new System.EventHandler(this.txtpath_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.backup1;
            this.pictureBox1.Location = new System.Drawing.Point(-42, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(637, 206);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(653, 244);
            this.Name = "backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup To";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnrestore;
        private DevComponents.DotNetBar.ButtonX btnempM_add;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpath;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}