namespace LibraryManagementSystem
{
    partial class Countdown
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Countdown));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblsecondsleft = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.lblsecondsleft);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(397, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(211, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(155, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Seconds...";
            // 
            // lblsecondsleft
            // 
            // 
            // 
            // 
            this.lblsecondsleft.BackgroundStyle.Class = "";
            this.lblsecondsleft.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblsecondsleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecondsleft.Location = new System.Drawing.Point(185, 45);
            this.lblsecondsleft.Name = "lblsecondsleft";
            this.lblsecondsleft.Size = new System.Drawing.Size(100, 23);
            this.lblsecondsleft.TabIndex = 2;
            this.lblsecondsleft.Text = "20";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(89, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(181, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Please Wait ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.SystemColors.Desktop;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerColorTint = System.Drawing.SystemColors.Desktop;
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(422, 136);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Countdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Countdown_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblsecondsleft;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.StyleManager styleManager2;
    }
}