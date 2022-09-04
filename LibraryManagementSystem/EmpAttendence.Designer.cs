namespace LibraryManagementSystem
{
    partial class EmpAttendence
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
            this.lbleid = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDsg1 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.btnOut = new DevComponents.DotNetBar.ButtonX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.txtOut = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.lbleid);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblDsg1);
            this.groupBox1.Controls.Add(this.lblName1);
            this.groupBox1.Controls.Add(this.btnOut);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.txtOut);
            this.groupBox1.Controls.Add(this.txtIn);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 552);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Attendence";
            // 
            // lbleid
            // 
            this.lbleid.AutoSize = true;
            this.lbleid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbleid.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbleid.Location = new System.Drawing.Point(677, 129);
            this.lbleid.Name = "lbleid";
            this.lbleid.Size = new System.Drawing.Size(36, 25);
            this.lbleid.TabIndex = 60;
            this.lbleid.Text = "eid";
            this.lbleid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbleid.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(896, 108);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 29);
            this.lblDate.TabIndex = 59;
            // 
            // lblDsg1
            // 
            this.lblDsg1.AutoSize = true;
            this.lblDsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDsg1.Location = new System.Drawing.Point(564, 199);
            this.lblDsg1.Name = "lblDsg1";
            this.lblDsg1.Size = new System.Drawing.Size(51, 20);
            this.lblDsg1.TabIndex = 58;
            this.lblDsg1.Text = "label2";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.Location = new System.Drawing.Point(564, 134);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(51, 20);
            this.lblName1.TabIndex = 57;
            this.lblName1.Text = "label1";
            // 
            // btnOut
            // 
            this.btnOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(800, 318);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(109, 39);
            this.btnOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOut.TabIndex = 56;
            this.btnOut.Text = "MARK";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(800, 258);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(109, 39);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 55;
            this.btnIn.Text = "MARK";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtOut
            // 
            // 
            // 
            // 
            this.txtOut.Border.Class = "TextBoxBorder";
            this.txtOut.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(568, 326);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(156, 26);
            this.txtOut.TabIndex = 54;
            // 
            // txtIn
            // 
            // 
            // 
            // 
            this.txtIn.Border.Class = "TextBoxBorder";
            this.txtIn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(568, 263);
            this.txtIn.Name = "txtIn";
            this.txtIn.ReadOnly = true;
            this.txtIn.Size = new System.Drawing.Size(156, 26);
            this.txtIn.TabIndex = 53;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(397, 326);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 25);
            this.metroLabel3.TabIndex = 51;
            this.metroLabel3.Text = "Time Out";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(397, 263);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 25);
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "Time In";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(397, 199);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 25);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Designation";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblName.Location = new System.Drawing.Point(397, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 48;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.in_out;
            this.pictureBox1.Location = new System.Drawing.Point(-67, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.time_in;
            this.pictureBox2.Location = new System.Drawing.Point(885, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(464, 375);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(930, 31);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 25);
            this.metroLabel4.TabIndex = 63;
            this.metroLabel4.Text = "Date";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel4.Visible = false;
            // 
            // EmpAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 576);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmpAttendence";
            this.Text = "EmpAttendence";
            this.Load += new System.EventHandler(this.EmpAttendence_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblName;
        private DevComponents.DotNetBar.ButtonX btnOut;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDsg1;
        private System.Windows.Forms.Label lblName1;
        private MetroFramework.Controls.MetroLabel lbleid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}