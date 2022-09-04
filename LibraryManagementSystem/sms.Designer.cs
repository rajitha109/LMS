namespace LibraryManagementSystem
{
    partial class frmsms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grp_sms = new System.Windows.Forms.GroupBox();
            this.cbo_phoneno = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_comport = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_phoneno = new System.Windows.Forms.Label();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btnsms_send = new DevComponents.DotNetBar.ButtonX();
            this.dtgrid_sms = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grp_sms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_sms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_sms
            // 
            this.grp_sms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_sms.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_sms.Controls.Add(this.dtgrid_sms);
            this.grp_sms.Controls.Add(this.btnsms_send);
            this.grp_sms.Controls.Add(this.cbo_phoneno);
            this.grp_sms.Controls.Add(this.cbo_comport);
            this.grp_sms.Controls.Add(this.lbl_msg);
            this.grp_sms.Controls.Add(this.lbl_phoneno);
            this.grp_sms.Controls.Add(this.lbl_sms);
            this.grp_sms.Controls.Add(this.txt_msg);
            this.grp_sms.Controls.Add(this.pictureBox2);
            this.grp_sms.Controls.Add(this.pictureBox1);
            this.grp_sms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_sms.Location = new System.Drawing.Point(11, 11);
            this.grp_sms.Margin = new System.Windows.Forms.Padding(2);
            this.grp_sms.Name = "grp_sms";
            this.grp_sms.Padding = new System.Windows.Forms.Padding(2);
            this.grp_sms.Size = new System.Drawing.Size(1270, 554);
            this.grp_sms.TabIndex = 75;
            this.grp_sms.TabStop = false;
            this.grp_sms.Text = "Send SMS";
            // 
            // cbo_phoneno
            // 
            this.cbo_phoneno.DisplayMember = "Text";
            this.cbo_phoneno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_phoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phoneno.FormattingEnabled = true;
            this.cbo_phoneno.ItemHeight = 20;
            this.cbo_phoneno.Location = new System.Drawing.Point(338, 155);
            this.cbo_phoneno.Name = "cbo_phoneno";
            this.cbo_phoneno.Size = new System.Drawing.Size(279, 26);
            this.cbo_phoneno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_phoneno.TabIndex = 85;
            this.cbo_phoneno.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phoneno.WatermarkText = "Select Phone Number";
            // 
            // cbo_comport
            // 
            this.cbo_comport.DisplayMember = "Text";
            this.cbo_comport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_comport.FormattingEnabled = true;
            this.cbo_comport.ItemHeight = 20;
            this.cbo_comport.Location = new System.Drawing.Point(338, 99);
            this.cbo_comport.Name = "cbo_comport";
            this.cbo_comport.Size = new System.Drawing.Size(279, 26);
            this.cbo_comport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_comport.TabIndex = 84;
            this.cbo_comport.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_comport.WatermarkText = "Select COM Port";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.Location = new System.Drawing.Point(240, 217);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(69, 18);
            this.lbl_msg.TabIndex = 83;
            this.lbl_msg.Text = "Message";
            // 
            // lbl_phoneno
            // 
            this.lbl_phoneno.AutoSize = true;
            this.lbl_phoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoneno.Location = new System.Drawing.Point(240, 155);
            this.lbl_phoneno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phoneno.Name = "lbl_phoneno";
            this.lbl_phoneno.Size = new System.Drawing.Size(78, 18);
            this.lbl_phoneno.TabIndex = 82;
            this.lbl_phoneno.Text = "Phone NO";
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sms.Location = new System.Drawing.Point(239, 99);
            this.lbl_sms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(76, 18);
            this.lbl_sms.TabIndex = 81;
            this.lbl_sms.Text = "COM Port";
            // 
            // txt_msg
            // 
            this.txt_msg.BackColor = System.Drawing.SystemColors.Info;
            this.txt_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msg.Location = new System.Drawing.Point(338, 212);
            this.txt_msg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_msg.MaxLength = 160;
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(279, 175);
            this.txt_msg.TabIndex = 80;
            this.txt_msg.Text = "Please Return the Book. \r\n                                  Hasalaka Tec";
            // 
            // btnsms_send
            // 
            this.btnsms_send.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsms_send.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsms_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsms_send.Location = new System.Drawing.Point(488, 412);
            this.btnsms_send.Name = "btnsms_send";
            this.btnsms_send.Size = new System.Drawing.Size(129, 52);
            this.btnsms_send.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsms_send.TabIndex = 75;
            this.btnsms_send.Text = "SEND";
            this.btnsms_send.Click += new System.EventHandler(this.btnsms_send_Click);
            // 
            // dtgrid_sms
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrid_sms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgrid_sms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_sms.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrid_sms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_sms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgrid_sms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_sms.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgrid_sms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgrid_sms.Location = new System.Drawing.Point(668, 56);
            this.dtgrid_sms.Name = "dtgrid_sms";
            this.dtgrid_sms.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dtgrid_sms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_sms.Size = new System.Drawing.Size(218, 453);
            this.dtgrid_sms.TabIndex = 77;
            this.dtgrid_sms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_sms_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.sms2;
            this.pictureBox1.Location = new System.Drawing.Point(915, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.sms1;
            this.pictureBox2.Location = new System.Drawing.Point(-27, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // frmsms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 576);
            this.Controls.Add(this.grp_sms);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmsms";
            this.Text = "SMS";
            this.Load += new System.EventHandler(this.sms_Load);
            this.grp_sms.ResumeLayout(false);
            this.grp_sms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_sms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_sms;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_phoneno;
        private System.Windows.Forms.Label lbl_sms;
        private System.Windows.Forms.TextBox txt_msg;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_phoneno;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_comport;
        private DevComponents.DotNetBar.ButtonX btnsms_send;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgrid_sms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}