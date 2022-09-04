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
    public partial class frmstuhis : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        public frmstuhis()
        {
            InitializeComponent();
            fillbookborrow();
            filldamaged();
            filldelay();
            filllost();
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
  FROM [dbo].[Transaction_History] where Member_ID like N'%" + txtstuhis.Text + "%' and Member_Type='student'", con);

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

        void searchdelay()
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
  FROM [dbo].[Delay_Fine] where Member_ID like N'%" + txtstuhis.Text + "%'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtrec = new DataTable();

                da.Fill(dtrec);
                dataGridViewX2.DataSource = dtrec;
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
  FROM [dbo].[Damage_Fine] where Member_ID like N'%" + txtstuhis.Text + "%' and Member_Type='student'", con);

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
  FROM [dbo].[Lost_Fine] where Member_ID like N'%" + txtstuhis.Text + "%' and Member_Trpe='student'", con);

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
  FROM [dbo].[Transaction_History] where Member_Type='student'";
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

        void filldelay()
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
  FROM [dbo].[Delay_Fine]";
                SqlDataAdapter da = new SqlDataAdapter(select, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(dt);
                dataGridViewX2.ReadOnly = true;
                dataGridViewX2.DataSource = dt;
                dataGridViewX2.Dock = DockStyle.Fill;
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
  FROM [dbo].[Damage_Fine] where Member_Type='student'";
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
  FROM [dbo].[Lost_Fine] where Member_Trpe='student'";
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

        private void tabStrip1_Click(object sender, EventArgs e)
        {
            
        }

        private void superTabItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmstuhis_Load(object sender, EventArgs e)
        {
            fillbookborrow();
            filldamaged();
            filldelay();
            filllost();
            loadpoints();
        }

        private void superTabItem2_Click(object sender, EventArgs e)
        {
            //filldelay();
        }

        private void superTabItem3_Click(object sender, EventArgs e)
        {
            //filldamaged();
        }

        private void superTabItem4_Click(object sender, EventArgs e)
        {
            //filllost();
        }

        private void superTabItem5_Click(object sender, EventArgs e)
        {
            //loadpoints();
        }

        private void txtstuhis_TextChanged(object sender, EventArgs e)
        {
            if (txtstuhis.Text == "")
            {
                fillbookborrow();
                filldamaged();
                filldelay();
                filllost();
                loadpoints();
            }

            else
            {
                searchborrow();
                searchdamaged();
                searchdelay();
                searchlost();
                searchpoint();
            }
        }


        void medal()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [Points],[Student_ID]
      FROM [dbo].[Points]", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    con.Open();
                    string medal = "";
                    string index = dt.Rows[i][0].ToString();
                    string student = dt.Rows[i][1].ToString();

                    if (Convert.ToDecimal(index) == 0)
                    {
                        medal = "Did not Borrow Any Book";
                    }

                    else if (Convert.ToDecimal(index) < 25)
                    {
                        medal = "Bronze";
                    }

                    else if (Convert.ToDecimal(index) < 50)
                    {
                        medal = "silver";
                    }

                    else if (Convert.ToDecimal(index) < 75)
                    {
                        medal = "Gold";
                    }

                    else if (Convert.ToDecimal(index) <= 100)
                    {
                        medal = "Platinum";
                    }

                    else
                    {
                        medal = "No";
                    }
                    SqlCommand cmd5 = new SqlCommand(@"UPDATE [dbo].[Points]
   SET [Medal] = '" + medal + "'where Student_ID='" + student + "'", con);
                    cmd5.ExecuteNonQuery();
                    con.Close();


                    //MessageBox.Show(dt.Rows[i][0].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fill()
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            string select = @"SELECT [Student_ID]
      ,[Student_Name]
      ,[Course_Name]
      ,[Course_Duration]
      ,[Books_Borrowed]
      ,[Points]
       ,[Medal]
  FROM [dbo].[Points]";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            dataGridViewX5.ReadOnly = true;
            dataGridViewX5.DataSource = dt;
            dataGridViewX5.Dock = DockStyle.Fill;
        }

        void calculatepoint()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [Student_ID]
      FROM [dbo].[Points]", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    con.Open();
                    string index = dt.Rows[i][0].ToString();
                    SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[Points]
   SET [Points] = (select (cast(Books_Borrowed as decimal(18,2))/(cast(Course_Duration as decimal(18,2))*4))*100 from Points where Student_ID='" + index + "')WHERE Student_ID='" + index + "'", con);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show(dt.Rows[i][0].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void update()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [Student_ID]
      FROM [dbo].[Points]", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    con.Open();
                    string index = dt.Rows[i][0].ToString();
                    SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[Points]
   SET [Books_Borrowed] = (select count(Member_ID) from Transaction_History where Member_ID='" + index + "')WHERE Student_ID='" + index + "'", con);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show(dt.Rows[i][0].ToString());
                }


                /*if (dt.Rows.Count > 0)
                {
                    con.Open();
                    string index = dt.Rows[0][0].ToString();
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Points]
   SET [Books_Borrowed] = (select count(Member_ID) from Transaction_History where Member_ID='"+index+"')WHERE Student_ID='"+index+"'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }*/
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void loadpoints()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Points]
           ([Student_ID]
           ,[Student_Name]
           ,[Course_Name]
           ,[Course_Duration])
select Student_Member.Member_ID,Student_Member.Name,Course.Name,Course.Duration
from Student_Member
join Course
on Student_Member.Course_ID=Course.Course_ID
", con);
                SqlCommand cmd1 = new SqlCommand(@"DELETE FROM [dbo].[Points]", con);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                update();
                calculatepoint();
                medal();
                fill();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void searchpoint()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT [Student_ID]
      ,[Student_Name]
      ,[Course_Name]
      ,[Course_Duration]
      ,[Books_Borrowed]
      ,[Points]
      ,[Medal]
  FROM [dbo].[Points] where Student_ID like N'%" + txtstuhis.Text + "%'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtrec = new DataTable();

                da.Fill(dtrec);
                dataGridViewX5.DataSource = dtrec;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
