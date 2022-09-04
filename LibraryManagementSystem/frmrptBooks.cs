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
    public partial class frmrptBooks : Form
    {
        Reports.CrystalReportBooks strep = new Reports.CrystalReportBooks();

        public frmrptBooks()
        {
            InitializeComponent();
        }

        private void frmrptBooks_Load(object sender, EventArgs e)
        {
            try
            {
                strep.Load(@"C:\Users\Public\Videos\FinalCopy\LibraryManagementSystem\LibraryManagementSystem\CrystalReportBooks.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("Booksreport", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Booksreport");
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
