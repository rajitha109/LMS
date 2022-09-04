using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class frmrptalldigital : Form
    {

        Reports.CrystalReportalldigitl strep = new Reports.CrystalReportalldigitl();

        public frmrptalldigital()
        {
            InitializeComponent();
        }

        private void frmrptalldigital_Load(object sender, EventArgs e)
        {
            try
            {
                strep.Load(@"C:\Users\Public\Music\FinalCopy\LibraryManagementSystem\LibraryManagementSystem\Reports\CrystalReportalldigitl.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("rptalldigital", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "rptalldigital");
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
