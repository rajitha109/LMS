namespace LibraryManagementSystem
{
    partial class frmbookcategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbookcategory));
            this.grbbkcat1 = new System.Windows.Forms.GroupBox();
            this.dgrbkcat = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnbkcat_exit = new DevComponents.DotNetBar.ButtonX();
            this.lblcrs_name = new MetroFramework.Controls.MetroLabel();
            this.btnbkcat_delete = new DevComponents.DotNetBar.ButtonX();
            this.lblcrs_id = new MetroFramework.Controls.MetroLabel();
            this.btnbkcat_refresh = new DevComponents.DotNetBar.ButtonX();
            this.txtbkcat_ttl1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnbkcat_update = new DevComponents.DotNetBar.ButtonX();
            this.btnbkcat_add = new DevComponents.DotNetBar.ButtonX();
            this.txtbkcat_no1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblid = new MetroFramework.Controls.MetroLabel();
            this.grbbkcat1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrbkcat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbbkcat1
            // 
            this.grbbkcat1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbbkcat1.Controls.Add(this.lblid);
            this.grbbkcat1.Controls.Add(this.dgrbkcat);
            this.grbbkcat1.Controls.Add(this.btnbkcat_exit);
            this.grbbkcat1.Controls.Add(this.lblcrs_name);
            this.grbbkcat1.Controls.Add(this.btnbkcat_delete);
            this.grbbkcat1.Controls.Add(this.lblcrs_id);
            this.grbbkcat1.Controls.Add(this.btnbkcat_refresh);
            this.grbbkcat1.Controls.Add(this.txtbkcat_ttl1);
            this.grbbkcat1.Controls.Add(this.btnbkcat_update);
            this.grbbkcat1.Controls.Add(this.btnbkcat_add);
            this.grbbkcat1.Controls.Add(this.txtbkcat_no1);
            this.grbbkcat1.Controls.Add(this.pictureBox1);
            this.grbbkcat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbkcat1.Location = new System.Drawing.Point(12, 12);
            this.grbbkcat1.Name = "grbbkcat1";
            this.grbbkcat1.Size = new System.Drawing.Size(890, 417);
            this.grbbkcat1.TabIndex = 0;
            this.grbbkcat1.TabStop = false;
            // 
            // dgrbkcat
            // 
            this.dgrbkcat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrbkcat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrbkcat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrbkcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrbkcat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrbkcat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.dgrbkcat.Location = new System.Drawing.Point(486, 17);
            this.dgrbkcat.Name = "dgrbkcat";
            this.dgrbkcat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrbkcat.Size = new System.Drawing.Size(398, 394);
            this.dgrbkcat.TabIndex = 5;
            this.dgrbkcat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrbkcat_CellDoubleClick);
            // 
            // btnbkcat_exit
            // 
            this.btnbkcat_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbkcat_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbkcat_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkcat_exit.Location = new System.Drawing.Point(200, 199);
            this.btnbkcat_exit.Name = "btnbkcat_exit";
            this.btnbkcat_exit.Size = new System.Drawing.Size(109, 39);
            this.btnbkcat_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbkcat_exit.TabIndex = 85;
            this.btnbkcat_exit.Text = "Exit";
            this.btnbkcat_exit.Click += new System.EventHandler(this.btnbkcat_exit_Click);
            // 
            // lblcrs_name
            // 
            this.lblcrs_name.AutoSize = true;
            this.lblcrs_name.Location = new System.Drawing.Point(23, 91);
            this.lblcrs_name.Name = "lblcrs_name";
            this.lblcrs_name.Size = new System.Drawing.Size(45, 19);
            this.lblcrs_name.TabIndex = 17;
            this.lblcrs_name.Text = "Name";
            // 
            // btnbkcat_delete
            // 
            this.btnbkcat_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbkcat_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbkcat_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkcat_delete.Location = new System.Drawing.Point(85, 199);
            this.btnbkcat_delete.Name = "btnbkcat_delete";
            this.btnbkcat_delete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnbkcat_delete.Size = new System.Drawing.Size(109, 39);
            this.btnbkcat_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbkcat_delete.TabIndex = 84;
            this.btnbkcat_delete.Text = "DELETE";
            this.btnbkcat_delete.Click += new System.EventHandler(this.btnbkcat_delete_Click);
            // 
            // lblcrs_id
            // 
            this.lblcrs_id.AutoSize = true;
            this.lblcrs_id.Location = new System.Drawing.Point(23, 42);
            this.lblcrs_id.Name = "lblcrs_id";
            this.lblcrs_id.Size = new System.Drawing.Size(30, 19);
            this.lblcrs_id.TabIndex = 16;
            this.lblcrs_id.Text = "NO";
            // 
            // btnbkcat_refresh
            // 
            this.btnbkcat_refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbkcat_refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbkcat_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkcat_refresh.Location = new System.Drawing.Point(255, 154);
            this.btnbkcat_refresh.Name = "btnbkcat_refresh";
            this.btnbkcat_refresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnbkcat_refresh.Size = new System.Drawing.Size(109, 39);
            this.btnbkcat_refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbkcat_refresh.TabIndex = 83;
            this.btnbkcat_refresh.Text = "REFRESH";
            this.btnbkcat_refresh.Click += new System.EventHandler(this.btnbkcat_refresh_Click);
            // 
            // txtbkcat_ttl1
            // 
            // 
            // 
            // 
            this.txtbkcat_ttl1.Border.Class = "TextBoxBorder";
            this.txtbkcat_ttl1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbkcat_ttl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbkcat_ttl1.Location = new System.Drawing.Point(109, 91);
            this.txtbkcat_ttl1.Name = "txtbkcat_ttl1";
            this.txtbkcat_ttl1.Size = new System.Drawing.Size(206, 26);
            this.txtbkcat_ttl1.TabIndex = 15;
            this.txtbkcat_ttl1.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtbkcat_ttl1.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbkcat_ttl1.WatermarkText = "Enter Book Category Here";
            // 
            // btnbkcat_update
            // 
            this.btnbkcat_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbkcat_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbkcat_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkcat_update.Location = new System.Drawing.Point(140, 154);
            this.btnbkcat_update.Name = "btnbkcat_update";
            this.btnbkcat_update.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlEnter);
            this.btnbkcat_update.Size = new System.Drawing.Size(109, 39);
            this.btnbkcat_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbkcat_update.TabIndex = 82;
            this.btnbkcat_update.Text = "UPDATE";
            this.btnbkcat_update.Click += new System.EventHandler(this.btnbkcat_update_Click);
            // 
            // btnbkcat_add
            // 
            this.btnbkcat_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbkcat_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbkcat_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkcat_add.Location = new System.Drawing.Point(25, 154);
            this.btnbkcat_add.Name = "btnbkcat_add";
            this.btnbkcat_add.Size = new System.Drawing.Size(109, 39);
            this.btnbkcat_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbkcat_add.TabIndex = 82;
            this.btnbkcat_add.Text = "SAVE";
            this.btnbkcat_add.Click += new System.EventHandler(this.btnbkcat_add_Click);
            // 
            // txtbkcat_no1
            // 
            // 
            // 
            // 
            this.txtbkcat_no1.Border.Class = "TextBoxBorder";
            this.txtbkcat_no1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbkcat_no1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbkcat_no1.Location = new System.Drawing.Point(109, 42);
            this.txtbkcat_no1.Name = "txtbkcat_no1";
            this.txtbkcat_no1.Size = new System.Drawing.Size(104, 26);
            this.txtbkcat_no1.TabIndex = 10;
            this.txtbkcat_no1.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtbkcat_no1.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbkcat_no1.WatermarkText = "Category NO";
            this.txtbkcat_no1.TextChanged += new System.EventHandler(this.txtbkcat_no1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.book_cat;
            this.pictureBox1.Location = new System.Drawing.Point(6, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(308, 22);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(30, 19);
            this.lblid.TabIndex = 87;
            this.lblid.Text = "NO";
            this.lblid.Visible = false;
            // 
            // frmbookcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 441);
            this.Controls.Add(this.grbbkcat1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmbookcategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Category";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmbookcategory_FormClosed);
            this.Load += new System.EventHandler(this.frmbookcategory_Load);
            this.grbbkcat1.ResumeLayout(false);
            this.grbbkcat1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrbkcat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbbkcat1;
        private DevComponents.DotNetBar.ButtonX btnbkcat_add;
        private DevComponents.DotNetBar.ButtonX btnbkcat_update;
        private DevComponents.DotNetBar.ButtonX btnbkcat_refresh;
        private DevComponents.DotNetBar.ButtonX btnbkcat_delete;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgrbkcat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbkcat_ttl1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbkcat_no1;
        private DevComponents.DotNetBar.ButtonX btnbkcat_exit;
        private MetroFramework.Controls.MetroLabel lblcrs_id;
        private MetroFramework.Controls.MetroLabel lblcrs_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblid;
    }
}