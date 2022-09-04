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
    public partial class frminfo : Form
    {
        public frminfo()
        {
            InitializeComponent();
            CountDisplay();
            //SpecificCount();
        }
        string cal;
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public void CountDisplay()
        {
            try
            {
                con.Open();
                //Total book count
                SqlCommand cmd_bk = new SqlCommand("SELECT COUNT(*) AS Length FROM [Library_Management_System].[dbo].[Book]", con);
                int bk = Convert.ToInt32(cmd_bk.ExecuteScalar());
                lblinfo_bkdis.Text = bk.ToString();

                //Total Student count
                SqlCommand cmd_st = new SqlCommand("SELECT COUNT(*) AS Length FROM [Library_Management_System].[dbo].[Student_Member]", con);
                int st = Convert.ToInt32(cmd_st.ExecuteScalar());
                lblinfo_studis.Text = st.ToString();

                //Total Staff member count
                SqlCommand cmd_sf = new SqlCommand("SELECT COUNT(*) AS Length FROM [Library_Management_System].[dbo].[Staff_Member]", con);
                int sf = Convert.ToInt32(cmd_sf.ExecuteScalar());
                lblinfo_stfdis.Text = sf.ToString();

                //Total Digital Media count
                SqlCommand cmd_dg = new SqlCommand("SELECT COUNT(*) AS Length FROM [Library_Management_System].[dbo].[Digital_Media]", con);
                int dg = Convert.ToInt32(cmd_dg.ExecuteScalar());
                lblinfo_digi.Text = dg.ToString();

                //Total Magazine count
                SqlCommand cmd_mg = new SqlCommand("SELECT COUNT(*) AS Length FROM [Library_Management_System].[dbo].[Digital_Media]", con);
                int mg = Convert.ToInt32(cmd_mg.ExecuteScalar());
                lblinfo_mag.Text = mg.ToString();

                //Total Avalible Book count
                SqlCommand cmd_ab = new SqlCommand("SELECT COUNT(Availability) FROM Book WHERE Availability = 'available'", con);
                int count = 0;
                count = (int)cmd_ab.ExecuteScalar();
                lblinfo_abkdis.Text = count.ToString();

                //Total Rfrence Book count
                SqlCommand cmd_rf = new SqlCommand("SELECT COUNT(Reference) FROM Book WHERE Reference = 'True'", con);
                int cal = 0;
                cal = (int)cmd_rf.ExecuteScalar();
                lblinfo_rbkdis.Text = cal.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void frminfo_Load(object sender, EventArgs e)
        {
            
            TransparencyKey = Color.Lime;
            
            
        }
    }
}
