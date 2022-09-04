namespace LibraryManagementSystem
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.grblg_dt = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtlg_pw = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtlg_un = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblattempts = new DevComponents.DotNetBar.LabelX();
            this.lbllg_pw = new MetroFramework.Controls.MetroLabel();
            this.lbllg_un = new MetroFramework.Controls.MetroLabel();
            this.grblg_btn = new System.Windows.Forms.GroupBox();
            this.btnlg_clr = new DevComponents.DotNetBar.ButtonX();
            this.btnlg_in = new DevComponents.DotNetBar.ButtonX();
            this.lnklg_rst = new MetroFramework.Controls.MetroLink();
            this.grblg_dt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grblg_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grblg_dt
            // 
            this.grblg_dt.Controls.Add(this.pictureBox1);
            this.grblg_dt.Controls.Add(this.txtlg_pw);
            this.grblg_dt.Controls.Add(this.txtlg_un);
            this.grblg_dt.Controls.Add(this.labelX2);
            this.grblg_dt.Controls.Add(this.labelX1);
            this.grblg_dt.Controls.Add(this.lblattempts);
            this.grblg_dt.Controls.Add(this.lbllg_pw);
            this.grblg_dt.Controls.Add(this.lbllg_un);
            this.grblg_dt.Location = new System.Drawing.Point(30, 13);
            this.grblg_dt.Name = "grblg_dt";
            this.grblg_dt.Size = new System.Drawing.Size(473, 143);
            this.grblg_dt.TabIndex = 4;
            this.grblg_dt.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtlg_pw
            // 
            // 
            // 
            // 
            this.txtlg_pw.Border.Class = "TextBoxBorder";
            this.txtlg_pw.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlg_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlg_pw.Location = new System.Drawing.Point(230, 86);
            this.txtlg_pw.Name = "txtlg_pw";
            this.txtlg_pw.PasswordChar = '*';
            this.txtlg_pw.Size = new System.Drawing.Size(229, 26);
            this.txtlg_pw.TabIndex = 16;
            this.txtlg_pw.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtlg_pw.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlg_pw.WatermarkText = "Enter Your Password Here";
            // 
            // txtlg_un
            // 
            // 
            // 
            // 
            this.txtlg_un.Border.Class = "TextBoxBorder";
            this.txtlg_un.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlg_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlg_un.Location = new System.Drawing.Point(230, 30);
            this.txtlg_un.Name = "txtlg_un";
            this.txtlg_un.Size = new System.Drawing.Size(229, 26);
            this.txtlg_un.TabIndex = 10;
            this.txtlg_un.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtlg_un.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlg_un.WatermarkText = "Please Enter Your Username Here";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(230, 113);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(52, 23);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "You Have";
            this.labelX2.Visible = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(300, 113);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Attempts Left";
            this.labelX1.Visible = false;
            // 
            // lblattempts
            // 
            // 
            // 
            // 
            this.lblattempts.BackgroundStyle.Class = "";
            this.lblattempts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblattempts.Location = new System.Drawing.Point(288, 113);
            this.lblattempts.Name = "lblattempts";
            this.lblattempts.Size = new System.Drawing.Size(10, 23);
            this.lblattempts.TabIndex = 13;
            this.lblattempts.Text = "3";
            this.lblattempts.Visible = false;
            // 
            // lbllg_pw
            // 
            this.lbllg_pw.AutoSize = true;
            this.lbllg_pw.Location = new System.Drawing.Point(138, 88);
            this.lbllg_pw.Name = "lbllg_pw";
            this.lbllg_pw.Size = new System.Drawing.Size(64, 19);
            this.lbllg_pw.TabIndex = 5;
            this.lbllg_pw.Text = "Password";
            // 
            // lbllg_un
            // 
            this.lbllg_un.AutoSize = true;
            this.lbllg_un.Location = new System.Drawing.Point(138, 32);
            this.lbllg_un.Name = "lbllg_un";
            this.lbllg_un.Size = new System.Drawing.Size(75, 19);
            this.lbllg_un.TabIndex = 4;
            this.lbllg_un.Text = "User Name";
            // 
            // grblg_btn
            // 
            this.grblg_btn.Controls.Add(this.btnlg_clr);
            this.grblg_btn.Controls.Add(this.btnlg_in);
            this.grblg_btn.Location = new System.Drawing.Point(30, 162);
            this.grblg_btn.Name = "grblg_btn";
            this.grblg_btn.Size = new System.Drawing.Size(473, 65);
            this.grblg_btn.TabIndex = 8;
            this.grblg_btn.TabStop = false;
            // 
            // btnlg_clr
            // 
            this.btnlg_clr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlg_clr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnlg_clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlg_clr.Location = new System.Drawing.Point(340, 13);
            this.btnlg_clr.Name = "btnlg_clr";
            this.btnlg_clr.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnlg_clr.Size = new System.Drawing.Size(94, 40);
            this.btnlg_clr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnlg_clr.TabIndex = 0;
            this.btnlg_clr.Text = "CLEAR";
            this.btnlg_clr.Click += new System.EventHandler(this.btnlg_clr_Click);
            // 
            // btnlg_in
            // 
            this.btnlg_in.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlg_in.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnlg_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlg_in.Location = new System.Drawing.Point(230, 13);
            this.btnlg_in.Name = "btnlg_in";
            this.btnlg_in.Size = new System.Drawing.Size(94, 40);
            this.btnlg_in.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnlg_in.TabIndex = 17;
            this.btnlg_in.Text = "LOGIN";
            this.btnlg_in.Click += new System.EventHandler(this.btnlg_in_Click);
            // 
            // lnklg_rst
            // 
            this.lnklg_rst.Location = new System.Drawing.Point(280, 233);
            this.lnklg_rst.Name = "lnklg_rst";
            this.lnklg_rst.Size = new System.Drawing.Size(223, 23);
            this.lnklg_rst.TabIndex = 9;
            this.lnklg_rst.Text = "Having Problem with Login";
            this.lnklg_rst.UseSelectable = true;
            this.lnklg_rst.Click += new System.EventHandler(this.lnklg_rst_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.lnklg_rst);
            this.Controls.Add(this.grblg_btn);
            this.Controls.Add(this.grblg_dt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmlogin_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.grblg_dt.ResumeLayout(false);
            this.grblg_dt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grblg_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grblg_dt;
        private MetroFramework.Controls.MetroLabel lbllg_pw;
        private MetroFramework.Controls.MetroLabel lbllg_un;
        private System.Windows.Forms.GroupBox grblg_btn;
        private MetroFramework.Controls.MetroLink lnklg_rst;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblattempts;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlg_pw;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlg_un;
        private DevComponents.DotNetBar.ButtonX btnlg_clr;
        private DevComponents.DotNetBar.ButtonX btnlg_in;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}