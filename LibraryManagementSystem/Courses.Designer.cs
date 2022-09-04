namespace LibraryManagementSystem
{
    partial class frmcourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcourses));
            this.grbcrs1 = new System.Windows.Forms.GroupBox();
            this.dgrcrs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnbkcat_exit = new DevComponents.DotNetBar.ButtonX();
            this.cmbcrs_du = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btncrs_refresh = new DevComponents.DotNetBar.ButtonX();
            this.dtpcrs_stdt = new System.Windows.Forms.DateTimePicker();
            this.btncrs_delete = new DevComponents.DotNetBar.ButtonX();
            this.txtcrs_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btncrs_update = new DevComponents.DotNetBar.ButtonX();
            this.btncrs_add = new DevComponents.DotNetBar.ButtonX();
            this.txtcrs_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblcrs_st = new MetroFramework.Controls.MetroLabel();
            this.lblcrs_du = new MetroFramework.Controls.MetroLabel();
            this.lblcrs_name = new MetroFramework.Controls.MetroLabel();
            this.lblcrs_id = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grbcrs1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrcrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grbcrs1
            // 
            this.grbcrs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbcrs1.BackColor = System.Drawing.SystemColors.Window;
            this.grbcrs1.Controls.Add(this.metroLabel1);
            this.grbcrs1.Controls.Add(this.dgrcrs);
            this.grbcrs1.Controls.Add(this.btnbkcat_exit);
            this.grbcrs1.Controls.Add(this.cmbcrs_du);
            this.grbcrs1.Controls.Add(this.btncrs_refresh);
            this.grbcrs1.Controls.Add(this.dtpcrs_stdt);
            this.grbcrs1.Controls.Add(this.btncrs_delete);
            this.grbcrs1.Controls.Add(this.txtcrs_name);
            this.grbcrs1.Controls.Add(this.btncrs_update);
            this.grbcrs1.Controls.Add(this.btncrs_add);
            this.grbcrs1.Controls.Add(this.txtcrs_id);
            this.grbcrs1.Controls.Add(this.lblcrs_st);
            this.grbcrs1.Controls.Add(this.lblcrs_du);
            this.grbcrs1.Controls.Add(this.lblcrs_name);
            this.grbcrs1.Controls.Add(this.lblcrs_id);
            this.grbcrs1.Controls.Add(this.pictureBox1);
            this.grbcrs1.Controls.Add(this.pictureBox2);
            this.grbcrs1.Location = new System.Drawing.Point(12, 12);
            this.grbcrs1.Name = "grbcrs1";
            this.grbcrs1.Size = new System.Drawing.Size(930, 479);
            this.grbcrs1.TabIndex = 0;
            this.grbcrs1.TabStop = false;
            // 
            // dgrcrs
            // 
            this.dgrcrs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrcrs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrcrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrcrs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrcrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrcrs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrcrs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.dgrcrs.Location = new System.Drawing.Point(485, 19);
            this.dgrcrs.Name = "dgrcrs";
            this.dgrcrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrcrs.Size = new System.Drawing.Size(422, 424);
            this.dgrcrs.TabIndex = 11;
            this.dgrcrs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrcrs_CellContentClick);
            this.dgrcrs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrcrs_CellDoubleClick);
            // 
            // btnbkcat_exit
            // 
            this.btnbkcat_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbkcat_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbkcat_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkcat_exit.Location = new System.Drawing.Point(215, 267);
            this.btnbkcat_exit.Name = "btnbkcat_exit";
            this.btnbkcat_exit.Size = new System.Drawing.Size(109, 39);
            this.btnbkcat_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbkcat_exit.TabIndex = 86;
            this.btnbkcat_exit.Text = "Exit";
            this.btnbkcat_exit.Click += new System.EventHandler(this.btnbkcat_exit_Click);
            // 
            // cmbcrs_du
            // 
            // 
            // 
            // 
            this.cmbcrs_du.Border.Class = "TextBoxBorder";
            this.cmbcrs_du.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cmbcrs_du.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcrs_du.Location = new System.Drawing.Point(102, 122);
            this.cmbcrs_du.Name = "cmbcrs_du";
            this.cmbcrs_du.Size = new System.Drawing.Size(64, 26);
            this.cmbcrs_du.TabIndex = 72;
            this.cmbcrs_du.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcrs_du.WatermarkText = "Enter Course Duration Here";
            this.cmbcrs_du.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbcrs_du_KeyPress);
            // 
            // btncrs_refresh
            // 
            this.btncrs_refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncrs_refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncrs_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrs_refresh.Location = new System.Drawing.Point(100, 267);
            this.btncrs_refresh.Name = "btncrs_refresh";
            this.btncrs_refresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btncrs_refresh.Size = new System.Drawing.Size(109, 39);
            this.btncrs_refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncrs_refresh.TabIndex = 0;
            this.btncrs_refresh.Text = "REFRESH";
            this.btncrs_refresh.Click += new System.EventHandler(this.btncrs_refresh_Click);
            // 
            // dtpcrs_stdt
            // 
            this.dtpcrs_stdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcrs_stdt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcrs_stdt.Location = new System.Drawing.Point(102, 171);
            this.dtpcrs_stdt.Margin = new System.Windows.Forms.Padding(2);
            this.dtpcrs_stdt.Name = "dtpcrs_stdt";
            this.dtpcrs_stdt.Size = new System.Drawing.Size(113, 23);
            this.dtpcrs_stdt.TabIndex = 71;
            this.dtpcrs_stdt.Value = new System.DateTime(2016, 9, 4, 0, 0, 0, 0);
            // 
            // btncrs_delete
            // 
            this.btncrs_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncrs_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncrs_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrs_delete.Location = new System.Drawing.Point(280, 222);
            this.btncrs_delete.Name = "btncrs_delete";
            this.btncrs_delete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btncrs_delete.Size = new System.Drawing.Size(109, 39);
            this.btncrs_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncrs_delete.TabIndex = 0;
            this.btncrs_delete.Text = "DELETE";
            this.btncrs_delete.Click += new System.EventHandler(this.btncrs_delete_Click);
            // 
            // txtcrs_name
            // 
            // 
            // 
            // 
            this.txtcrs_name.Border.Class = "TextBoxBorder";
            this.txtcrs_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcrs_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrs_name.Location = new System.Drawing.Point(102, 86);
            this.txtcrs_name.Name = "txtcrs_name";
            this.txtcrs_name.Size = new System.Drawing.Size(185, 26);
            this.txtcrs_name.TabIndex = 8;
            this.txtcrs_name.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrs_name.WatermarkText = "Enter Course Name Here";
            // 
            // btncrs_update
            // 
            this.btncrs_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncrs_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncrs_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrs_update.Location = new System.Drawing.Point(164, 222);
            this.btncrs_update.Name = "btncrs_update";
            this.btncrs_update.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlEnter);
            this.btncrs_update.Size = new System.Drawing.Size(109, 39);
            this.btncrs_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncrs_update.TabIndex = 0;
            this.btncrs_update.Text = "UPDATE";
            this.btncrs_update.Click += new System.EventHandler(this.btncrs_update_Click);
            // 
            // btncrs_add
            // 
            this.btncrs_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncrs_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncrs_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrs_add.Location = new System.Drawing.Point(49, 222);
            this.btncrs_add.Name = "btncrs_add";
            this.btncrs_add.Size = new System.Drawing.Size(109, 39);
            this.btncrs_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncrs_add.TabIndex = 48;
            this.btncrs_add.Text = "SAVE";
            this.btncrs_add.Click += new System.EventHandler(this.btncrs_add_Click);
            // 
            // txtcrs_id
            // 
            // 
            // 
            // 
            this.txtcrs_id.Border.Class = "TextBoxBorder";
            this.txtcrs_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcrs_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrs_id.Location = new System.Drawing.Point(102, 45);
            this.txtcrs_id.Name = "txtcrs_id";
            this.txtcrs_id.Size = new System.Drawing.Size(185, 26);
            this.txtcrs_id.TabIndex = 7;
            this.txtcrs_id.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtcrs_id.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrs_id.WatermarkText = "Enter Course ID Here";
            this.txtcrs_id.TextChanged += new System.EventHandler(this.txtcrs_id_TextChanged);
            // 
            // lblcrs_st
            // 
            this.lblcrs_st.AutoSize = true;
            this.lblcrs_st.Location = new System.Drawing.Point(22, 171);
            this.lblcrs_st.Name = "lblcrs_st";
            this.lblcrs_st.Size = new System.Drawing.Size(67, 19);
            this.lblcrs_st.TabIndex = 3;
            this.lblcrs_st.Text = "Start Date";
            // 
            // lblcrs_du
            // 
            this.lblcrs_du.AutoSize = true;
            this.lblcrs_du.Location = new System.Drawing.Point(22, 129);
            this.lblcrs_du.Name = "lblcrs_du";
            this.lblcrs_du.Size = new System.Drawing.Size(59, 19);
            this.lblcrs_du.TabIndex = 2;
            this.lblcrs_du.Text = "Duration";
            // 
            // lblcrs_name
            // 
            this.lblcrs_name.AutoSize = true;
            this.lblcrs_name.Location = new System.Drawing.Point(22, 87);
            this.lblcrs_name.Name = "lblcrs_name";
            this.lblcrs_name.Size = new System.Drawing.Size(45, 19);
            this.lblcrs_name.TabIndex = 1;
            this.lblcrs_name.Text = "Name";
            // 
            // lblcrs_id
            // 
            this.lblcrs_id.AutoSize = true;
            this.lblcrs_id.Location = new System.Drawing.Point(22, 45);
            this.lblcrs_id.Name = "lblcrs_id";
            this.lblcrs_id.Size = new System.Drawing.Size(21, 19);
            this.lblcrs_id.TabIndex = 0;
            this.lblcrs_id.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.courses;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.courses3;
            this.pictureBox2.Location = new System.Drawing.Point(319, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(172, 129);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 88;
            this.metroLabel1.Text = "Months";
            // 
            // frmcourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.grbcrs1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmcourses_FormClosed);
            this.Load += new System.EventHandler(this.Courses_Load);
            this.grbcrs1.ResumeLayout(false);
            this.grbcrs1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrcrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbcrs1;
        private MetroFramework.Controls.MetroLabel lblcrs_name;
        private MetroFramework.Controls.MetroLabel lblcrs_id;
        private MetroFramework.Controls.MetroLabel lblcrs_du;
        private MetroFramework.Controls.MetroLabel lblcrs_st;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcrs_name;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcrs_id;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgrcrs;
        private DevComponents.DotNetBar.ButtonX btncrs_refresh;
        private DevComponents.DotNetBar.ButtonX btncrs_delete;
        private DevComponents.DotNetBar.ButtonX btncrs_update;
        private DevComponents.DotNetBar.ButtonX btncrs_add;
        private DevComponents.DotNetBar.ButtonX btnbkcat_exit;
        private System.Windows.Forms.DateTimePicker dtpcrs_stdt;
        private DevComponents.DotNetBar.Controls.TextBoxX cmbcrs_du;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}