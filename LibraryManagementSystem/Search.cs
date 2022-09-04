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
    public partial class frmsearch : Form
    {
        public frmsearch()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        private void frmsearch_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnsrh;
        }

        private void btnsrh_Click(object sender, EventArgs e)
        {
            SearchNow();
        }

        public void SearchNow()
        {
            try
            {
                con.Open();
                if (cmbsrch.Text == "Book")
                {
                    SqlCommand cmd = new SqlCommand("SELECT [Book_ID],[Availability],[Title],[Category],[ISBN],[DDC_No],[Author],[Publisher],[Recieved_By]FROM [Library_Management_System].[dbo].[Book] WHERE ([Book_ID] like'%" + txtsrh.Text + "%' or [Title] like'%" + txtsrh.Text + "%' or [Category] like'%" + txtsrh.Text + "%' or [Author] like'%" + txtsrh.Text + "%' or [Publisher] like'%" + txtsrh.Text + "%' or [Recieved_By] like'%" + txtsrh.Text + "%') and [Availability]='available'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtrec = new DataTable();
                    da.Fill(dtrec);
                    drgsrch.DataSource = dtrec;
                }
                if (cmbsrch.Text == "Digital Media")
                {
                    SqlCommand cmd = new SqlCommand("SELECT [Digital_ID],[Title],[Author],[Cateory]  FROM [Library_Management_System].[dbo].[Digital_Media] WHERE ([Digital_ID] like'%" + txtsrh.Text + "%' or [Title] like'%" + txtsrh.Text + "%' or [Author] like'%" + txtsrh.Text + "%' or [Cateory] like'%" + txtsrh.Text + "%' )",con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtrec = new DataTable();
                    da.Fill(dtrec);
                    drgsrch.DataSource = dtrec;
                }
                if (cmbsrch.Text == "Magazine")
                {
                    SqlCommand cmd = new SqlCommand("SELECT [Magazine_ID],[Name],[Category] FROM [Library_Management_System].[dbo].[Magazine] WHERE ([Magazine_ID] like'%" + txtsrh.Text + "%' or [Name] like'%" + txtsrh.Text + "%' or [Category] like'%" + txtsrh.Text + "%')",con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtrec = new DataTable();
                    da.Fill(dtrec);
                    drgsrch.DataSource = dtrec;
                }
                if (cmbsrch.Text == "Student")
                {
                    SqlCommand cmd = new SqlCommand("SELECT [Member_ID],[Admission_NO],[Name] FROM [Library_Management_System].[dbo].[Student_Member] WHERE ([Member_ID] like'%" + txtsrh.Text + "%' or [Admission_NO] like'%" + txtsrh.Text + "%' or [Name] like'%" + txtsrh.Text + "%')", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtrec = new DataTable();
                    da.Fill(dtrec);
                    drgsrch.DataSource = dtrec;
                }
                if (cmbsrch.Text == "Staff")
                {
                    SqlCommand cmd = new SqlCommand("SELECT [Member_ID],[Name] FROM [Library_Management_System].[dbo].[Staff_Member] WHERE ([Member_ID] like'%" + txtsrh.Text + "%' or [Name] like'%" + txtsrh.Text + "%')", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtrec = new DataTable();
                    da.Fill(dtrec);
                    drgsrch.DataSource = dtrec;
                }
           
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
