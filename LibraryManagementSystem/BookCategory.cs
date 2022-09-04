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
    public partial class frmbookcategory : Form
    {
        public frmbookcategory()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void frmbookcategory_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnbkcat_add;
            fill();
        }

        void fill()
        {
            con.Open();
            string select = "SELECT [ID],[Cat_NO],[Name] FROM [Library_Management_System].[dbo].[Book_Category]";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrbkcat.ReadOnly = true;
            dgrbkcat.DataSource = dt;
            dgrbkcat.Columns[0].Visible = false;
            con.Close();
        }

        private void txtbkcat_no1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtbkcat_ttl1.Text = "";
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Library_Management_System].[dbo].[Book_Category] WHERE (Cat_NO='" + txtbkcat_no1.Text + "')", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lblid.Text = rdr.GetValue(0).ToString();
                    txtbkcat_ttl1.Text = rdr.GetValue(2).ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void ClearData()
        {
            txtbkcat_no1.Text ="";
            txtbkcat_ttl1.Text="";
        }

        private void btnbkcat_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [ID]
      ,[Cat_NO]
      ,[Name]
  FROM [dbo].[Book_Category] where Cat_NO='"+txtbkcat_no1.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    if ((txtbkcat_no1.Text != "") && (txtbkcat_ttl1.Text != ""))
                    {
                        con.Open();
                        string query = "INSERT INTO [Library_Management_System].[dbo].[Book_Category]([Cat_NO],[Name]) VALUES (N'" + this.txtbkcat_no1.Text + "',N'" + this.txtbkcat_ttl1.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Done");
                        ClearData();
                        fill();
                    }
                    else
                    {
                        MessageBox.Show("Please add No & Name to add");
                    }
                }

                else
                {
                    MessageBox.Show("Category number already exist !","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnbkcat_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtbkcat_no1.Text == "") && !(txtbkcat_ttl1.Text == ""))
                {
                    con.Open();
                    string query = "UPDATE [Library_Management_System].[dbo].[Book_Category] SET [Cat_NO] =N'" + txtbkcat_no1.Text + "' ,[Name]=N'" + txtbkcat_ttl1.Text + "' WHERE [ID]='"+lblid.Text+"'";
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

        private void btnbkcat_exit_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Are you Sure ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (s == DialogResult.Yes)
            {
                //frmbookcategory.
            }
        }

        private void btnbkcat_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtbkcat_no1.Text == "") && !(txtbkcat_ttl1.Text == ""))
                {
                    con.Open();
                    string query = "DELETE FROM [Library_Management_System].[dbo].[Book_Category] WHERE [ID]='" + lblid.Text + "' ";
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

        private void frmbookcategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmsettingsnew obj = new frmsettingsnew();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnbkcat_refresh_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dgrbkcat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = this.dgrbkcat.Rows[i];
                lblid.Text = row.Cells[0].Value.ToString();
                txtbkcat_no1.Text = row.Cells[1].Value.ToString();
                txtbkcat_ttl1.Text = row.Cells[2].Value.ToString();
            }
        }

    }
}
