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
using CrystalDecisions.CrystalReports.Engine;

namespace LibraryManagementSystem
{
    public partial class frmrptissued : Form
    {
        Reports.CrystalReportissued strep = new Reports.CrystalReportissued();

        public frmrptissued()
        {
            InitializeComponent();
        }

        private void frmrptissued_Load(object sender, EventArgs e)
        {
            try
            {
                strep.Load(@"C:\Users\Public\Music\FinalCopy\LibraryManagementSystem\LibraryManagementSystem\Reports\CrystalReportissued.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("rptissued", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "rptissued");
                strep.SetDataSource(ds);
                crystalReportViewer1.ReportSource = strep;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
