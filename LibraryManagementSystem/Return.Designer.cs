namespace LibraryManagementSystem
{
    partial class frmreturn
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
            this.tblrtn = new System.Windows.Forms.TableLayoutPanel();
            this.grbrntm = new System.Windows.Forms.GroupBox();
            this.grbrtnfine = new System.Windows.Forms.GroupBox();
            this.btnrtn_paid = new DevComponents.DotNetBar.ButtonX();
            this.lblrtn_recpt = new MetroFramework.Controls.MetroLabel();
            this.lblrtn_fine = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtrtnm_type = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblissu_memtype = new MetroFramework.Controls.MetroLabel();
            this.txtrtnm_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_S_id = new MetroFramework.Controls.MetroLabel();
            this.grbrtnbk = new System.Windows.Forms.GroupBox();
            this.lblissudate = new System.Windows.Forms.Label();
            this.txtduedate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtrtnbk_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl__B_id = new MetroFramework.Controls.MetroLabel();
            this.lblduedate = new MetroFramework.Controls.MetroLabel();
            this.btnrtn_refresh = new DevComponents.DotNetBar.ButtonX();
            this.btnrtn = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblrtn.SuspendLayout();
            this.grbrntm.SuspendLayout();
            this.grbrtnfine.SuspendLayout();
            this.grbrtnbk.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblrtn
            // 
            this.tblrtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblrtn.ColumnCount = 2;
            this.tblrtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblrtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 539F));
            this.tblrtn.Controls.Add(this.grbrntm, 1, 0);
            this.tblrtn.Controls.Add(this.grbrtnbk, 0, 0);
            this.tblrtn.Location = new System.Drawing.Point(94, 37);
            this.tblrtn.Name = "tblrtn";
            this.tblrtn.RowCount = 1;
            this.tblrtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblrtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tblrtn.Size = new System.Drawing.Size(1078, 379);
            this.tblrtn.TabIndex = 6;
            // 
            // grbrntm
            // 
            this.grbrntm.Controls.Add(this.grbrtnfine);
            this.grbrntm.Controls.Add(this.txtrtnm_type);
            this.grbrntm.Controls.Add(this.lblissu_memtype);
            this.grbrntm.Controls.Add(this.txtrtnm_id);
            this.grbrntm.Controls.Add(this.lbl_S_id);
            this.grbrntm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbrntm.Location = new System.Drawing.Point(542, 3);
            this.grbrntm.Name = "grbrntm";
            this.grbrntm.Size = new System.Drawing.Size(533, 373);
            this.grbrntm.TabIndex = 1;
            this.grbrntm.TabStop = false;
            this.grbrntm.Text = "Member";
            // 
            // grbrtnfine
            // 
            this.grbrtnfine.Controls.Add(this.btnrtn_paid);
            this.grbrtnfine.Controls.Add(this.lblrtn_recpt);
            this.grbrtnfine.Controls.Add(this.lblrtn_fine);
            this.grbrtnfine.Controls.Add(this.metroLabel2);
            this.grbrtnfine.Controls.Add(this.metroLabel1);
            this.grbrtnfine.Location = new System.Drawing.Point(166, 174);
            this.grbrtnfine.Name = "grbrtnfine";
            this.grbrtnfine.Size = new System.Drawing.Size(229, 178);
            this.grbrtnfine.TabIndex = 68;
            this.grbrtnfine.TabStop = false;
            this.grbrtnfine.Text = "Delay Fine";
            // 
            // btnrtn_paid
            // 
            this.btnrtn_paid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrtn_paid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnrtn_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrtn_paid.Location = new System.Drawing.Point(112, 127);
            this.btnrtn_paid.Name = "btnrtn_paid";
            this.btnrtn_paid.Size = new System.Drawing.Size(98, 36);
            this.btnrtn_paid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrtn_paid.TabIndex = 72;
            this.btnrtn_paid.Text = "Paid";
            this.btnrtn_paid.Click += new System.EventHandler(this.btnrtn_paid_Click);
            // 
            // lblrtn_recpt
            // 
            this.lblrtn_recpt.AutoSize = true;
            this.lblrtn_recpt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblrtn_recpt.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblrtn_recpt.Location = new System.Drawing.Point(108, 87);
            this.lblrtn_recpt.Name = "lblrtn_recpt";
            this.lblrtn_recpt.Size = new System.Drawing.Size(102, 25);
            this.lblrtn_recpt.TabIndex = 71;
            this.lblrtn_recpt.Text = "Receipt NO";
            this.lblrtn_recpt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblrtn_recpt.Visible = false;
            // 
            // lblrtn_fine
            // 
            this.lblrtn_fine.AutoSize = true;
            this.lblrtn_fine.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblrtn_fine.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblrtn_fine.Location = new System.Drawing.Point(108, 40);
            this.lblrtn_fine.Name = "lblrtn_fine";
            this.lblrtn_fine.Size = new System.Drawing.Size(92, 25);
            this.lblrtn_fine.TabIndex = 70;
            this.lblrtn_fine.Text = "Fine Value";
            this.lblrtn_fine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 25);
            this.metroLabel2.TabIndex = 69;
            this.metroLabel2.Text = "Receipt NO";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel2.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(10, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 25);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Fine Value";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtrtnm_type
            // 
            // 
            // 
            // 
            this.txtrtnm_type.Border.Class = "TextBoxBorder";
            this.txtrtnm_type.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtrtnm_type.Location = new System.Drawing.Point(166, 60);
            this.txtrtnm_type.Name = "txtrtnm_type";
            this.txtrtnm_type.Size = new System.Drawing.Size(189, 26);
            this.txtrtnm_type.TabIndex = 67;
            // 
            // lblissu_memtype
            // 
            this.lblissu_memtype.AutoSize = true;
            this.lblissu_memtype.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblissu_memtype.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblissu_memtype.Location = new System.Drawing.Point(27, 60);
            this.lblissu_memtype.Name = "lblissu_memtype";
            this.lblissu_memtype.Size = new System.Drawing.Size(122, 25);
            this.lblissu_memtype.TabIndex = 66;
            this.lblissu_memtype.Text = "Member Type";
            this.lblissu_memtype.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtrtnm_id
            // 
            // 
            // 
            // 
            this.txtrtnm_id.Border.Class = "TextBoxBorder";
            this.txtrtnm_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtrtnm_id.Location = new System.Drawing.Point(166, 118);
            this.txtrtnm_id.Name = "txtrtnm_id";
            this.txtrtnm_id.Size = new System.Drawing.Size(189, 26);
            this.txtrtnm_id.TabIndex = 55;
            this.txtrtnm_id.TextChanged += new System.EventHandler(this.txtrtnm_id_TextChanged);
            // 
            // lbl_S_id
            // 
            this.lbl_S_id.AutoSize = true;
            this.lbl_S_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_S_id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_S_id.Location = new System.Drawing.Point(27, 119);
            this.lbl_S_id.Name = "lbl_S_id";
            this.lbl_S_id.Size = new System.Drawing.Size(30, 25);
            this.lbl_S_id.TabIndex = 14;
            this.lbl_S_id.Text = "ID";
            this.lbl_S_id.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grbrtnbk
            // 
            this.grbrtnbk.Controls.Add(this.lblissudate);
            this.grbrtnbk.Controls.Add(this.txtduedate);
            this.grbrtnbk.Controls.Add(this.txtrtnbk_id);
            this.grbrtnbk.Controls.Add(this.lbl__B_id);
            this.grbrtnbk.Controls.Add(this.lblduedate);
            this.grbrtnbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbrtnbk.Location = new System.Drawing.Point(3, 3);
            this.grbrtnbk.Name = "grbrtnbk";
            this.grbrtnbk.Size = new System.Drawing.Size(532, 372);
            this.grbrtnbk.TabIndex = 0;
            this.grbrtnbk.TabStop = false;
            this.grbrtnbk.Text = "Book";
            // 
            // lblissudate
            // 
            this.lblissudate.AutoSize = true;
            this.lblissudate.Location = new System.Drawing.Point(160, 174);
            this.lblissudate.Name = "lblissudate";
            this.lblissudate.Size = new System.Drawing.Size(51, 20);
            this.lblissudate.TabIndex = 55;
            this.lblissudate.Text = "label1";
            this.lblissudate.Visible = false;
            // 
            // txtduedate
            // 
            // 
            // 
            // 
            this.txtduedate.Border.Class = "TextBoxBorder";
            this.txtduedate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtduedate.Location = new System.Drawing.Point(164, 119);
            this.txtduedate.Name = "txtduedate";
            this.txtduedate.Size = new System.Drawing.Size(245, 26);
            this.txtduedate.TabIndex = 54;
            // 
            // txtrtnbk_id
            // 
            // 
            // 
            // 
            this.txtrtnbk_id.Border.Class = "TextBoxBorder";
            this.txtrtnbk_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtrtnbk_id.Location = new System.Drawing.Point(164, 59);
            this.txtrtnbk_id.Name = "txtrtnbk_id";
            this.txtrtnbk_id.Size = new System.Drawing.Size(291, 26);
            this.txtrtnbk_id.TabIndex = 52;
            this.txtrtnbk_id.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrtnbk_id.WatermarkText = "Enter Book ID Here";
            this.txtrtnbk_id.TextChanged += new System.EventHandler(this.txtrtnbk_id_TextChanged);
            // 
            // lbl__B_id
            // 
            this.lbl__B_id.AutoSize = true;
            this.lbl__B_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl__B_id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl__B_id.Location = new System.Drawing.Point(32, 59);
            this.lbl__B_id.Name = "lbl__B_id";
            this.lbl__B_id.Size = new System.Drawing.Size(30, 25);
            this.lbl__B_id.TabIndex = 43;
            this.lbl__B_id.Text = "ID";
            this.lbl__B_id.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblduedate
            // 
            this.lblduedate.AutoSize = true;
            this.lblduedate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblduedate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblduedate.Location = new System.Drawing.Point(32, 120);
            this.lblduedate.Name = "lblduedate";
            this.lblduedate.Size = new System.Drawing.Size(86, 25);
            this.lblduedate.TabIndex = 48;
            this.lblduedate.Text = "Due Date";
            this.lblduedate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnrtn_refresh
            // 
            this.btnrtn_refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrtn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrtn_refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnrtn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrtn_refresh.Location = new System.Drawing.Point(650, 440);
            this.btnrtn_refresh.Name = "btnrtn_refresh";
            this.btnrtn_refresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnrtn_refresh.Size = new System.Drawing.Size(129, 52);
            this.btnrtn_refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrtn_refresh.TabIndex = 47;
            this.btnrtn_refresh.Text = "REFRESH";
            this.btnrtn_refresh.Click += new System.EventHandler(this.btnrtn_refresh_Click);
            // 
            // btnrtn
            // 
            this.btnrtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnrtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnrtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrtn.Location = new System.Drawing.Point(484, 440);
            this.btnrtn.Name = "btnrtn";
            this.btnrtn.Size = new System.Drawing.Size(129, 52);
            this.btnrtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrtn.TabIndex = 45;
            this.btnrtn.Text = "RETURN";
            this.btnrtn.Click += new System.EventHandler(this.btnrtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnrtn_refresh);
            this.groupBox1.Controls.Add(this.tblrtn);
            this.groupBox1.Controls.Add(this.btnrtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 552);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.return1;
            this.pictureBox1.Location = new System.Drawing.Point(894, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.ret2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // frmreturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 576);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmreturn";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.tblrtn.ResumeLayout(false);
            this.grbrntm.ResumeLayout(false);
            this.grbrntm.PerformLayout();
            this.grbrtnfine.ResumeLayout(false);
            this.grbrtnfine.PerformLayout();
            this.grbrtnbk.ResumeLayout(false);
            this.grbrtnbk.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblrtn;
        private System.Windows.Forms.GroupBox grbrntm;
        private MetroFramework.Controls.MetroLabel lbl_S_id;
        private System.Windows.Forms.GroupBox grbrtnbk;
        private MetroFramework.Controls.MetroLabel lbl__B_id;
        private MetroFramework.Controls.MetroLabel lblduedate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtrtnm_id;
        private DevComponents.DotNetBar.Controls.TextBoxX txtduedate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtrtnbk_id;
        private DevComponents.DotNetBar.ButtonX btnrtn_refresh;
        private DevComponents.DotNetBar.ButtonX btnrtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtrtnm_type;
        private MetroFramework.Controls.MetroLabel lblissu_memtype;
        private System.Windows.Forms.Label lblissudate;
        private System.Windows.Forms.GroupBox grbrtnfine;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblrtn_recpt;
        private MetroFramework.Controls.MetroLabel lblrtn_fine;
        private DevComponents.DotNetBar.ButtonX btnrtn_paid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}