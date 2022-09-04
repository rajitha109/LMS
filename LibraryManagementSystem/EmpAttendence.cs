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
    public partial class EmpAttendence : Form
    {

        public EmpAttendence(string empno,string name,string desig)
        {
            InitializeComponent();
            lbleid.Text = empno;
            lblName1.Text = name;
            lblDsg1.Text = desig;
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        private void EmpAttendence_Load(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = DateTime.Now.ToLongDateString();
                check();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                var date = DateTime.Now.Date;
                var time = DateTime.Now.TimeOfDay;

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO EmpAttendence (EmpNo, Date, InTime) VALUES (@empno, @date, @timein )", con);

                cmd.Parameters.AddWithValue("@empno", lbleid.Text);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@timein", time);

                cmd.ExecuteNonQuery();

                txtIn.Text = DateTime.Now.ToLongTimeString();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult s = MessageBox.Show("Confirmtion", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (s == DialogResult.Yes)
                {
                    var date = DateTime.Now.Date;
txtOut.Text = DateTime.Now.ToLongTimeString();

                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[EmpAttendence]
   SET [OutTime] = '"+txtOut.Text+"' WHERE [EmpNo] = '"+lbleid.Text+"' and [Date] = '"+date+"'", con);
//                    cmd.Parameters.AddWithValue("@dateout", DateTime.Now); cmd.Parameters.AddWithValue("@empno", lbleid.Text);
//                    cmd.Parameters.AddWithValue("@date", date);
                    //MessageBox.Show("11");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    
                }

                else
                {
                    txtOut.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void check()
        {
            try
            {
                con.Open();
                var date = DateTime.Now.ToString("yyyy-MM-dd");
                //MessageBox.Show(date);
                SqlCommand cmd = new SqlCommand("SELECT EmpNo, Date, OutTime FROM EmpAttendence WHERE EmpNo = @empno and Date = @date", con);
                //cmd.Parameters.AddWithValue("@empno", txtEmpNo.Text);
                cmd.Parameters.AddWithValue("@empno", lbleid.Text);
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //MessageBox.Show("11111");                    
                    btnIn.Enabled = false;

                    if (dr.Read())
                    {
                        if (dr["OutTime"].ToString() != "")
                        {
                            btnOut.Enabled = false;
                        }
                    }

                }

                else
                {
                    //MessageBox.Show("22222");
                    btnIn.Enabled = true;
                    btnOut.Enabled = false;
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
