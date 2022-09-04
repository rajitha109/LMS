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
    public partial class frmcreateuser : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
        
        public frmcreateuser()
        {
            InitializeComponent();
        }

        void fill()
        {
            con.Open();
            string select = "SELECT [Username],[Password],[Role] FROM [Library_Management_System].[dbo].[Login] where Role='"+chkadministrator.Text+"' or Role='"+chkclient.Text+"'";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtrec = new DataTable();

            da.Fill(dtrec);
            grdvw.DataSource = dtrec;
            con.Close();
        }

        bool res;
        void validate()
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
                txtusername.Focus();
            }

            else if (txtpass.Text == "")
            {
                MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
                txtpass.Focus();
            }

            else if(txtconpass.Text=="")
            {
                MessageBox.Show("Please re-enter the password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
                txtpass.Focus();
            }

            else if (txtconpass.Text != txtpass.Text)
            {
                MessageBox.Show("Password Mismatched try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
                txtpass.Focus();
            }

            else if ((chkadministrator.Checked == false) && (chkclient.Checked == false))
            {
                MessageBox.Show("Please select user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
            }

            else
            {
                res = false;
            }

        }

        void refresh()
        {
            txtusername.Text = "";
            txtpass.Text = "";
            txtconpass.Text = "";
            chkadministrator.Checked = false;
            chkclient.Checked = false;
            txtusername.Focus();
        }

        string type;
        private void btncrnuser_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                
                if (chkadministrator.Checked == true)
                {
                    type = chkadministrator.Text;
                }

                else if (chkclient.Checked == true)
                {
                    type = chkclient.Text;
                }

                if (res == false)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [Library_Management_System].[dbo].[Login]
           ([Username]
           ,[Password]
           ,[Role])
     VALUES
           ('"+txtusername.Text+"','"+txtpass.Text+"','"+type+"')",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully added new user '" + txtusername.Text + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                    fill();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkadministrator_CheckedChanged(object sender, EventArgs e)
        {
            chkclient.Checked = false;
        }

        private void chkclient_CheckedChanged(object sender, EventArgs e)
        {
            chkadministrator.Checked = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void frmcreateuser_Load(object sender, EventArgs e)
        {
            fill();
            
        }

        private void grdvw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = this.grdvw.Rows[i];
                txtusername.Text = row.Cells[0].Value.ToString();
                txtpass.Text = row.Cells[1].Value.ToString();
                txtconpass.Text = txtpass.Text;
                string utype = row.Cells[2].Value.ToString();
                if (utype == "Administrator")
                {
                    chkadministrator.Checked = true;
                }
                else if (utype == "Client")
                {
                    chkclient.Checked = true;
                }
            }
        }

        private void chkadministrator_CheckedChanging(object sender, DevComponents.DotNetBar.Controls.CheckBoxXChangeEventArgs e)
        {
            chkclient.Checked = false;
        }

        private void chkclient_CheckedChanging(object sender, DevComponents.DotNetBar.Controls.CheckBoxXChangeEventArgs e)
        {
            chkadministrator.Checked = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"DELETE FROM [Library_Management_System].[dbo].[Login]
      WHERE Username='"+txtusername.Text+"' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully deleted user '" + txtusername.Text + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                    fill();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
