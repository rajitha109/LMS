namespace LibraryManagementSystem
{
    partial class frmsearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbsearch = new System.Windows.Forms.GroupBox();
            this.cmbsrch = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.book = new DevComponents.Editors.ComboItem();
            this.digitalmedia = new DevComponents.Editors.ComboItem();
            this.magazine = new DevComponents.Editors.ComboItem();
            this.student = new DevComponents.Editors.ComboItem();
            this.staff = new DevComponents.Editors.ComboItem();
            this.txtsrh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnsrh = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drgsrch = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.grbsearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgsrch)).BeginInit();
            this.SuspendLayout();
            // 
            // grbsearch
            // 
            this.grbsearch.BackColor = System.Drawing.SystemColors.Window;
            this.grbsearch.Controls.Add(this.cmbsrch);
            this.grbsearch.Controls.Add(this.txtsrh);
            this.grbsearch.Controls.Add(this.btnsrh);
            this.grbsearch.Location = new System.Drawing.Point(6, 19);
            this.grbsearch.Name = "grbsearch";
            this.grbsearch.Size = new System.Drawing.Size(785, 74);
            this.grbsearch.TabIndex = 0;
            this.grbsearch.TabStop = false;
            // 
            // cmbsrch
            // 
            this.cmbsrch.DisplayMember = "Text";
            this.cmbsrch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbsrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsrch.FormattingEnabled = true;
            this.cmbsrch.ItemHeight = 20;
            this.cmbsrch.Items.AddRange(new object[] {
            this.book,
            this.digitalmedia,
            this.magazine,
            this.student,
            this.staff});
            this.cmbsrch.Location = new System.Drawing.Point(15, 23);
            this.cmbsrch.Name = "cmbsrch";
            this.cmbsrch.Size = new System.Drawing.Size(154, 26);
            this.cmbsrch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbsrch.TabIndex = 10;
            this.cmbsrch.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsrch.WatermarkText = "Select Search Category";
            // 
            // book
            // 
            this.book.Text = "Book";
            // 
            // digitalmedia
            // 
            this.digitalmedia.Text = "Digital Media";
            // 
            // magazine
            // 
            this.magazine.Text = "Magazine";
            // 
            // student
            // 
            this.student.Text = "Student";
            // 
            // staff
            // 
            this.staff.Text = "Staff";
            // 
            // txtsrh
            // 
            // 
            // 
            // 
            this.txtsrh.Border.Class = "TextBoxBorder";
            this.txtsrh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsrh.Location = new System.Drawing.Point(211, 23);
            this.txtsrh.Name = "txtsrh";
            this.txtsrh.Size = new System.Drawing.Size(444, 26);
            this.txtsrh.TabIndex = 9;
            this.txtsrh.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsrh.WatermarkText = "Enter Search Key Word Here";
            // 
            // btnsrh
            // 
            this.btnsrh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsrh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrh.Location = new System.Drawing.Point(673, 23);
            this.btnsrh.Name = "btnsrh";
            this.btnsrh.Size = new System.Drawing.Size(86, 26);
            this.btnsrh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsrh.TabIndex = 8;
            this.btnsrh.Text = "SEARCH";
            this.btnsrh.Click += new System.EventHandler(this.btnsrh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.drgsrch);
            this.groupBox1.Controls.Add(this.grbsearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 558);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // drgsrch
            // 
            this.drgsrch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drgsrch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drgsrch.BackgroundColor = System.Drawing.SystemColors.Window;
            this.drgsrch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drgsrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drgsrch.DefaultCellStyle = dataGridViewCellStyle2;
            this.drgsrch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.drgsrch.Location = new System.Drawing.Point(6, 113);
            this.drgsrch.Name = "drgsrch";
            this.drgsrch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drgsrch.Size = new System.Drawing.Size(1171, 439);
            this.drgsrch.TabIndex = 0;
            // 
            // frmsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1207, 582);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmsearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmsearch_Load);
            this.grbsearch.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drgsrch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbsearch;
        private DevComponents.DotNetBar.ButtonX btnsrh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsrh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbsrch;
        private DevComponents.Editors.ComboItem book;
        private DevComponents.Editors.ComboItem magazine;
        private DevComponents.Editors.ComboItem digitalmedia;
        private DevComponents.Editors.ComboItem student;
        private DevComponents.Editors.ComboItem staff;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX drgsrch;

    }
}