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
    public partial class frmcourses : Form
    {
        public frmcourses()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void frmcourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmsettingsnew obj = new frmsettingsnew();
            this.Hide();
            obj.ShowDialog();

        }

        void fill()
        {
            con.Open();
            string select = "SELECT * FROM [Library_Management_System].[dbo].[Course]";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrcrs.ReadOnly = true;
            dgrcrs.DataSource = dt;
            con.Close();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btncrs_add;
            fill();
        }

        private void txtcrs_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcrs_id.Text != "")
                {
                    txtcrs_name.Text="";
                    cmbcrs_du.Text = "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [Library_Management_System].[dbo].[Course] WHERE (Course_ID='" + txtcrs_id.Text + "')", con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        txtcrs_name.Text = rdr.GetValue(1).ToString();
                        cmbcrs_du.Text = rdr.GetValue(2).ToString();
                    }
                    con.Close();
                }

                else
                {
                    txtcrs_name.Text = "";
                    cmbcrs_du.Text = "";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
        }

        private void btncrs_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [Course_ID]
      ,[Name]
      ,[Duration]
      ,[Start_date]
  FROM [dbo].[Course] where Course_ID='"+txtcrs_id.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    if (!(txtcrs_id.Text == "") && !(txtcrs_name.Text == "") && !(cmbcrs_du.Text == ""))
                    {
                        con.Open();
                        String query = "INSERT INTO [Library_Management_System].[dbo].[Course]([Course_ID],[Name],[Duration],[Start_date]) VALUES (N'" + this.txtcrs_id.Text + "',N'" + this.txtcrs_name.Text + "',N'" + this.cmbcrs_du.Text + "','" + dtpcrs_stdt.Value.ToShortDateString() + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Done Saving");
                        ClearData();
                        fill();
                    }

                    else
                    {
                        MessageBox.Show("Please Fill all the details..");
                    }
                }
                else
                {
                    MessageBox.Show("Category number already exist !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearData()
        {
            txtcrs_id.Clear();
            txtcrs_name.Clear();
        }

        private void dgrcrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }   

        private void btnbkcat_exit_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Are you Sure ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
            frmsettingsnew set = new frmsettingsnew();
            set.Show();
        }

        private void btncrs_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtcrs_id.Text == "") && !(txtcrs_name.Text == "") && !(cmbcrs_du.Text == ""))
                {
                    con.Open();
                    string query = "UPDATE [Library_Management_System].[dbo].[Course] SET [Name] =N'" + txtcrs_name.Text + "',[Duration] =N'" + cmbcrs_du.Text + "' ,[Start_date] = '" + dtpcrs_stdt.Value.ToShortDateString() + "' WHERE [Course_ID]='" + txtcrs_id.Text + "'";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Done");
                    ClearData();
                    fill();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncrs_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtcrs_id.Text == ""))
                {
                    con.Open();
                    string query = "DELETE FROM [Library_Management_System].[dbo].[Course]WHERE [Course_ID]='" + txtcrs_id.Text + "'";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Done");
                    ClearData();
                    fill();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btncrs_refresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dgrcrs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = this.dgrcrs.Rows[i];
                txtcrs_id.Text = row.Cells[0].Value.ToString();
                txtcrs_name.Text = row.Cells[1].Value.ToString();
                cmbcrs_du.Text = row.Cells[2].Value.ToString();
                dtpcrs_stdt.Text = row.Cells[3].Value.ToString();
            }
        }

        private void cmbcrs_du_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }         
    }
}
