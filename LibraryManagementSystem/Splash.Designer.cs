namespace LibraryManagementSystem
{
    partial class frmsplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsplash));
            this.prosp = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.tmrsp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // prosp
            // 
            // 
            // 
            // 
            this.prosp.BackgroundStyle.Class = "";
            this.prosp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prosp.Location = new System.Drawing.Point(1, 274);
            this.prosp.Name = "prosp";
            this.prosp.Size = new System.Drawing.Size(566, 13);
            this.prosp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.prosp.TabIndex = 0;
            // 
            // tmrsp
            // 
            this.tmrsp.Enabled = true;
            this.tmrsp.Interval = 20;
            this.tmrsp.Tick += new System.EventHandler(this.tmrsp_Tick);
            // 
            // frmsplash
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 287);
            this.Controls.Add(this.prosp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmsplash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ProgressBarX prosp;
        private System.Windows.Forms.Timer tmrsp;
    }
}

