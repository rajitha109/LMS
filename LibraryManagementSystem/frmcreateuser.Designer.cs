namespace LibraryManagementSystem
{
    partial class frmcreateuser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdvw = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_Management_SystemDataSet = new LibraryManagementSystem.Library_Management_SystemDataSet();
            this.btndelete = new DevComponents.DotNetBar.ButtonX();
            this.btnclear = new DevComponents.DotNetBar.ButtonX();
            this.btncrnuser = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkclient = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkadministrator = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtconpass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTableAdapter = new LibraryManagementSystem.Library_Management_SystemDataSetTableAdapters.LoginTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_Management_SystemDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdvw);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btncrnuser);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtconpass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(220, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New User";
            // 
            // grdvw
            // 
            this.grdvw.AllowUserToAddRows = false;
            this.grdvw.AllowUserToDeleteRows = false;
            this.grdvw.AllowUserToOrderColumns = true;
            this.grdvw.AutoGenerateColumns = false;
            this.grdvw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.grdvw.DataSource = this.loginBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdvw.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdvw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(193)))), ((int)(((byte)(206)))));
            this.grdvw.Location = new System.Drawing.Point(212, 310);
            this.grdvw.MultiSelect = false;
            this.grdvw.Name = "grdvw";
            this.grdvw.ReadOnly = true;
            this.grdvw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdvw.Size = new System.Drawing.Size(485, 165);
            this.grdvw.TabIndex = 12;
            this.grdvw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvw_CellDoubleClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.library_Management_SystemDataSet;
            // 
            // library_Management_SystemDataSet
            // 
            this.library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet";
            this.library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndelete
            // 
            this.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndelete.Location = new System.Drawing.Point(464, 251);
            this.btndelete.Name = "btndelete";
            this.btndelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btndelete.Size = new System.Drawing.Size(110, 40);
            this.btndelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnclear.Location = new System.Drawing.Point(587, 251);
            this.btnclear.Name = "btnclear";
            this.btnclear.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnclear.Size = new System.Drawing.Size(110, 40);
            this.btnclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncrnuser
            // 
            this.btncrnuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncrnuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncrnuser.Location = new System.Drawing.Point(334, 251);
            this.btncrnuser.Name = "btncrnuser";
            this.btncrnuser.Size = new System.Drawing.Size(110, 40);
            this.btncrnuser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncrnuser.TabIndex = 9;
            this.btncrnuser.Text = "Create";
            this.btncrnuser.Click += new System.EventHandler(this.btncrnuser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkclient);
            this.groupBox2.Controls.Add(this.chkadministrator);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(334, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 71);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Type";
            // 
            // chkclient
            // 
            // 
            // 
            // 
            this.chkclient.BackgroundStyle.Class = "";
            this.chkclient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkclient.Location = new System.Drawing.Point(140, 25);
            this.chkclient.Name = "chkclient";
            this.chkclient.Size = new System.Drawing.Size(100, 32);
            this.chkclient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkclient.TabIndex = 7;
            this.chkclient.Text = "Client";
            this.chkclient.CheckedChanging += new DevComponents.DotNetBar.Controls.CheckBoxXChangeEventHandler(this.chkclient_CheckedChanging);
            // 
            // chkadministrator
            // 
            // 
            // 
            // 
            this.chkadministrator.BackgroundStyle.Class = "";
            this.chkadministrator.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkadministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkadministrator.Location = new System.Drawing.Point(10, 25);
            this.chkadministrator.Name = "chkadministrator";
            this.chkadministrator.Size = new System.Drawing.Size(100, 32);
            this.chkadministrator.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkadministrator.TabIndex = 2;
            this.chkadministrator.Text = "Administrator";
            this.chkadministrator.CheckedChanging += new DevComponents.DotNetBar.Controls.CheckBoxXChangeEventHandler(this.chkadministrator_CheckedChanging);
            // 
            // txtconpass
            // 
            // 
            // 
            // 
            this.txtconpass.Border.Class = "TextBoxBorder";
            this.txtconpass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtconpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconpass.Location = new System.Drawing.Point(334, 126);
            this.txtconpass.Name = "txtconpass";
            this.txtconpass.PasswordChar = '*';
            this.txtconpass.Size = new System.Drawing.Size(363, 22);
            this.txtconpass.TabIndex = 6;
            this.txtconpass.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtconpass.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconpass.WatermarkText = "Re-enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // txtpass
            // 
            // 
            // 
            // 
            this.txtpass.Border.Class = "TextBoxBorder";
            this.txtpass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(334, 84);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(363, 22);
            this.txtpass.TabIndex = 4;
            this.txtpass.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtpass.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.WatermarkText = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.Border.Class = "TextBoxBorder";
            this.txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(334, 40);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(363, 22);
            this.txtusername.TabIndex = 1;
            this.txtusername.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtusername.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.WatermarkText = "Enter Username For New User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // frmcreateuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmcreateuser";
            this.Text = "frmcreateuser";
            this.Load += new System.EventHandler(this.frmcreateuser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_Management_SystemDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkclient;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkadministrator;
        private DevComponents.DotNetBar.Controls.TextBoxX txtconpass;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpass;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdvw;
        private DevComponents.DotNetBar.ButtonX btndelete;
        private DevComponents.DotNetBar.ButtonX btnclear;
        private DevComponents.DotNetBar.ButtonX btncrnuser;
        private Library_Management_SystemDataSet library_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Library_Management_SystemDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}