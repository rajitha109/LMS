namespace LibraryManagementSystem
{
    partial class frmmagzine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstar = new System.Windows.Forms.Label();
            this.btnmag_ref = new DevComponents.DotNetBar.ButtonX();
            this.btnmag_del = new DevComponents.DotNetBar.ButtonX();
            this.btnmag_update = new DevComponents.DotNetBar.ButtonX();
            this.btnmag_save = new DevComponents.DotNetBar.ButtonX();
            this.txt_mag_art = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_mag_price = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_mag_vol = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_mag_cat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_mag_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_mag_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chk_mag_ach = new System.Windows.Forms.CheckBox();
            this.lbl_mag_article = new MetroFramework.Controls.MetroLabel();
            this.lbl_mag_cost = new MetroFramework.Controls.MetroLabel();
            this.lbl_mag_vol = new MetroFramework.Controls.MetroLabel();
            this.lbl_mag_cat = new MetroFramework.Controls.MetroLabel();
            this.lbl_mag_name = new MetroFramework.Controls.MetroLabel();
            this.lbl_mag_id = new MetroFramework.Controls.MetroLabel();
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblstar);
            this.groupBox1.Controls.Add(this.btnmag_ref);
            this.groupBox1.Controls.Add(this.btnmag_del);
            this.groupBox1.Controls.Add(this.btnmag_update);
            this.groupBox1.Controls.Add(this.btnmag_save);
            this.groupBox1.Controls.Add(this.txt_mag_art);
            this.groupBox1.Controls.Add(this.txt_mag_price);
            this.groupBox1.Controls.Add(this.txt_mag_vol);
            this.groupBox1.Controls.Add(this.txt_mag_cat);
            this.groupBox1.Controls.Add(this.txt_mag_name);
            this.groupBox1.Controls.Add(this.txt_mag_id);
            this.groupBox1.Controls.Add(this.chk_mag_ach);
            this.groupBox1.Controls.Add(this.lbl_mag_article);
            this.groupBox1.Controls.Add(this.lbl_mag_cost);
            this.groupBox1.Controls.Add(this.lbl_mag_vol);
            this.groupBox1.Controls.Add(this.lbl_mag_cat);
            this.groupBox1.Controls.Add(this.lbl_mag_name);
            this.groupBox1.Controls.Add(this.lbl_mag_id);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1270, 554);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magazine Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(537, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(537, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "*";
            // 
            // lblstar
            // 
            this.lblstar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblstar.AutoSize = true;
            this.lblstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstar.ForeColor = System.Drawing.Color.Red;
            this.lblstar.Location = new System.Drawing.Point(285, 282);
            this.lblstar.Name = "lblstar";
            this.lblstar.Size = new System.Drawing.Size(123, 20);
            this.lblstar.TabIndex = 92;
            this.lblstar.Text = "Must Fill * Fields";
            // 
            // btnmag_ref
            // 
            this.btnmag_ref.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmag_ref.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmag_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmag_ref.Location = new System.Drawing.Point(651, 340);
            this.btnmag_ref.Name = "btnmag_ref";
            this.btnmag_ref.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnmag_ref.Size = new System.Drawing.Size(129, 52);
            this.btnmag_ref.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmag_ref.TabIndex = 64;
            this.btnmag_ref.Text = "REFRESH";
            this.btnmag_ref.Click += new System.EventHandler(this.btnmag_ref_Click);
            // 
            // btnmag_del
            // 
            this.btnmag_del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmag_del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmag_del.Enabled = false;
            this.btnmag_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmag_del.Location = new System.Drawing.Point(517, 340);
            this.btnmag_del.Name = "btnmag_del";
            this.btnmag_del.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnmag_del.Size = new System.Drawing.Size(129, 52);
            this.btnmag_del.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmag_del.TabIndex = 65;
            this.btnmag_del.Text = "DELETE";
            this.btnmag_del.Click += new System.EventHandler(this.btnmag_del_Click);
            // 
            // btnmag_update
            // 
            this.btnmag_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmag_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmag_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmag_update.Location = new System.Drawing.Point(382, 340);
            this.btnmag_update.Name = "btnmag_update";
            this.btnmag_update.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlEnter);
            this.btnmag_update.Size = new System.Drawing.Size(129, 52);
            this.btnmag_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmag_update.TabIndex = 66;
            this.btnmag_update.Text = "UPDATE";
            this.btnmag_update.Click += new System.EventHandler(this.btnmag_update_Click);
            // 
            // btnmag_save
            // 
            this.btnmag_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmag_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmag_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmag_save.Location = new System.Drawing.Point(247, 340);
            this.btnmag_save.Name = "btnmag_save";
            this.btnmag_save.Size = new System.Drawing.Size(129, 52);
            this.btnmag_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmag_save.TabIndex = 67;
            this.btnmag_save.Text = "SAVE";
            this.btnmag_save.Click += new System.EventHandler(this.btnmag_save_Click);
            // 
            // txt_mag_art
            // 
            // 
            // 
            // 
            this.txt_mag_art.Border.Class = "TextBoxBorder";
            this.txt_mag_art.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_mag_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_art.Location = new System.Drawing.Point(750, 205);
            this.txt_mag_art.Multiline = true;
            this.txt_mag_art.Name = "txt_mag_art";
            this.txt_mag_art.Size = new System.Drawing.Size(188, 68);
            this.txt_mag_art.TabIndex = 62;
            this.txt_mag_art.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txt_mag_art.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_art.WatermarkText = "Enter Article  List Here";
            // 
            // txt_mag_price
            // 
            // 
            // 
            // 
            this.txt_mag_price.Border.Class = "TextBoxBorder";
            this.txt_mag_price.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_mag_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_price.Location = new System.Drawing.Point(750, 160);
            this.txt_mag_price.Name = "txt_mag_price";
            this.txt_mag_price.Size = new System.Drawing.Size(188, 26);
            this.txt_mag_price.TabIndex = 61;
            this.txt_mag_price.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txt_mag_price.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_price.WatermarkText = "Enter Magazine Price Here";
            // 
            // txt_mag_vol
            // 
            // 
            // 
            // 
            this.txt_mag_vol.Border.Class = "TextBoxBorder";
            this.txt_mag_vol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_mag_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_vol.Location = new System.Drawing.Point(289, 250);
            this.txt_mag_vol.Name = "txt_mag_vol";
            this.txt_mag_vol.Size = new System.Drawing.Size(242, 26);
            this.txt_mag_vol.TabIndex = 60;
            this.txt_mag_vol.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txt_mag_vol.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_vol.WatermarkText = "Enter Magazine Volume No Here";
            // 
            // txt_mag_cat
            // 
            // 
            // 
            // 
            this.txt_mag_cat.Border.Class = "TextBoxBorder";
            this.txt_mag_cat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_mag_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_cat.Location = new System.Drawing.Point(289, 203);
            this.txt_mag_cat.Name = "txt_mag_cat";
            this.txt_mag_cat.Size = new System.Drawing.Size(242, 26);
            this.txt_mag_cat.TabIndex = 59;
            this.txt_mag_cat.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txt_mag_cat.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_cat.WatermarkText = "Enter Magazine Category Here";
            // 
            // txt_mag_name
            // 
            // 
            // 
            // 
            this.txt_mag_name.Border.Class = "TextBoxBorder";
            this.txt_mag_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_mag_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_name.Location = new System.Drawing.Point(289, 162);
            this.txt_mag_name.Name = "txt_mag_name";
            this.txt_mag_name.Size = new System.Drawing.Size(242, 26);
            this.txt_mag_name.TabIndex = 58;
            this.txt_mag_name.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txt_mag_name.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_name.WatermarkText = "Enter Magazine Name Here";
            // 
            // txt_mag_id
            // 
            // 
            // 
            // 
            this.txt_mag_id.Border.Class = "TextBoxBorder";
            this.txt_mag_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_mag_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_id.Location = new System.Drawing.Point(289, 116);
            this.txt_mag_id.Name = "txt_mag_id";
            this.txt_mag_id.Size = new System.Drawing.Size(242, 26);
            this.txt_mag_id.TabIndex = 57;
            this.txt_mag_id.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txt_mag_id.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mag_id.WatermarkText = "Enter Magazine ID Here";
            this.txt_mag_id.TextChanged += new System.EventHandler(this.txt_mag_id_TextChanged);
            // 
            // chk_mag_ach
            // 
            this.chk_mag_ach.AutoSize = true;
            this.chk_mag_ach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mag_ach.Location = new System.Drawing.Point(643, 116);
            this.chk_mag_ach.Margin = new System.Windows.Forms.Padding(2);
            this.chk_mag_ach.Name = "chk_mag_ach";
            this.chk_mag_ach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_mag_ach.Size = new System.Drawing.Size(138, 24);
            this.chk_mag_ach.TabIndex = 26;
            this.chk_mag_ach.Text = "   With CD/DVD";
            this.chk_mag_ach.UseVisualStyleBackColor = true;
            // 
            // lbl_mag_article
            // 
            this.lbl_mag_article.AutoSize = true;
            this.lbl_mag_article.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mag_article.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_mag_article.Location = new System.Drawing.Point(643, 203);
            this.lbl_mag_article.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mag_article.Name = "lbl_mag_article";
            this.lbl_mag_article.Size = new System.Drawing.Size(92, 25);
            this.lbl_mag_article.TabIndex = 20;
            this.lbl_mag_article.Text = "Article List";
            // 
            // lbl_mag_cost
            // 
            this.lbl_mag_cost.AutoSize = true;
            this.lbl_mag_cost.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mag_cost.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_mag_cost.Location = new System.Drawing.Point(643, 160);
            this.lbl_mag_cost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mag_cost.Name = "lbl_mag_cost";
            this.lbl_mag_cost.Size = new System.Drawing.Size(49, 25);
            this.lbl_mag_cost.TabIndex = 19;
            this.lbl_mag_cost.Text = "Price";
            // 
            // lbl_mag_vol
            // 
            this.lbl_mag_vol.AutoSize = true;
            this.lbl_mag_vol.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mag_vol.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_mag_vol.Location = new System.Drawing.Point(170, 248);
            this.lbl_mag_vol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mag_vol.Name = "lbl_mag_vol";
            this.lbl_mag_vol.Size = new System.Drawing.Size(73, 25);
            this.lbl_mag_vol.TabIndex = 18;
            this.lbl_mag_vol.Text = "Volume";
            // 
            // lbl_mag_cat
            // 
            this.lbl_mag_cat.AutoSize = true;
            this.lbl_mag_cat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mag_cat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_mag_cat.Location = new System.Drawing.Point(170, 200);
            this.lbl_mag_cat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mag_cat.Name = "lbl_mag_cat";
            this.lbl_mag_cat.Size = new System.Drawing.Size(84, 25);
            this.lbl_mag_cat.TabIndex = 16;
            this.lbl_mag_cat.Text = "Category";
            // 
            // lbl_mag_name
            // 
            this.lbl_mag_name.AutoSize = true;
            this.lbl_mag_name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mag_name.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_mag_name.Location = new System.Drawing.Point(170, 156);
            this.lbl_mag_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mag_name.Name = "lbl_mag_name";
            this.lbl_mag_name.Size = new System.Drawing.Size(59, 25);
            this.lbl_mag_name.TabIndex = 15;
            this.lbl_mag_name.Text = "Name";
            // 
            // lbl_mag_id
            // 
            this.lbl_mag_id.AutoSize = true;
            this.lbl_mag_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mag_id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_mag_id.Location = new System.Drawing.Point(170, 116);
            this.lbl_mag_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mag_id.Name = "lbl_mag_id";
            this.lbl_mag_id.Size = new System.Drawing.Size(30, 25);
            this.lbl_mag_id.TabIndex = 14;
            this.lbl_mag_id.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.magazine;
            this.pictureBox1.Location = new System.Drawing.Point(813, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // frmmagzine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 576);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmmagzine";
            this.Text = "Magazines";
            this.Load += new System.EventHandler(this.frmmagzine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_mag_ach;
        private MetroFramework.Controls.MetroLabel lbl_mag_article;
        private MetroFramework.Controls.MetroLabel lbl_mag_cost;
        private MetroFramework.Controls.MetroLabel lbl_mag_vol;
        private MetroFramework.Controls.MetroLabel lbl_mag_cat;
        private MetroFramework.Controls.MetroLabel lbl_mag_name;
        private MetroFramework.Controls.MetroLabel lbl_mag_id;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mag_art;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mag_price;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mag_vol;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mag_cat;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mag_name;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mag_id;
        private DevComponents.DotNetBar.ButtonX btnmag_ref;
        private DevComponents.DotNetBar.ButtonX btnmag_del;
        private DevComponents.DotNetBar.ButtonX btnmag_update;
        private DevComponents.DotNetBar.ButtonX btnmag_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}