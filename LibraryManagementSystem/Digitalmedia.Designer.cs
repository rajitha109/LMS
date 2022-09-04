namespace LibraryManagementSystem
{
    partial class frmdigital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdigital));
            this.txtdg_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_dg_other = new MetroFramework.Controls.MetroLabel();
            this.lbl_dg_vol = new MetroFramework.Controls.MetroLabel();
            this.lbldg_src = new MetroFramework.Controls.MetroLabel();
            this.txt_dg_price = new MetroFramework.Controls.MetroLabel();
            this.lbl_dg_cat = new MetroFramework.Controls.MetroLabel();
            this.lbl_dg_auth = new MetroFramework.Controls.MetroLabel();
            this.lbl_dg_ttl = new MetroFramework.Controls.MetroLabel();
            this.lbl_dgid = new MetroFramework.Controls.MetroLabel();
            this.grp_dg = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstar = new System.Windows.Forms.Label();
            this.btndg_ref = new DevComponents.DotNetBar.ButtonX();
            this.btndg_del = new DevComponents.DotNetBar.ButtonX();
            this.btn_dg_update = new DevComponents.DotNetBar.ButtonX();
            this.btndg_save = new DevComponents.DotNetBar.ButtonX();
            this.txtdg_oth = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdg_cat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdg_auth = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdg_ttl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdg_vol = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdg_src = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdg_prc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblumode = new System.Windows.Forms.Label();
            this.grp_dg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdg_id
            // 
            // 
            // 
            // 
            this.txtdg_id.Border.Class = "TextBoxBorder";
            this.txtdg_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdg_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_id.Location = new System.Drawing.Point(204, 84);
            this.txtdg_id.Margin = new System.Windows.Forms.Padding(2);
            this.txtdg_id.Name = "txtdg_id";
            this.txtdg_id.Size = new System.Drawing.Size(348, 26);
            this.txtdg_id.TabIndex = 40;
            this.txtdg_id.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtdg_id.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_id.WatermarkText = "Enter Digital Media ID Here";
            this.txtdg_id.TextChanged += new System.EventHandler(this.txtdg_id_TextChanged);
            // 
            // lbl_dg_other
            // 
            this.lbl_dg_other.AutoSize = true;
            this.lbl_dg_other.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_dg_other.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dg_other.Location = new System.Drawing.Point(585, 225);
            this.lbl_dg_other.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dg_other.Name = "lbl_dg_other";
            this.lbl_dg_other.Size = new System.Drawing.Size(115, 25);
            this.lbl_dg_other.TabIndex = 39;
            this.lbl_dg_other.Text = "Other Details";
            // 
            // lbl_dg_vol
            // 
            this.lbl_dg_vol.AutoSize = true;
            this.lbl_dg_vol.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_dg_vol.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dg_vol.Location = new System.Drawing.Point(585, 177);
            this.lbl_dg_vol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dg_vol.Name = "lbl_dg_vol";
            this.lbl_dg_vol.Size = new System.Drawing.Size(73, 25);
            this.lbl_dg_vol.TabIndex = 38;
            this.lbl_dg_vol.Text = "Volume";
            // 
            // lbldg_src
            // 
            this.lbldg_src.AutoSize = true;
            this.lbldg_src.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbldg_src.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbldg_src.Location = new System.Drawing.Point(585, 131);
            this.lbldg_src.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldg_src.Name = "lbldg_src";
            this.lbldg_src.Size = new System.Drawing.Size(66, 25);
            this.lbldg_src.TabIndex = 37;
            this.lbldg_src.Text = "Source";
            // 
            // txt_dg_price
            // 
            this.txt_dg_price.AutoSize = true;
            this.txt_dg_price.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txt_dg_price.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txt_dg_price.Location = new System.Drawing.Point(585, 87);
            this.txt_dg_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_dg_price.Name = "txt_dg_price";
            this.txt_dg_price.Size = new System.Drawing.Size(49, 25);
            this.txt_dg_price.TabIndex = 36;
            this.txt_dg_price.Text = "Price";
            // 
            // lbl_dg_cat
            // 
            this.lbl_dg_cat.AutoSize = true;
            this.lbl_dg_cat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_dg_cat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dg_cat.Location = new System.Drawing.Point(100, 223);
            this.lbl_dg_cat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dg_cat.Name = "lbl_dg_cat";
            this.lbl_dg_cat.Size = new System.Drawing.Size(84, 25);
            this.lbl_dg_cat.TabIndex = 35;
            this.lbl_dg_cat.Text = "Category";
            // 
            // lbl_dg_auth
            // 
            this.lbl_dg_auth.AutoSize = true;
            this.lbl_dg_auth.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_dg_auth.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dg_auth.Location = new System.Drawing.Point(100, 172);
            this.lbl_dg_auth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dg_auth.Name = "lbl_dg_auth";
            this.lbl_dg_auth.Size = new System.Drawing.Size(67, 25);
            this.lbl_dg_auth.TabIndex = 34;
            this.lbl_dg_auth.Text = "Author";
            // 
            // lbl_dg_ttl
            // 
            this.lbl_dg_ttl.AutoSize = true;
            this.lbl_dg_ttl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_dg_ttl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dg_ttl.Location = new System.Drawing.Point(100, 129);
            this.lbl_dg_ttl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dg_ttl.Name = "lbl_dg_ttl";
            this.lbl_dg_ttl.Size = new System.Drawing.Size(44, 25);
            this.lbl_dg_ttl.TabIndex = 33;
            this.lbl_dg_ttl.Text = "Title";
            // 
            // lbl_dgid
            // 
            this.lbl_dgid.AutoSize = true;
            this.lbl_dgid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_dgid.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dgid.Location = new System.Drawing.Point(100, 85);
            this.lbl_dgid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dgid.Name = "lbl_dgid";
            this.lbl_dgid.Size = new System.Drawing.Size(30, 25);
            this.lbl_dgid.TabIndex = 32;
            this.lbl_dgid.Text = "ID";
            // 
            // grp_dg
            // 
            this.grp_dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_dg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_dg.Controls.Add(this.label3);
            this.grp_dg.Controls.Add(this.label2);
            this.grp_dg.Controls.Add(this.label1);
            this.grp_dg.Controls.Add(this.lblstar);
            this.grp_dg.Controls.Add(this.btndg_ref);
            this.grp_dg.Controls.Add(this.btndg_del);
            this.grp_dg.Controls.Add(this.btn_dg_update);
            this.grp_dg.Controls.Add(this.btndg_save);
            this.grp_dg.Controls.Add(this.txtdg_oth);
            this.grp_dg.Controls.Add(this.txtdg_cat);
            this.grp_dg.Controls.Add(this.txtdg_auth);
            this.grp_dg.Controls.Add(this.txtdg_ttl);
            this.grp_dg.Controls.Add(this.txtdg_vol);
            this.grp_dg.Controls.Add(this.txtdg_src);
            this.grp_dg.Controls.Add(this.txtdg_prc);
            this.grp_dg.Controls.Add(this.txtdg_id);
            this.grp_dg.Controls.Add(this.lbl_dg_other);
            this.grp_dg.Controls.Add(this.lbl_dg_vol);
            this.grp_dg.Controls.Add(this.lbldg_src);
            this.grp_dg.Controls.Add(this.txt_dg_price);
            this.grp_dg.Controls.Add(this.lbl_dg_cat);
            this.grp_dg.Controls.Add(this.lbl_dg_auth);
            this.grp_dg.Controls.Add(this.lbl_dg_ttl);
            this.grp_dg.Controls.Add(this.lbl_dgid);
            this.grp_dg.Controls.Add(this.pictureBox1);
            this.grp_dg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dg.Location = new System.Drawing.Point(11, 11);
            this.grp_dg.Margin = new System.Windows.Forms.Padding(2);
            this.grp_dg.Name = "grp_dg";
            this.grp_dg.Padding = new System.Windows.Forms.Padding(2);
            this.grp_dg.Size = new System.Drawing.Size(1270, 554);
            this.grp_dg.TabIndex = 8;
            this.grp_dg.TabStop = false;
            this.grp_dg.Text = "Digital Media Registration";
            this.grp_dg.Enter += new System.EventHandler(this.grp_dg_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(557, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(557, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(557, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "*";
            // 
            // lblstar
            // 
            this.lblstar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblstar.AutoSize = true;
            this.lblstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstar.ForeColor = System.Drawing.Color.Red;
            this.lblstar.Location = new System.Drawing.Point(199, 262);
            this.lblstar.Name = "lblstar";
            this.lblstar.Size = new System.Drawing.Size(123, 20);
            this.lblstar.TabIndex = 91;
            this.lblstar.Text = "Must Fill * Fields";
            // 
            // btndg_ref
            // 
            this.btndg_ref.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndg_ref.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndg_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndg_ref.Location = new System.Drawing.Point(423, 348);
            this.btndg_ref.Name = "btndg_ref";
            this.btndg_ref.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btndg_ref.Size = new System.Drawing.Size(129, 52);
            this.btndg_ref.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndg_ref.TabIndex = 89;
            this.btndg_ref.Text = "REFRESH";
            this.btndg_ref.Click += new System.EventHandler(this.btndg_ref_Click);
            // 
            // btndg_del
            // 
            this.btndg_del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndg_del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndg_del.Enabled = false;
            this.btndg_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndg_del.Location = new System.Drawing.Point(719, 348);
            this.btndg_del.Name = "btndg_del";
            this.btndg_del.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btndg_del.Size = new System.Drawing.Size(129, 52);
            this.btndg_del.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndg_del.TabIndex = 88;
            this.btndg_del.Text = "DELETE";
            this.btndg_del.Click += new System.EventHandler(this.btndg_del_Click);
            // 
            // btn_dg_update
            // 
            this.btn_dg_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dg_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dg_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dg_update.Location = new System.Drawing.Point(571, 348);
            this.btn_dg_update.Name = "btn_dg_update";
            this.btn_dg_update.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlEnter);
            this.btn_dg_update.Size = new System.Drawing.Size(129, 52);
            this.btn_dg_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dg_update.TabIndex = 87;
            this.btn_dg_update.Text = "UPDATE";
            this.btn_dg_update.Click += new System.EventHandler(this.btn_dg_update_Click);
            // 
            // btndg_save
            // 
            this.btndg_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndg_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndg_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndg_save.Location = new System.Drawing.Point(276, 348);
            this.btndg_save.Name = "btndg_save";
            this.btndg_save.Size = new System.Drawing.Size(129, 52);
            this.btndg_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndg_save.TabIndex = 86;
            this.btndg_save.Text = "SAVE";
            this.btndg_save.Click += new System.EventHandler(this.btndg_save_Click);
            // 
            // txtdg_oth
            // 
            // 
            // 
            // 
            this.txtdg_oth.Border.Class = "TextBoxBorder";
            this.txtdg_oth.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdg_oth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_oth.Location = new System.Drawing.Point(700, 225);
            this.txtdg_oth.Margin = new System.Windows.Forms.Padding(2);
            this.txtdg_oth.Multiline = true;
            this.txtdg_oth.Name = "txtdg_oth";
            this.txtdg_oth.Size = new System.Drawing.Size(348, 71);
            this.txtdg_oth.TabIndex = 40;
            this.txtdg_oth.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtdg_oth.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_oth.WatermarkText = "Enter Details Here";
            // 
            // txtdg_cat
            // 
            // 
            // 
            // 
            this.txtdg_cat.Border.Class = "TextBoxBorder";
            this.txtdg_cat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdg_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_cat.Location = new System.Drawing.Point(204, 224);
            this.txtdg_cat.Margin = new System.Windows.Forms.Padding(2);
            this.txtdg_cat.Name = "txtdg_cat";
            this.txtdg_cat.Size = new System.Drawing.Size(348, 26);
            this.txtdg_cat.TabIndex = 40;
            this.txtdg_cat.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtdg_cat.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_cat.WatermarkText = "Enter Category Here";
            // 
            // txtdg_auth
            // 
            // 
            // 
            // 
            this.txtdg_auth.Border.Class = "TextBoxBorder";
            this.txtdg_auth.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdg_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_auth.Location = new System.Drawing.Point(204, 171);
            this.txtdg_auth.Margin = new System.Windows.Forms.Padding(2);
            this.txtdg_auth.Name = "txtdg_auth";
            this.txtdg_auth.Size = new System.Drawing.Size(348, 26);
            this.txtdg_auth.TabIndex = 40;
            this.txtdg_auth.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtdg_auth.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_auth.WatermarkText = "Enter Author Here";
            // 
            // txtdg_ttl
            // 
            // 
            // 
            // 
            this.txtdg_ttl.Border.Class = "TextBoxBorder";
            this.txtdg_ttl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdg_ttl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_ttl.Location = new System.Drawing.Point(204, 128);
            this.txtdg_ttl.Margin = new System.Windows.Forms.Padding(2);
            this.txtdg_ttl.Name = "txtdg_ttl";
            this.txtdg_ttl.Size = new System.Drawing.Size(348, 26);
            this.txtdg_ttl.TabIndex = 40;
            this.txtdg_ttl.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtdg_ttl.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_ttl.WatermarkText = "Enter Title Here";
            // 
            // txtdg_vol
            // 
            // 
            // 
            // 
            this.txtdg_vol.Border.Class = "TextBoxBorder";
            this.txtdg_vol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdg_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_vol.Location = new System.Drawing.Point(700, 179);
            this.txtdg_vol.Margin = new System.Windows.Forms.Padding(2);
            this.txtdg_vol.Name = "txtdg_vol";
            this.txtdg_vol.Size = new System.Drawing.Size(176, 26);
            this.txtdg_vol.TabIndex = 40;
            this.txtdg_vol.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtdg_vol.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_vol.WatermarkText = "Enter Volume No Here";
            // 
            // txtdg_src
            // 
            // 
            // 
            // 
            this.txtdg_src.Border.Class = "TextBoxBorder";
            this.txtdg_src.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdg_src.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_src.Location = new System.Drawing.Point(700, 131);
            this.txtdg_src.Margin = new System.Windows.Forms.Padding(2);
            this.txtdg_src.Name = "txtdg_src";
            this.txtdg_src.Size = new System.Drawing.Size(348, 26);
            this.txtdg_src.TabIndex = 40;
            this.txtdg_src.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtdg_src.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_src.WatermarkText = "Enter Source Name Here";
            // 
            // txtdg_prc
            // 
            // 
            // 
            // 
            this.txtdg_prc.Border.Class = "TextBoxBorder";
            this.txtdg_prc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdg_prc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_prc.Location = new System.Drawing.Point(700, 87);
            this.txtdg_prc.Margin = new System.Windows.Forms.Padding(2);
            this.txtdg_prc.Name = "txtdg_prc";
            this.txtdg_prc.Size = new System.Drawing.Size(348, 26);
            this.txtdg_prc.TabIndex = 40;
            this.txtdg_prc.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtdg_prc.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg_prc.WatermarkText = "Enter Price Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(838, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 641);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblumode
            // 
            this.lblumode.AutoSize = true;
            this.lblumode.Location = new System.Drawing.Point(80, 95);
            this.lblumode.Name = "lblumode";
            this.lblumode.Size = new System.Drawing.Size(35, 13);
            this.lblumode.TabIndex = 9;
            this.lblumode.Text = "label1";
            this.lblumode.Visible = false;
            // 
            // frmdigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 576);
            this.Controls.Add(this.grp_dg);
            this.Controls.Add(this.lblumode);
            this.Name = "frmdigital";
            this.Text = "Digital_Media";
            this.Load += new System.EventHandler(this.frmdigital_Load_1);
            this.grp_dg.ResumeLayout(false);
            this.grp_dg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtdg_id;
        private MetroFramework.Controls.MetroLabel lbl_dg_other;
        private MetroFramework.Controls.MetroLabel lbl_dg_vol;
        private MetroFramework.Controls.MetroLabel lbldg_src;
        private MetroFramework.Controls.MetroLabel txt_dg_price;
        private MetroFramework.Controls.MetroLabel lbl_dg_cat;
        private MetroFramework.Controls.MetroLabel lbl_dg_auth;
        private MetroFramework.Controls.MetroLabel lbl_dg_ttl;
        private MetroFramework.Controls.MetroLabel lbl_dgid;
        private System.Windows.Forms.GroupBox grp_dg;
        private System.Windows.Forms.Label lblumode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btndg_ref;
        private DevComponents.DotNetBar.ButtonX btndg_del;
        private DevComponents.DotNetBar.ButtonX btn_dg_update;
        private DevComponents.DotNetBar.ButtonX btndg_save;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdg_oth;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdg_ttl;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdg_auth;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdg_cat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdg_prc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdg_vol;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdg_src;
        private System.Windows.Forms.Label lblstar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}