using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace LibraryManagementSystem
{
    public partial class frmwkspace : Form
    {
        Timer t = new Timer();

        public frmwkspace(string name, string designation, string empno,string utype)
        {
            InitializeComponent();
            lblumode.Text = utype;
            office2007StartButton1.Text = utype;
            lbldesig.Text = designation;
            lblempno.Text = empno;
            lblname.Text = name;
            if (utype == "Super Admin")
            {
                rbn_empreg.Visible = true;
                rbn_create_fine.Visible = true;
                rbn_rmplv.Visible = false;
                rbn_empatt.Visible = false;
                rbn_emprept.Visible = true;
                frmempatt_rpt.Visible = true;
            }

            else if (utype == "Administrator")
            {
                rbn_create_fine.Visible = false;
            }
            else if (utype == "Client")
            {
                rbn_alert.Visible = false;
                rbn_payroll.Visible = false;
                rbn_income.Visible = false;
            }
        }

        public frmwkspace()
        {
            // TODO: Complete member initialization
        }

        private void t_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            lbl_date.Text = date;
            lbl_time.Text = clock;
        }

        void fr()
        {
            this.MaximumSize = Screen.FromRectangle(this.Bounds).WorkingArea.Size;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void rbn_staff_ItemClick(object sender, EventArgs e)
        {

        }

        private void rbn_book_Click(object sender, EventArgs e)
        {
            
        }

        private void rbn_member_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btn_std_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmstudent obj = new frmstudent(lblumode.Text);
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_stf_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmstaff obj = new frmstaff(lblumode.Text);
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void rbn_trans_Click(object sender, EventArgs e)
        {
            
        }

        private void rbn_search_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmsearch obj = new frmsearch();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmissue obj = new frmissue();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmreturn obj = new frmreturn();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void frmwkspace_Load(object sender, EventArgs e)
        {
            this.fr();
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
            rbn_book.Focus();
            infofill();
        }

        void infofill()
        {
            frminfo obj = new frminfo();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_add_bk_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmbook obj = new frmbook(lblumode.Text);
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frminfo obj = new frminfo();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void rbn_alert_Click(object sender, EventArgs e)
        {
            
        }

        private void rbn_report_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to Log Out from " + lblumode.Text + " Account ?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Information );
            if (s == DialogResult.Yes)
            {
                frmlogin obj = new frmlogin();
                this.Hide();
                obj.Show();
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            frmsettingsnew obj = new frmsettingsnew();
            obj.ShowDialog();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmemail obj = new frmemail();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();

        }

        private void btn_sms_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmsms obj = new frmsms();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void rbnwk_Click(object sender, EventArgs e)
        {

        }


        public static bool close()
        {
            var s = MessageBox.Show("Do you want to quit from Library Manager?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (s == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void frmwkspace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close() == false)
            {
                e.Cancel = true;
            }

            
        }

        private void pnlwrk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbn_finan_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ctfine_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmcrtfine obj = new frmcrtfine();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_fine_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmfine obj = new frmfine();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_income_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmincome obj = new frmincome();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_payroll_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmpayroll obj = new frmpayroll();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_dg_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmdigital obj = new frmdigital(lblumode.Text);
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_mag_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmmagzine obj = new frmmagzine(lblumode.Text);
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_bk_view_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmBookView obj = new frmBookView();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_dg_view_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmdigitalView obj = new frmdigitalView();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
            
        }

        private void btn_mag_view_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmMagazineView obj = new frmMagazineView();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show(); 
        }

        private void btnveiw_dly_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmDelayVeiw obj = new frmDelayVeiw();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
            
        }

        private void btnview_dmg_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmDamageVeiw obj = new frmDamageVeiw();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show(); 
        }

        private void btnveiw_lost_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmLostViwe obj = new frmLostViwe();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show(); 
        }

        private void btnveiw_sell_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmSellVeiw obj = new frmSellVeiw();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btnview_other_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmOtherViwe obj = new frmOtherViwe();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btnveiw_pay_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmPayrollVeiw obj = new frmPayrollVeiw();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_noti_Click(object sender, EventArgs e)
        {

        }

        private void btnfinan_veiw_Click(object sender, EventArgs e)
        {

        }

        private void btnstrpt_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptStudent obj = new frmrptStudent();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btnrptstaff_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptStaff obj = new frmrptStaff();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {

        }

        private void btn_allbk_rpt_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptBooks obj = new frmrptBooks();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btndelayfine_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmdelayfinerpt obj = new frmdelayfinerpt();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btncrtnewuser_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmcreateuser obj = new frmcreateuser();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_allmag_rpt_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptmagazines obj = new frmrptmagazines();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            EmployeeRegistration obj = new EmployeeRegistration();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_att_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            EmpAttendence obj = new EmpAttendence(lblempno.Text,lblname.Text,lbldesig.Text
);
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btnstu_his_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmstuhis obj = new frmstuhis();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btnstf_his_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmstaffhistory obj = new frmstaffhistory();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_alldg_rpt_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptalldigital obj = new frmrptalldigital();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptdamagedfine obj = new frmrptdamagedfine();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptlost obj = new frmrptlost();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptsell obj = new frmrptsell();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptotherincome obj = new frmrptotherincome();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_issued_rpt_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptissued obj = new frmrptissued();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_misplaced_bk_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptmissed obj = new frmrptmissed();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btn_lve_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmemplev obj = new frmemplev(lblempno.Text, lblname.Text, lbldesig.Text);
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void frmempreg_rpt_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptempdetails obj = new frmrptempdetails();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void frmwkspace_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void frmempleave_rpt_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            rptempleave obj = new rptempleave();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void frmempatt_rpt_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            frmrptattendance obj = new frmrptattendance();
            obj.MdiParent = this;
            obj.ClientSize = new System.Drawing.Size(2000, 800);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void office2007StartButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            try
            {
                string helpfile = "Help.pdf";
                //ProcessStartInfo helpfile = new ProcessStartInfo(@"Resources\Help.pdf");
                //extractresourse("LibraryManagementSystem.Resources.Help.pdf",helpfile);
                Process.Start(helpfile);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*void extractresourse(string resource, string path)
        {
            try
            {
                Stream stream = GetType().Assembly.GetManifestResourceStream(resource);
                byte[] bytes = new byte[(int)stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                File.WriteAllBytes(path, bytes);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void rbnbtnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
