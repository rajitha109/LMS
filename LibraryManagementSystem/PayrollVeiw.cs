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
    public partial class frmPayrollVeiw : Form
    {
        public frmPayrollVeiw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        private void frmPayrollVeiw_Load(object sender, EventArgs e)
        {
            string select = "SELECT * FROM [Library_Management_System].[dbo].[Payroll]";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            grdpay.ReadOnly = true;
            grdpay.DataSource = dt;
            grdpay.Dock = DockStyle.Fill;
        }
    }
}
