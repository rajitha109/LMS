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
    public partial class restore : Form
    {
        string filename;
        SqlConnection con = new SqlConnection("Data Source=localhost;Integrated Security=True");

        public restore()
        {
            InitializeComponent();
        }

        void enable()
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

        void fileopen()
        {
            filename = "";
            OpenFileDialog chose = new OpenFileDialog();
            chose.Filter = "bak file(*.bak)|*.bak";
            chose.FilterIndex = 1;
            chose.Multiselect = false;
            if (chose.ShowDialog() == DialogResult.OK)
            {
                filename = chose.FileName;
            }
        }

        private void btnempM_add_Click(object sender, EventArgs e)
        {
            fileopen();
            txtpath.Text = filename;

        }
        public EventHandler infopress;

        private void btnrestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpath.Text != "")
                {
                    
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand(@"USE [master]
ALTER DATABASE [Library_Management_System] SET Single_User WITH Rollback Immediate", con);
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(@"USE [master]
RESTORE DATABASE [Library_Management_System] FROM  DISK = N'" + filename + "' WITH  FILE = 1,  NOUNLOAD,  STATS = 5", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    SqlCommand cmd3 = new SqlCommand(@"USE [master]
ALTER DATABASE [Library_Management_System] SET Multi_User", con);
                    cmd3.ExecuteNonQuery();
                    con.Close();

                    DialogResult s = MessageBox.Show("Successfuly restored the database!" + Environment.NewLine + "Application will close now to take effect.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (s == DialogResult.OK)
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please select backup file location!");
                }
            }

            catch (Exception)
            {
                try
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(@"USE [master]
RESTORE DATABASE [Library_Management_System] FROM  DISK = N'" + filename + "' WITH  FILE = 1,  NOUNLOAD,  STATS = 5", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfuly restored the database !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmsplash lg = new frmsplash();
                    lg.Show();
                    this.Hide();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void txtpath_TextChanged(object sender, EventArgs e)
        {
            enable();
        }
    }
}
