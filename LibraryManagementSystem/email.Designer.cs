namespace LibraryManagementSystem
{
    partial class frmemail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblstar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dt_email = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_send = new DevComponents.DotNetBar.ButtonX();
            this.Btn_clear = new DevComponents.DotNetBar.ButtonX();
            this.txt_sub = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_to = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_from = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbo_smtp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_body = new System.Windows.Forms.TextBox();
            this.lbl_smtp = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_email)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblstar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dt_email);
            this.groupBox1.Controls.Add(this.btn_send);
            this.groupBox1.Controls.Add(this.Btn_clear);
            this.groupBox1.Controls.Add(this.txt_sub);
            this.groupBox1.Controls.Add(this.txt_to);
            this.groupBox1.Controls.Add(this.txt_pwd);
            this.groupBox1.Controls.Add(this.txt_from);
            this.groupBox1.Controls.Add(this.cbo_smtp);
            this.groupBox1.Controls.Add(this.txt_body);
            this.groupBox1.Controls.Add(this.lbl_smtp);
            this.groupBox1.Controls.Add(this.lbl_from);
            this.groupBox1.Controls.Add(this.lbl_pwd);
            this.groupBox1.Controls.Add(this.lbl_to);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_subject);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1270, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send E-mail";
            // 
            // lblstar
            // 
            this.lblstar.AutoSize = true;
            this.lblstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstar.ForeColor = System.Drawing.Color.Red;
            this.lblstar.Location = new System.Drawing.Point(440, 48);
            this.lblstar.Name = "lblstar";
            this.lblstar.Size = new System.Drawing.Size(134, 20);
            this.lblstar.TabIndex = 92;
            this.lblstar.Text = "Must Fill All Fields";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.email1;
            this.pictureBox1.Location = new System.Drawing.Point(877, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // dt_email
            // 
            this.dt_email.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_email.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_email.DefaultCellStyle = dataGridViewCellStyle1;
            this.dt_email.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dt_email.Location = new System.Drawing.Point(638, 20);
            this.dt_email.Name = "dt_email";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_email.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_email.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_email.Size = new System.Drawing.Size(218, 512);
            this.dt_email.TabIndex = 41;
            this.dt_email.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_email_CellDoubleClick);
            // 
            // btn_send
            // 
            this.btn_send.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_send.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(462, 464);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(129, 52);
            this.btn_send.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "SEND";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_clear.Location = new System.Drawing.Point(291, 464);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.Btn_clear.Size = new System.Drawing.Size(129, 52);
            this.Btn_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_clear.TabIndex = 2;
            this.Btn_clear.Text = "REFRESH";
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // txt_sub
            // 
            // 
            // 
            // 
            this.txt_sub.Border.Class = "TextBoxBorder";
            this.txt_sub.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub.Location = new System.Drawing.Point(194, 215);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(397, 26);
            this.txt_sub.TabIndex = 42;
            this.txt_sub.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub.WatermarkText = "Enter Email Subject Here";
            // 
            // txt_to
            // 
            // 
            // 
            // 
            this.txt_to.Border.Class = "TextBoxBorder";
            this.txt_to.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_to.Location = new System.Drawing.Point(194, 170);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(397, 26);
            this.txt_to.TabIndex = 41;
            this.txt_to.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_to.WatermarkText = "Enter Recived Email Address Here";
            // 
            // txt_pwd
            // 
            // 
            // 
            // 
            this.txt_pwd.Border.Class = "TextBoxBorder";
            this.txt_pwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(194, 130);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(397, 26);
            this.txt_pwd.TabIndex = 40;
            this.txt_pwd.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.WatermarkText = "Enter Password Here";
            // 
            // txt_from
            // 
            // 
            // 
            // 
            this.txt_from.Border.Class = "TextBoxBorder";
            this.txt_from.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_from.Location = new System.Drawing.Point(194, 88);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(397, 26);
            this.txt_from.TabIndex = 39;
            this.txt_from.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_from.WatermarkText = "Enter Sender Email Address";
            // 
            // cbo_smtp
            // 
            this.cbo_smtp.DisplayMember = "Text";
            this.cbo_smtp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_smtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_smtp.FormattingEnabled = true;
            this.cbo_smtp.ItemHeight = 20;
            this.cbo_smtp.Location = new System.Drawing.Point(194, 48);
            this.cbo_smtp.Name = "cbo_smtp";
            this.cbo_smtp.Size = new System.Drawing.Size(240, 26);
            this.cbo_smtp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_smtp.TabIndex = 38;
            this.cbo_smtp.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_smtp.WatermarkText = "Select Your Email Service";
            // 
            // txt_body
            // 
            this.txt_body.BackColor = System.Drawing.SystemColors.Info;
            this.txt_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_body.Location = new System.Drawing.Point(194, 265);
            this.txt_body.Margin = new System.Windows.Forms.Padding(2);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(397, 169);
            this.txt_body.TabIndex = 36;
            this.txt_body.Text = "Please Return The Book\r\n                                         Hasalaka Tech\r\n";
            // 
            // lbl_smtp
            // 
            this.lbl_smtp.AutoSize = true;
            this.lbl_smtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smtp.Location = new System.Drawing.Point(74, 48);
            this.lbl_smtp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_smtp.Name = "lbl_smtp";
            this.lbl_smtp.Size = new System.Drawing.Size(108, 18);
            this.lbl_smtp.TabIndex = 26;
            this.lbl_smtp.Text = "SMTP Address";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.Location = new System.Drawing.Point(74, 88);
            this.lbl_from.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(44, 18);
            this.lbl_from.TabIndex = 27;
            this.lbl_from.Text = "From";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(74, 130);
            this.lbl_pwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(75, 18);
            this.lbl_pwd.TabIndex = 28;
            this.lbl_pwd.Text = "Password";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(74, 172);
            this.lbl_to.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(26, 18);
            this.lbl_to.TabIndex = 29;
            this.lbl_to.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Body";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(74, 215);
            this.lbl_subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(57, 18);
            this.lbl_subject.TabIndex = 30;
            this.lbl_subject.Text = "Subject";
            // 
            // frmemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 576);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmemail";
            this.Text = "E-mail";
            this.Load += new System.EventHandler(this.email_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_body;
        private System.Windows.Forms.Label lbl_smtp;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_subject;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_smtp;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sub;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_to;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pwd;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_from;
        private DevComponents.DotNetBar.ButtonX btn_send;
        private DevComponents.DotNetBar.ButtonX Btn_clear;
        private DevComponents.DotNetBar.Controls.DataGridViewX dt_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstar;


    }
}