using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmsettingsnew : Form
    {
        public frmsettingsnew()
        {
            InitializeComponent();
        }
        
        private void settings_Load(object sender, EventArgs e)
        {
            }

        private void lnkset_newu_Click(object sender, EventArgs e)
        {

        }

        private void lnkset_bkcat_Click(object sender, EventArgs e)
        {
            frmbookcategory crs=new frmbookcategory();
            this.Hide();
            crs.ShowDialog();
        }

        private void lnkset_crs_Click(object sender, EventArgs e)
        {
            frmcourses crs = new frmcourses();
            this.Hide();
            crs.ShowDialog();
        }

        private void btnset_exit_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Are you Sure ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (s == DialogResult.Yes)
            {
                
            }
        }

        private void frmsettingsnew_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void mtlbackup_Click(object sender, EventArgs e)
        {
            backup crs = new backup();
            this.Hide();
            crs.ShowDialog();
        }

        private void mtlrestore_Click(object sender, EventArgs e)
        {
            restore crs = new restore();
            this.Hide();
            crs.ShowDialog();
        }
    }
}
