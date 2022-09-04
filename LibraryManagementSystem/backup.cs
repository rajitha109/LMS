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

namespace LibraryManagementSystem
{
    public partial class backup : Form
    {
        string path;
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        public backup()
        {
            InitializeComponent();
        }

        void fileopen()
        {
            path = "";
            FolderBrowserDialog selectpath = new FolderBrowserDialog();
            if (selectpath.ShowDialog() == DialogResult.OK)
            {
                path = selectpath.SelectedPath;
            }
        }

        private void btnempM_add_Click(object sender, EventArgs e)
        {
            fileopen();
            txtpath.Text = @""+path+"\\system.bak";
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpath.Text != "")
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(@"USE [master]
BACKUP DATABASE [Library_Management_System] TO  DISK = N'" +txtpath.Text+"' WITH NOFORMAT, NOINIT,  NAME = N'Library_Management_System-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfuly Backuped database to \n"+txtpath.Text+"","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select location to save backup!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void txtpath_TextChanged(object sender, EventArgs e)
        {
            if (txtpath.Text != "")
            {
                btnrestore.Enabled = true;
            }

            else
            {
                btnrestore.Enabled = false;
            }
        }
    }
}
