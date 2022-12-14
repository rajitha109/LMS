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
    public partial class frmrptStudent : Form
    {
        Reports.CrystalReportStudent strep = new Reports.CrystalReportStudent();

        public frmrptStudent()
        {
            InitializeComponent();
        }

        private void frmrptStudent_Load(object sender, EventArgs e)
        {
            try
            {
                strep.Load(@"C:\Users\Public\Videos\FinalCopy\LibraryManagementSystem\LibraryManagementSystem\CrystalReportStudent.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("Studentreport", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Studentreport");
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
