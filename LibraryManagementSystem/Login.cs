using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;



namespace LibraryManagementSystem
{
    public partial class frmlogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");


        public static Process running()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);

            //Loop through the running processes in with the same name 
            foreach (Process process in processes)
            {
                //Ignore the current process 
                if (process.Id != current.Id)
                {
                    //Make sure that the process is running from the exe file. 
                    if (Assembly.GetExecutingAssembly().Location.
                         Replace("/", "\\") == current.MainModule.FileName)
                    {
                        //Return the other process instance.  
                        return process;

                    }
                }
            }
            //No other instance was found, return null.  
            return null;
        }

        public frmlogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnlg_in;
            if (frmlogin.running() != null)
            {
                MessageBox.Show("Application is already in use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                //TODO:
                //Your application logic for duplicate 
                //instances would go here.
            }
        }

        

        int count = 0;
        int attempt = 3;
        int show;
        
        
        private void lnklg_rst_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Inorder to reset your password a Gsm Dongle Should be connected into the PC!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (s == DialogResult.OK)
            {
                Resetpass obj = new Resetpass();
                obj.ShowDialog();
            }
        }

        private void frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnlg_in_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [Name]
      ,[Designation]
        ,[EmpNo]
,[U_type]
  FROM [dbo].[EmpRegistrations] where (Name='" + txtlg_un.Text + "' or EmpNo='" + txtlg_un.Text + "')and Password='" + txtlg_pw.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    frmwkspace obj = new frmwkspace(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    this.Hide();
                    obj.Show();
                }

                else
                {
                    MessageBox.Show("invalid user name or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    count = count + 1;
                    if (count == 3)
                    {
                        MessageBox.Show("Try Again Next Time in 20 Seconds !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Countdown obj = new Countdown();
                        this.Hide();
                        obj.Show();
                    }
                    else
                    {
                        labelX1.Visible = true;
                        labelX2.Visible = true;
                        lblattempts.Visible = true;
                        show = attempt - count;
                        lblattempts.Text = Convert.ToString(show);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnlg_clr_Click(object sender, EventArgs e)
        {
            txtlg_un.Text = "";
            txtlg_pw.Text = "";
            txtlg_un.Focus();


        }
    }
}
