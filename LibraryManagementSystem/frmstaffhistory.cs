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
   public partial class frmstaffhistory : Form
    {
       SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        public frmstaffhistory()
        {
            InitializeComponent();
        }

        void searchborrow()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT [ID]
      ,[Member_ID]
      ,[Book_ID]
      ,[Issu_Date]
      ,[Return_Date]
  FROM [dbo].[Transaction_History] where Member_ID like N'%" + txtstaffhis.Text + "%' and Member_Type='staff'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtrec = new DataTable();

                da.Fill(dtrec);
                dataGridViewX1.DataSource = dtrec;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        
        void searchdamaged()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT [Receipt_NO]
      ,[Action_Type]
      ,[Page]
      ,[Fine_Value]
      ,[Book_ID]
      ,[Member_ID]
      ,[Fine_Date]
  FROM [dbo].[Damage_Fine] where Member_ID like N'%" + txtstaffhis.Text + "%' and Member_Type='staff'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtrec = new DataTable();

                da.Fill(dtrec);
                dataGridViewX3.DataSource = dtrec;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void searchlost()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT [Receipt_No]
      ,[Action_Type]
      ,[Fine_Value]
      ,[Book_ID]
      ,[Member_ID]
      ,[Fine_Date]
  FROM [dbo].[Lost_Fine] where Member_ID like N'%" + txtstaffhis.Text + "%' and Member_Trpe='staff'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtrec = new DataTable();

                da.Fill(dtrec);
                dataGridViewX4.DataSource = dtrec;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void fillbookborrow()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                string select = @"SELECT [ID]
      ,[Member_ID]
      ,[Book_ID]
      ,[Issu_Date]
      ,[Return_Date]
  FROM [dbo].[Transaction_History] where Member_Type='staff'";
                SqlDataAdapter da = new SqlDataAdapter(select, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(dt);
                dataGridViewX1.ReadOnly = true;
                dataGridViewX1.DataSource = dt;
                dataGridViewX1.Dock = DockStyle.Fill;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
        }

        void filldamaged()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                string select = @"SELECT [Receipt_NO]
      ,[Action_Type]
      ,[Page]
      ,[Fine_Value]
      ,[Book_ID]
      ,[Member_ID]
      ,[Fine_Date]
  FROM [dbo].[Damage_Fine] where Member_Type='staff'";
                SqlDataAdapter da = new SqlDataAdapter(select, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(dt);
                dataGridViewX3.ReadOnly = true;
                dataGridViewX3.DataSource = dt;
                dataGridViewX3.Dock = DockStyle.Fill;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
        }

        void filllost()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                string select = @"SELECT [Receipt_No]
      ,[Action_Type]
      ,[Fine_Value]
      ,[Book_ID]
      ,[Member_ID]
      ,[Fine_Date]
  FROM [dbo].[Lost_Fine] where Member_Trpe='staff'";
                SqlDataAdapter da = new SqlDataAdapter(select, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(dt);
                dataGridViewX4.ReadOnly = true;
                dataGridViewX4.DataSource = dt;
                dataGridViewX4.Dock = DockStyle.Fill;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
        }

        private void frmstaffhistory_Load(object sender, EventArgs e)
        {
            fillbookborrow();
            filldamaged();
            filllost();
        }

        private void txtstaffhis_TextChanged(object sender, EventArgs e)
        {
            if (txtstaffhis.Text == "")
            {
                fillbookborrow();
                filldamaged();
                filllost();
            }

            else
            {
                searchborrow();
                searchdamaged();
                searchlost();
            }
        }
    }
}
