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
    public partial class frmemplev : Form
    {
        public frmemplev(string empno, string name, string designation)
        {
            InitializeComponent();
            lbleid1.Text = empno;
            lblName2.Text = name;
            lblDsg2.Text = designation;
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        private void frmemplev_Load(object sender, EventArgs e)
        {
            this.AcceptButton = buttonX1;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = GetWorkingDays(dateTimePicker1.Value, dateTimePicker2.Value);

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO EmpLeave (EmpNo, FromDate, ToDate, NoOfDates) VALUES (@empno, @fromdate, @todate, @noofdates)", con);
                cmd.Parameters.AddWithValue("@empno", lbleid1.Text);
                cmd.Parameters.AddWithValue("@fromdate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@todate", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@noofdates", a.ToString());

                MessageBox.Show(a.ToString());

                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //int a = GetWorkingDays(dateTimePicker1.Value, dateTimePicker2.Value);         

            buttonX1.Enabled = false;
        }

        public int GetWorkingDays(DateTime from, DateTime to)
        {
            var totalDays = 0;
            for (var date = from; date <= to; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    totalDays++;
                }
            }

            return totalDays;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}