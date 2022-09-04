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
    public partial class frmcrtfine : Form
    {
        public frmcrtfine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        private void frmcrtfine_Load(object sender, EventArgs e)
        {
            Display();
            this.AcceptButton = btncrtfn_aply;
        }

        private void btncrtfn_aply_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtcrtfn_1wk.Text == "") && !(txtcrtfn_2wk.Text == "") && !(txtcrtfn_3wk.Text == "") && !(txtcrtfn_4wk.Text == ""))
                {
                    con.Open();

                    string query = "UPDATE [Library_Management_System].[dbo].[Fine_Creator] SET [1st_Week]=N'" + txtcrtfn_1wk.Text + "',[2nd_Week]=N'" + txtcrtfn_2wk.Text + "',[3rd_Week]=N'" + txtcrtfn_3wk.Text + "',[4th_Week]=N'" + txtcrtfn_4wk.Text + "' WHERE ([Fine_Creator_ID]=2000)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Left fild");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error");
            }
        }

        public void Display()//Display data in text box
        {
            con.Open();
            SqlCommand cmd_dis = new SqlCommand("SELECT * FROM [Library_Management_System].[dbo].[Fine_Creator]",con);
            SqlDataReader finedis = cmd_dis.ExecuteReader();

            while (finedis.Read())
            {
                txtcrtfn_1wk.Text = finedis["1st_Week"].ToString();
                txtcrtfn_2wk.Text = finedis["2nd_Week"].ToString();
                txtcrtfn_3wk.Text = finedis["3rd_Week"].ToString();
                txtcrtfn_4wk.Text = finedis["4th_Week"].ToString();
            }
            con.Close();
        }

        private void btncrtfn_rfsh_Click(object sender, EventArgs e)
        {
            txtcrtfn_1wk.Clear();
            txtcrtfn_2wk.Clear();
            txtcrtfn_3wk.Clear();
            txtcrtfn_4wk.Clear();
        }      
    }
}
