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
    public partial class frmrptmissed : Form
    {
        Reports.CrystalReportmissed strep = new Reports.CrystalReportmissed();

        public frmrptmissed()
        {
            InitializeComponent();
        }

        private void frmrptmissed_Load(object sender, EventArgs e)
        {
            try
            {
                strep.Load(@"C:\Users\Public\Music\FinalCopy\LibraryManagementSystem\LibraryManagementSystem\Reports\CrystalReportmissed.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("rptmissplaced", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "rptmissplaced");
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
