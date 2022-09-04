namespace LibraryManagementSystem
{
    partial class Resetpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resetpass));
            this.btnsrc = new DevComponents.DotNetBar.ButtonX();
            this.txtid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkagr = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblcon = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblpnum = new MetroFramework.Controls.MetroLabel();
            this.lblun = new MetroFramework.Controls.MetroLabel();
            this.lbluname = new MetroFramework.Controls.MetroLabel();
            this.btnresetpass = new DevComponents.DotNetBar.ButtonX();
            this.btncheck = new DevComponents.DotNetBar.ButtonX();
            this.btncancel = new DevComponents.DotNetBar.ButtonX();
            this.btngobk = new DevComponents.DotNetBar.ButtonX();
            this.btngetcode = new DevComponents.DotNetBar.ButtonX();
            this.txtconpass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnpass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtrcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsrc
            // 
            this.btnsrc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsrc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrc.Location = new System.Drawing.Point(439, 55);
            this.btnsrc.Name = "btnsrc";
            this.btnsrc.Size = new System.Drawing.Size(132, 26);
            this.btnsrc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsrc.TabIndex = 56;
            this.btnsrc.Text = "Search Account";
            this.btnsrc.Click += new System.EventHandler(this.btnempM_add_Click);
            // 
            // txtid
            // 
            // 
            // 
            // 
            this.txtid.Border.Class = "TextBoxBorder";
            this.txtid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(187, 55);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(246, 26);
            this.txtid.TabIndex = 58;
            this.txtid.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtid.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.WatermarkText = "Enter Employee ID to reset password";
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblName.Location = new System.Drawing.Point(68, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 25);
            this.lblName.TabIndex = 57;
            this.lblName.Text = "Employee ID";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkagr);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.lblcon);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.lblpnum);
            this.groupBox1.Controls.Add(this.lblun);
            this.groupBox1.Controls.Add(this.lbluname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnresetpass);
            this.groupBox1.Controls.Add(this.btncheck);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btngobk);
            this.groupBox1.Controls.Add(this.btngetcode);
            this.groupBox1.Controls.Add(this.btnsrc);
            this.groupBox1.Controls.Add(this.txtconpass);
            this.groupBox1.Controls.Add(this.txtnpass);
            this.groupBox1.Controls.Add(this.txtrcode);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 583);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resetting Your Password";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // chkagr
            // 
            // 
            // 
            // 
            this.chkagr.BackgroundStyle.Class = "";
            this.chkagr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkagr.Enabled = false;
            this.chkagr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkagr.Location = new System.Drawing.Point(197, 208);
            this.chkagr.Name = "chkagr";
            this.chkagr.Size = new System.Drawing.Size(210, 23);
            this.chkagr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkagr.TabIndex = 63;
            this.chkagr.Text = "I agreed this is my account";
            this.chkagr.CheckedChanged += new System.EventHandler(this.chkagr_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(68, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(147, 19);
            this.metroLabel4.TabIndex = 62;
            this.metroLabel4.Text = "Your user details are";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.WrapToLine = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Enabled = false;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(53, 389);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(149, 19);
            this.metroLabel7.TabIndex = 62;
            this.metroLabel7.Text = "Reset Your password";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.WrapToLine = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Enabled = false;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(53, 389);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(148, 19);
            this.metroLabel6.TabIndex = 62;
            this.metroLabel6.Text = "Reset your password";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.WrapToLine = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(53, 294);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(549, 19);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Enter the 6 digit reset code which have been send to your mobile phone number ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.WrapToLine = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Enabled = false;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel8.Location = new System.Drawing.Point(127, 479);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(188, 19);
            this.metroLabel8.TabIndex = 62;
            this.metroLabel8.Text = "Re-enter Your New Password";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcon
            // 
            this.lblcon.AutoSize = true;
            this.lblcon.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblcon.Location = new System.Drawing.Point(162, 173);
            this.lblcon.Name = "lblcon";
            this.lblcon.Size = new System.Drawing.Size(111, 19);
            this.lblcon.TabIndex = 62;
            this.lblcon.Text = "Contact Number";
            this.lblcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Enabled = false;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel5.Location = new System.Drawing.Point(127, 438);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 60;
            this.metroLabel5.Text = "New Password";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpnum
            // 
            this.lblpnum.AutoSize = true;
            this.lblpnum.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblpnum.Location = new System.Drawing.Point(321, 173);
            this.lblpnum.Name = "lblpnum";
            this.lblpnum.Size = new System.Drawing.Size(0, 0);
            this.lblpnum.TabIndex = 61;
            this.lblpnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblun.Location = new System.Drawing.Point(162, 131);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(77, 19);
            this.lblun.TabIndex = 60;
            this.lblun.Text = "User Name";
            this.lblun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbluname.Location = new System.Drawing.Point(321, 131);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(0, 0);
            this.lbluname.TabIndex = 59;
            this.lbluname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnresetpass
            // 
            this.btnresetpass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnresetpass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnresetpass.Enabled = false;
            this.btnresetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetpass.Location = new System.Drawing.Point(298, 520);
            this.btnresetpass.Name = "btnresetpass";
            this.btnresetpass.Size = new System.Drawing.Size(159, 26);
            this.btnresetpass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnresetpass.TabIndex = 56;
            this.btnresetpass.Text = "Reset Password";
            this.btnresetpass.Click += new System.EventHandler(this.btnresetpass_Click);
            // 
            // btncheck
            // 
            this.btncheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncheck.Enabled = false;
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(298, 330);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(99, 26);
            this.btncheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncheck.TabIndex = 56;
            this.btncheck.Text = "Check";
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btncancel
            // 
            this.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(472, 520);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 26);
            this.btncancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncancel.TabIndex = 56;
            this.btncancel.Text = "Cancel";
            this.btncancel.Visible = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btngobk
            // 
            this.btngobk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btngobk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btngobk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngobk.Location = new System.Drawing.Point(412, 330);
            this.btngobk.Name = "btngobk";
            this.btngobk.Size = new System.Drawing.Size(81, 26);
            this.btngobk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btngobk.TabIndex = 56;
            this.btngobk.Text = "Go back";
            this.btngobk.Visible = false;
            this.btngobk.Click += new System.EventHandler(this.btngoback_Click);
            // 
            // btngetcode
            // 
            this.btngetcode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btngetcode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btngetcode.Enabled = false;
            this.btngetcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetcode.Location = new System.Drawing.Point(219, 242);
            this.btngetcode.Name = "btngetcode";
            this.btngetcode.Size = new System.Drawing.Size(143, 26);
            this.btngetcode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btngetcode.TabIndex = 56;
            this.btngetcode.Text = "Get Reset Code";
            this.btngetcode.Click += new System.EventHandler(this.btngetcode_Click);
            // 
            // txtconpass
            // 
            // 
            // 
            // 
            this.txtconpass.Border.Class = "TextBoxBorder";
            this.txtconpass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtconpass.Enabled = false;
            this.txtconpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconpass.Location = new System.Drawing.Point(321, 476);
            this.txtconpass.Name = "txtconpass";
            this.txtconpass.PasswordChar = '*';
            this.txtconpass.Size = new System.Drawing.Size(196, 26);
            this.txtconpass.TabIndex = 58;
            this.txtconpass.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtconpass.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconpass.WatermarkText = "Re-enter new password here";
            this.txtconpass.TextChanged += new System.EventHandler(this.txtconpass_TextChanged);
            // 
            // txtnpass
            // 
            // 
            // 
            // 
            this.txtnpass.Border.Class = "TextBoxBorder";
            this.txtnpass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnpass.Enabled = false;
            this.txtnpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnpass.Location = new System.Drawing.Point(321, 434);
            this.txtnpass.Name = "txtnpass";
            this.txtnpass.PasswordChar = '*';
            this.txtnpass.Size = new System.Drawing.Size(195, 26);
            this.txtnpass.TabIndex = 58;
            this.txtnpass.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtnpass.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnpass.WatermarkText = "Enter new password here";
            this.txtnpass.TextChanged += new System.EventHandler(this.txtnpass_TextChanged);
            // 
            // txtrcode
            // 
            // 
            // 
            // 
            this.txtrcode.Border.Class = "TextBoxBorder";
            this.txtrcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtrcode.Enabled = false;
            this.txtrcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrcode.Location = new System.Drawing.Point(172, 330);
            this.txtrcode.Name = "txtrcode";
            this.txtrcode.Size = new System.Drawing.Size(120, 26);
            this.txtrcode.TabIndex = 58;
            this.txtrcode.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtrcode.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrcode.WatermarkText = "Reset Code Here";
            this.txtrcode.TextChanged += new System.EventHandler(this.txtrcode_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.settingsicon;
            this.pictureBox1.Location = new System.Drawing.Point(-95, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // Resetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(635, 607);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resetpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnsrc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtid;
        private MetroFramework.Controls.MetroLabel lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkagr;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblcon;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblpnum;
        private MetroFramework.Controls.MetroLabel lblun;
        private MetroFramework.Controls.MetroLabel lbluname;
        private DevComponents.DotNetBar.ButtonX btnresetpass;
        private DevComponents.DotNetBar.ButtonX btncheck;
        private DevComponents.DotNetBar.ButtonX btngetcode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtconpass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnpass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtrcode;
        private DevComponents.DotNetBar.ButtonX btngobk;
        private DevComponents.DotNetBar.ButtonX btncancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}