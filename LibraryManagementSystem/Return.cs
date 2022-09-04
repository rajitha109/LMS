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
    public partial class frmreturn : Form
    {
        public frmreturn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");


        private void Return_Load(object sender, EventArgs e)
        {
            txtrtnbk_id.Focus();
            this.AcceptButton = btnrtn;

        }

        private void txtrtnbk_id_TextChanged(object sender, EventArgs e)
        {
            if (txtrtnbk_id.Text != "")
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Borrow WHERE (Book_ID ='" + txtrtnbk_id.Text + "') ", con);
                SqlDataReader dr = cmd.ExecuteReader();


                try
                {


                    if (dr.Read())
                    {
                        txtrtnm_type.Text = dr.GetValue(2).ToString();
                        lblissudate.Text=dr.GetValue(3).ToString();
                        txtduedate.Text = dr.GetValue(4).ToString();
                        txtrtnm_id.Text = dr.GetValue(1).ToString();

                        con.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Book ID is Not  Exicites");
                    con.Close();

                }
                con.Close();
            }
        }

        private void txtrtnm_id_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            Delayfine();
            ReceiptGen();
            ColorFocus();
        }

        private void btnrtn_paid_Click(object sender, EventArgs e)
        {
            SaveDelayFine();
        }

        private void btnrtn_refresh_Click(object sender, EventArgs e)
        {
            mclear();
        }
        public void mclear()
        {
            txtrtnbk_id.Text = "";
            txtrtnm_id.Text = "";
            txtduedate.Text = "";
            txtrtnm_type.Text = "";
            lblrtn_fine.Text = "";
            lblrtn_recpt.Text = "";
        }

        private void btnrtn_Click(object sender, EventArgs e)
        {


            if (txtrtnbk_id.Text != "" && txtrtnm_id.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Borrow WHERE Book_ID=@bkid", con);
                cmd.Parameters.Add(new SqlParameter("@bkid", txtrtnbk_id.Text));

                DateTime dtm = DateTime.Now;
                string insert = "INSERT INTO [Library_Management_System].[dbo].[Transaction_History]([Member_ID],[Book_ID],[Member_Type],[Issu_Date],[Return_Date]) VALUES ('" + txtrtnm_id.Text + "','" + txtrtnbk_id.Text + "','" + txtrtnm_type.Text+ "','"  + lblissudate.Text + "','" + dtm + "')";
                SqlCommand cmd1 = new SqlCommand(insert, con);
                cmd1.ExecuteNonQuery();

                string avb = "available";
                string upd = "UPDATE Book SET Availability='" + avb + "' WHERE (Book_ID='" + txtrtnbk_id.Text + "')";
                SqlCommand command = new SqlCommand(upd, con);
                command.ExecuteNonQuery();

                
                DialogResult s = MessageBox.Show("Are You Sure Want to Return the Book", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (s == DialogResult.Yes)
                {
                    try
                    {

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book Has Returned  Successfully");

                        mclear();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);


                    }
                    con.Close();

                }


            }
            else
            {
                MessageBox.Show("Please Enter The Book's Id  and Member's ID  ");

            }
            mclear();

        }

        public void Delayfine()//Create and display delay dine
        {
            try
            {
                con.Open();
                string dt = txtduedate.Text;
                DateTime duedate = DateTime.Parse(dt);
                string curun = "Rs";

                if (txtrtnm_type.Text == "Student")
                {
                    if (duedate < DateTime.Now)
                    {
                        TimeSpan span = DateTime.Now.Subtract(duedate);//Difference between due date and now
                        int finedate = (int)span.Days;

                        SqlCommand cmd_vlu = new SqlCommand("SELECT * FROM [Library_Management_System].[dbo].[Fine_Creator]", con);
                        SqlDataReader finereader = cmd_vlu.ExecuteReader();

                        if (finedate > 28)
                        {
                            if (finereader.Read())
                            {
                                lblrtn_fine.Text = curun + finereader["4th_Week"].ToString();
                            }
                        }
                        if (finedate > 21)
                        {
                            if (finereader.Read())
                            {
                                lblrtn_fine.Text = curun + finereader["3rd_Week"].ToString();
                            }
                        }
                        if (finedate > 14)
                        {
                            if (finereader.Read())
                            {
                                lblrtn_fine.Text = curun + finereader["2nd_Week"].ToString();
                            }
                        }
                        if (finedate > 7)
                        {
                            if (finereader.Read())
                            {
                                lblrtn_fine.Text = curun + finereader["1st_Week"].ToString();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void ReceiptGen()//Genorate receipt for delay fine
        {
            if (txtrtnm_type.Text == "Student")
            {
                string rstp = "HTC/f";
                con.Open();
                SqlCommand cmd_gen = new SqlCommand("SELECT COUNT([Receipt_No]) FROM [Library_Management_System].[dbo].[Delay_Fine] ", con);
                int i = Convert.ToInt32(cmd_gen.ExecuteScalar());
                con.Close();
                i++;
                lblrtn_recpt.Text = rstp + i.ToString();
            }
        }
        public void SaveDelayFine()
        {
            try
            {
                if (!(txtrtnbk_id.Text == "") && !(txtrtnm_id.Text == "") && !(lblrtn_fine.Text == "") && !(lblrtn_recpt.Text == ""))
                {
                    con.Open();
                    string query = "INSERT INTO [Library_Management_System].[dbo].[Delay_Fine]([Receipt_No],[Action_Type],[Fine_Value],[Book_ID],[Member_ID],[Fine_Date]) VALUES('" + this.lblrtn_recpt.Text + "','" + "Return delay" + "','" + this.lblrtn_fine.Text + "','" + this.txtrtnbk_id.Text + "','" + this.txtrtnm_id.Text + "','" + DateTime.Now.ToShortDateString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Left flieds");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                con.Close();
            }
            con.Close();
        }

        public void ColorFocus()
        {
            string dt = txtduedate.Text;
            DateTime duedate = DateTime.Parse(dt);
            if (txtrtnm_type.Text == "Student" && duedate < DateTime.Now)
            {
                lblrtn_fine.Focus();
                lblrtn_recpt.Focus();
            }
        }
    }
}

