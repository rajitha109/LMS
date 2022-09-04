namespace LibraryManagementSystem
{
    partial class frmissue
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
            this.btnisu_refresh = new DevComponents.DotNetBar.ButtonX();
            this.btnisu = new DevComponents.DotNetBar.ButtonX();
            this.tblisu = new System.Windows.Forms.TableLayoutPanel();
            this.grbisum = new System.Windows.Forms.GroupBox();
            this.txtmem_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmem_contact = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbomem_type = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtisum_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblissu_memtype = new MetroFramework.Controls.MetroLabel();
            this.lbl = new MetroFramework.Controls.MetroLabel();
            this.lblissu_contactNo = new MetroFramework.Controls.MetroLabel();
            this.lblm_name = new System.Windows.Forms.Label();
            this.lbl_S_name = new MetroFramework.Controls.MetroLabel();
            this.lbl_S_id = new MetroFramework.Controls.MetroLabel();
            this.grbisubk = new System.Windows.Forms.GroupBox();
            this.cmbisu_dd = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtisubk_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblisubk_dud = new System.Windows.Forms.Label();
            this.lblisubk_ddc = new System.Windows.Forms.Label();
            this.lblisubk_cat = new System.Windows.Forms.Label();
            this.lblisubk_ttl = new System.Windows.Forms.Label();
            this.lblreturn_date = new MetroFramework.Controls.MetroLabel();
            this.lblissue_date = new MetroFramework.Controls.MetroLabel();
            this.dtpissue = new System.Windows.Forms.DateTimePicker();
            this.lbl__B_id = new MetroFramework.Controls.MetroLabel();
            this.lbl_B_cat = new MetroFramework.Controls.MetroLabel();
            this.lbl_B_ddc = new MetroFramework.Controls.MetroLabel();
            this.lbl_B_ttl = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblisu.SuspendLayout();
            this.grbisum.SuspendLayout();
            this.grbisubk.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnisu_refresh
            // 
            this.btnisu_refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnisu_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnisu_refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnisu_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnisu_refresh.Location = new System.Drawing.Point(656, 437);
            this.btnisu_refresh.Name = "btnisu_refresh";
            this.btnisu_refresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnisu_refresh.Size = new System.Drawing.Size(129, 52);
            this.btnisu_refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnisu_refresh.TabIndex = 47;
            this.btnisu_refresh.Text = "REFRESH";
            this.btnisu_refresh.Click += new System.EventHandler(this.btnisu_refresh_Click);
            // 
            // btnisu
            // 
            this.btnisu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnisu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnisu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnisu.Location = new System.Drawing.Point(468, 437);
            this.btnisu.Name = "btnisu";
            this.btnisu.Size = new System.Drawing.Size(129, 52);
            this.btnisu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnisu.TabIndex = 45;
            this.btnisu.Text = "ISSUE";
            this.btnisu.Click += new System.EventHandler(this.btnisu_Click);
            // 
            // tblisu
            // 
            this.tblisu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblisu.ColumnCount = 2;
            this.tblisu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblisu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 539F));
            this.tblisu.Controls.Add(this.grbisum, 1, 0);
            this.tblisu.Controls.Add(this.grbisubk, 0, 0);
            this.tblisu.Location = new System.Drawing.Point(89, 34);
            this.tblisu.Name = "tblisu";
            this.tblisu.RowCount = 1;
            this.tblisu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblisu.Size = new System.Drawing.Size(1078, 379);
            this.tblisu.TabIndex = 6;
            // 
            // grbisum
            // 
            this.grbisum.Controls.Add(this.txtmem_email);
            this.grbisum.Controls.Add(this.txtmem_contact);
            this.grbisum.Controls.Add(this.cbomem_type);
            this.grbisum.Controls.Add(this.txtisum_id);
            this.grbisum.Controls.Add(this.lblissu_memtype);
            this.grbisum.Controls.Add(this.lbl);
            this.grbisum.Controls.Add(this.lblissu_contactNo);
            this.grbisum.Controls.Add(this.lblm_name);
            this.grbisum.Controls.Add(this.lbl_S_name);
            this.grbisum.Controls.Add(this.lbl_S_id);
            this.grbisum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbisum.Location = new System.Drawing.Point(542, 3);
            this.grbisum.Name = "grbisum";
            this.grbisum.Size = new System.Drawing.Size(533, 372);
            this.grbisum.TabIndex = 1;
            this.grbisum.TabStop = false;
            this.grbisum.Text = "Member";
            // 
            // txtmem_email
            // 
            // 
            // 
            // 
            this.txtmem_email.Border.Class = "TextBoxBorder";
            this.txtmem_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmem_email.Location = new System.Drawing.Point(146, 235);
            this.txtmem_email.Name = "txtmem_email";
            this.txtmem_email.ReadOnly = true;
            this.txtmem_email.Size = new System.Drawing.Size(296, 26);
            this.txtmem_email.TabIndex = 73;
            // 
            // txtmem_contact
            // 
            // 
            // 
            // 
            this.txtmem_contact.Border.Class = "TextBoxBorder";
            this.txtmem_contact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmem_contact.Location = new System.Drawing.Point(146, 190);
            this.txtmem_contact.Name = "txtmem_contact";
            this.txtmem_contact.ReadOnly = true;
            this.txtmem_contact.Size = new System.Drawing.Size(296, 26);
            this.txtmem_contact.TabIndex = 72;
            // 
            // cbomem_type
            // 
            this.cbomem_type.DisplayMember = "Text";
            this.cbomem_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbomem_type.FormattingEnabled = true;
            this.cbomem_type.ItemHeight = 20;
            this.cbomem_type.Location = new System.Drawing.Point(145, 59);
            this.cbomem_type.Name = "cbomem_type";
            this.cbomem_type.Size = new System.Drawing.Size(169, 26);
            this.cbomem_type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbomem_type.TabIndex = 71;
            this.cbomem_type.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomem_type.WatermarkText = "Select Member Type Here";
            this.cbomem_type.TextChanged += new System.EventHandler(this.cbomem_type_TextChanged);
            // 
            // txtisum_id
            // 
            // 
            // 
            // 
            this.txtisum_id.Border.Class = "TextBoxBorder";
            this.txtisum_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtisum_id.Location = new System.Drawing.Point(145, 100);
            this.txtisum_id.Name = "txtisum_id";
            this.txtisum_id.Size = new System.Drawing.Size(296, 26);
            this.txtisum_id.TabIndex = 70;
            this.txtisum_id.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtisum_id.WatermarkText = "Enter Member ID Here";
            this.txtisum_id.TextChanged += new System.EventHandler(this.txtisum_id_TextChanged);
            // 
            // lblissu_memtype
            // 
            this.lblissu_memtype.AutoSize = true;
            this.lblissu_memtype.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblissu_memtype.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblissu_memtype.Location = new System.Drawing.Point(9, 59);
            this.lblissu_memtype.Name = "lblissu_memtype";
            this.lblissu_memtype.Size = new System.Drawing.Size(122, 25);
            this.lblissu_memtype.TabIndex = 65;
            this.lblissu_memtype.Text = "Member Type";
            this.lblissu_memtype.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl.Location = new System.Drawing.Point(9, 236);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(54, 25);
            this.lbl.TabIndex = 64;
            this.lbl.Text = "Email";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblissu_contactNo
            // 
            this.lblissu_contactNo.AutoSize = true;
            this.lblissu_contactNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblissu_contactNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblissu_contactNo.Location = new System.Drawing.Point(9, 190);
            this.lblissu_contactNo.Name = "lblissu_contactNo";
            this.lblissu_contactNo.Size = new System.Drawing.Size(102, 25);
            this.lblissu_contactNo.TabIndex = 63;
            this.lblissu_contactNo.Text = "Contact No";
            this.lblissu_contactNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblm_name
            // 
            this.lblm_name.AutoSize = true;
            this.lblm_name.Location = new System.Drawing.Point(142, 157);
            this.lblm_name.Name = "lblm_name";
            this.lblm_name.Size = new System.Drawing.Size(51, 20);
            this.lblm_name.TabIndex = 62;
            this.lblm_name.Text = "Name";
            // 
            // lbl_S_name
            // 
            this.lbl_S_name.AutoSize = true;
            this.lbl_S_name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_S_name.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_S_name.Location = new System.Drawing.Point(9, 157);
            this.lbl_S_name.Name = "lbl_S_name";
            this.lbl_S_name.Size = new System.Drawing.Size(59, 25);
            this.lbl_S_name.TabIndex = 15;
            this.lbl_S_name.Text = "Name";
            this.lbl_S_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_S_id
            // 
            this.lbl_S_id.AutoSize = true;
            this.lbl_S_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_S_id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_S_id.Location = new System.Drawing.Point(8, 101);
            this.lbl_S_id.Name = "lbl_S_id";
            this.lbl_S_id.Size = new System.Drawing.Size(30, 25);
            this.lbl_S_id.TabIndex = 14;
            this.lbl_S_id.Text = "ID";
            this.lbl_S_id.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grbisubk
            // 
            this.grbisubk.Controls.Add(this.cmbisu_dd);
            this.grbisubk.Controls.Add(this.txtisubk_id);
            this.grbisubk.Controls.Add(this.lblisubk_dud);
            this.grbisubk.Controls.Add(this.lblisubk_ddc);
            this.grbisubk.Controls.Add(this.lblisubk_cat);
            this.grbisubk.Controls.Add(this.lblisubk_ttl);
            this.grbisubk.Controls.Add(this.lblreturn_date);
            this.grbisubk.Controls.Add(this.lblissue_date);
            this.grbisubk.Controls.Add(this.dtpissue);
            this.grbisubk.Controls.Add(this.lbl__B_id);
            this.grbisubk.Controls.Add(this.lbl_B_cat);
            this.grbisubk.Controls.Add(this.lbl_B_ddc);
            this.grbisubk.Controls.Add(this.lbl_B_ttl);
            this.grbisubk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbisubk.Location = new System.Drawing.Point(3, 3);
            this.grbisubk.Name = "grbisubk";
            this.grbisubk.Size = new System.Drawing.Size(532, 372);
            this.grbisubk.TabIndex = 0;
            this.grbisubk.TabStop = false;
            this.grbisubk.Text = "Book";
            // 
            // cmbisu_dd
            // 
            this.cmbisu_dd.DisplayMember = "Text";
            this.cmbisu_dd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbisu_dd.FormattingEnabled = true;
            this.cmbisu_dd.ItemHeight = 20;
            this.cmbisu_dd.Location = new System.Drawing.Point(271, 290);
            this.cmbisu_dd.Name = "cmbisu_dd";
            this.cmbisu_dd.Size = new System.Drawing.Size(121, 26);
            this.cmbisu_dd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbisu_dd.TabIndex = 69;
            this.cmbisu_dd.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbisu_dd.WatermarkText = "Select ";
            this.cmbisu_dd.SelectedIndexChanged += new System.EventHandler(this.cmbisu_dd_SelectedIndexChanged);
            // 
            // txtisubk_id
            // 
            // 
            // 
            // 
            this.txtisubk_id.Border.Class = "TextBoxBorder";
            this.txtisubk_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtisubk_id.Location = new System.Drawing.Point(143, 61);
            this.txtisubk_id.Name = "txtisubk_id";
            this.txtisubk_id.Size = new System.Drawing.Size(249, 26);
            this.txtisubk_id.TabIndex = 68;
            this.txtisubk_id.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtisubk_id.WatermarkText = "Enter Book ID Here";
            this.txtisubk_id.TextChanged += new System.EventHandler(this.txtisubk_id_TextChanged);
            // 
            // lblisubk_dud
            // 
            this.lblisubk_dud.AutoSize = true;
            this.lblisubk_dud.Location = new System.Drawing.Point(139, 295);
            this.lblisubk_dud.Name = "lblisubk_dud";
            this.lblisubk_dud.Size = new System.Drawing.Size(44, 20);
            this.lblisubk_dud.TabIndex = 60;
            this.lblisubk_dud.Text = "Date";
            // 
            // lblisubk_ddc
            // 
            this.lblisubk_ddc.AutoSize = true;
            this.lblisubk_ddc.Location = new System.Drawing.Point(139, 190);
            this.lblisubk_ddc.Name = "lblisubk_ddc";
            this.lblisubk_ddc.Size = new System.Drawing.Size(44, 20);
            this.lblisubk_ddc.TabIndex = 59;
            this.lblisubk_ddc.Text = "DDC";
            // 
            // lblisubk_cat
            // 
            this.lblisubk_cat.AutoSize = true;
            this.lblisubk_cat.Location = new System.Drawing.Point(139, 148);
            this.lblisubk_cat.Name = "lblisubk_cat";
            this.lblisubk_cat.Size = new System.Drawing.Size(73, 20);
            this.lblisubk_cat.TabIndex = 58;
            this.lblisubk_cat.Text = "Category";
            // 
            // lblisubk_ttl
            // 
            this.lblisubk_ttl.AutoSize = true;
            this.lblisubk_ttl.Location = new System.Drawing.Point(139, 109);
            this.lblisubk_ttl.Name = "lblisubk_ttl";
            this.lblisubk_ttl.Size = new System.Drawing.Size(38, 20);
            this.lblisubk_ttl.TabIndex = 57;
            this.lblisubk_ttl.Text = "Title";
            // 
            // lblreturn_date
            // 
            this.lblreturn_date.AutoSize = true;
            this.lblreturn_date.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblreturn_date.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblreturn_date.Location = new System.Drawing.Point(6, 290);
            this.lblreturn_date.Name = "lblreturn_date";
            this.lblreturn_date.Size = new System.Drawing.Size(86, 25);
            this.lblreturn_date.TabIndex = 54;
            this.lblreturn_date.Text = "Due Date";
            this.lblreturn_date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblissue_date
            // 
            this.lblissue_date.AutoSize = true;
            this.lblissue_date.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblissue_date.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblissue_date.Location = new System.Drawing.Point(6, 236);
            this.lblissue_date.Name = "lblissue_date";
            this.lblissue_date.Size = new System.Drawing.Size(92, 25);
            this.lblissue_date.TabIndex = 53;
            this.lblissue_date.Text = "Issue date";
            this.lblissue_date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpissue
            // 
            this.dtpissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpissue.Location = new System.Drawing.Point(143, 236);
            this.dtpissue.Margin = new System.Windows.Forms.Padding(2);
            this.dtpissue.Name = "dtpissue";
            this.dtpissue.Size = new System.Drawing.Size(249, 23);
            this.dtpissue.TabIndex = 51;
            this.dtpissue.Value = new System.DateTime(2016, 9, 4, 0, 0, 0, 0);
            // 
            // lbl__B_id
            // 
            this.lbl__B_id.AutoSize = true;
            this.lbl__B_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl__B_id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl__B_id.Location = new System.Drawing.Point(6, 59);
            this.lbl__B_id.Name = "lbl__B_id";
            this.lbl__B_id.Size = new System.Drawing.Size(30, 25);
            this.lbl__B_id.TabIndex = 43;
            this.lbl__B_id.Text = "ID";
            this.lbl__B_id.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_B_cat
            // 
            this.lbl_B_cat.AutoSize = true;
            this.lbl_B_cat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_B_cat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_B_cat.Location = new System.Drawing.Point(6, 143);
            this.lbl_B_cat.Name = "lbl_B_cat";
            this.lbl_B_cat.Size = new System.Drawing.Size(84, 25);
            this.lbl_B_cat.TabIndex = 44;
            this.lbl_B_cat.Text = "Category";
            this.lbl_B_cat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_B_ddc
            // 
            this.lbl_B_ddc.AutoSize = true;
            this.lbl_B_ddc.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_B_ddc.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_B_ddc.Location = new System.Drawing.Point(6, 185);
            this.lbl_B_ddc.Name = "lbl_B_ddc";
            this.lbl_B_ddc.Size = new System.Drawing.Size(81, 25);
            this.lbl_B_ddc.TabIndex = 48;
            this.lbl_B_ddc.Text = "DDC NO";
            this.lbl_B_ddc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_B_ttl
            // 
            this.lbl_B_ttl.AutoSize = true;
            this.lbl_B_ttl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_B_ttl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_B_ttl.Location = new System.Drawing.Point(6, 101);
            this.lbl_B_ttl.Name = "lbl_B_ttl";
            this.lbl_B_ttl.Size = new System.Drawing.Size(44, 25);
            this.lbl_B_ttl.TabIndex = 45;
            this.lbl_B_ttl.Text = "Title";
            this.lbl_B_ttl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnisu_refresh);
            this.groupBox1.Controls.Add(this.tblisu);
            this.groupBox1.Controls.Add(this.btnisu);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 552);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.issue1;
            this.pictureBox2.Location = new System.Drawing.Point(-27, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 254);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.issued2;
            this.pictureBox1.Location = new System.Drawing.Point(1056, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // frmissue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 576);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmissue";
            this.Text = "Issue";
            this.Load += new System.EventHandler(this.Issue_Load);
            this.tblisu.ResumeLayout(false);
            this.grbisum.ResumeLayout(false);
            this.grbisum.PerformLayout();
            this.grbisubk.ResumeLayout(false);
            this.grbisubk.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnisu_refresh;
        private DevComponents.DotNetBar.ButtonX btnisu;
        private System.Windows.Forms.TableLayoutPanel tblisu;
        private System.Windows.Forms.GroupBox grbisum;
        private MetroFramework.Controls.MetroLabel lblissu_memtype;
        private MetroFramework.Controls.MetroLabel lbl;
        private MetroFramework.Controls.MetroLabel lblissu_contactNo;
        private System.Windows.Forms.Label lblm_name;
        private MetroFramework.Controls.MetroLabel lbl_S_name;
        private MetroFramework.Controls.MetroLabel lbl_S_id;
        private System.Windows.Forms.GroupBox grbisubk;
        private System.Windows.Forms.Label lblisubk_dud;
        private System.Windows.Forms.Label lblisubk_ddc;
        private System.Windows.Forms.Label lblisubk_cat;
        private System.Windows.Forms.Label lblisubk_ttl;
        private MetroFramework.Controls.MetroLabel lblreturn_date;
        private MetroFramework.Controls.MetroLabel lblissue_date;
        private System.Windows.Forms.DateTimePicker dtpissue;
        private MetroFramework.Controls.MetroLabel lbl__B_id;
        private MetroFramework.Controls.MetroLabel lbl_B_cat;
        private MetroFramework.Controls.MetroLabel lbl_B_ddc;
        private MetroFramework.Controls.MetroLabel lbl_B_ttl;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmem_email;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmem_contact;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbomem_type;
        private DevComponents.DotNetBar.Controls.TextBoxX txtisum_id;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbisu_dd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtisubk_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}