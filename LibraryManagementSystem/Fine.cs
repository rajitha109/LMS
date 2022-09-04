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
    public partial class frmfine : Form
    {
        public frmfine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");


        private void frmfine_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnfine_paid;
        }

        private void btnfine_chk_Click(object sender, EventArgs e)
        {
            AutoFillData();

            if (cmbfine_act.Text == "Return delay")
            {
                if (txtfinem_type.Text == "Student")
                {
                    CalDelayFine();
                    ReceiptGen();
                }
                else
                {
                    MessageBox.Show("Delay fine not avalible for staff members");
                }
            }
        }

        private void btnfine_paid_Click(object sender, EventArgs e)
        {
            if (cmbfine_act.Text == "Return delay")
            {
                SaveDelayFine();
            }
            else if (cmbfine_act.Text == "Damage")
            {
                SaveDamageFine();
            }
            else if(cmbfine_act.Text == "Lost")
            {
                SaveLostFine();
            }
        }

        private void btnfine_rfsh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cmbfine_act_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfine_act.Text == "Damage")
            {
                txtfine_pg.Enabled = true;
            }
            else
            {
                txtfine_pg.Enabled = false;
            }

            if (cmbfine_act.Text == "Return delay")
            {
                txtfine_duedt.Enabled = true;
            }
            else
            {
                txtfine_duedt.Enabled = false;
            }
        }

        private void txtfine_bkid_TextChanged(object sender, EventArgs e)
        {
            if (!(txtfine_bkid.Text == ""))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Borrow WHERE (Book_ID ='" + txtfine_bkid.Text + "') ", con);
                SqlDataReader dr = cmd.ExecuteReader();

                try
                {
                    if (dr.Read())
                    {
                        txtfinem_type.Text = dr.GetValue(2).ToString();
                        txtfine_mid.Text = dr.GetValue(1).ToString();
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

        public void AutoFillData()//Auto fill details with input id
        {
            try
            {
                if (!(cmbfine_act.Text == "") && !(txtfine_bkid.Text == "") && !(txtfine_mid.Text == ""))
                {
                    string BID = Convert.ToString(txtfine_bkid.Text);
                    Library_Management_SystemEntities bc1 = new Library_Management_SystemEntities();
                    var bkrec = bc1.Books.Where(b => b.Book_ID == BID).SingleOrDefault();
                    Library_Management_SystemEntities bc2 = new Library_Management_SystemEntities();
                    var durec = bc2.Borrows.Where(d => d.Book_ID == BID).SingleOrDefault();

                    txtfine_bkttl.Text = bkrec.Title;
                    txtfine_bkcat.Text = bkrec.Category;
                    txtfine_bkddc.Text = bkrec.DDC_No;

                    if (cmbfine_act.Text == "Return delay")//Due date only available in delay fine
                    {
                        txtfine_duedt.Text = durec.Due_Date.ToShortDateString();
                    }

                    if (txtfinem_type.Text == "Staff")
                    {
                        string MID = Convert.ToString(txtfine_mid.Text);
                        Library_Management_SystemEntities mc = new Library_Management_SystemEntities();
                        var sfrec = mc.Staff_Member.Where(f => f.Member_ID == MID).SingleOrDefault();
                        txtfine_mname.Text = sfrec.Name;
                    }

                    else if (txtfinem_type.Text == "Student")
                    {
                        string MID = Convert.ToString(txtfine_mid.Text);
                        Library_Management_SystemEntities mc = new Library_Management_SystemEntities();
                        var strec = mc.Student_Member.Where(t => t.Member_ID == MID).SingleOrDefault();
                        txtfine_mname.Text = strec.Name;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill fileds");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void CalDelayFine()//Calculate delay fine
        {
            try
            {
                con.Open();
                string dt = txtfine_duedt.Text;
                DateTime duedate = DateTime.Parse(dt);
                string curun = "Rs";

                if (cmbfine_act.Text == "Return delay" && txtfinem_type.Text == "Student")
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
                                txtfine_vlu.Text = curun+finereader["4th_Week"].ToString();
                            }
                        }
                        if (finedate > 21)
                        {
                            if (finereader.Read())
                            {
                                txtfine_vlu.Text = curun+finereader["3rd_Week"].ToString();
                            }
                        }
                        if (finedate > 14)
                        {
                            if (finereader.Read())
                            {
                                txtfine_vlu.Text = curun+finereader["2nd_Week"].ToString();
                            }
                        }
                        if (finedate > 7)
                        {
                            if (finereader.Read())
                            {
                                txtfine_vlu.Text = curun+finereader["1st_Week"].ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delay fine not ");
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
            string rstp = "HTC/f";
            con.Open();
            SqlCommand cmd_gen = new SqlCommand("SELECT COUNT([Receipt_No]) FROM [Library_Management_System].[dbo].[Delay_Fine] ", con);
            int i = Convert.ToInt32(cmd_gen.ExecuteScalar());
            con.Close();
            i++;
            txtfine_risit.Text = rstp + i.ToString();
        }

        public void SaveDelayFine()
        {
            try
            {
                if (!(txtfine_bkid.Text == "") && !(txtfine_mid.Text == "") && !(txtfine_vlu.Text == "") && !(txtfine_risit.Text == "")&&!(txtfine_bkttl.Text=="")&&!(txtfine_bkcat.Text=="")&&!(txtfine_duedt.Text=="")&&!(txtfine_mname.Text==""))
                {
                    con.Open();
                    string query = "INSERT INTO [Library_Management_System].[dbo].[Delay_Fine]([Receipt_No],[Action_Type],[Fine_Value],[Book_ID],[Member_ID],[Fine_Date]) VALUES('" + this.txtfine_risit.Text + "','" + this.cmbfine_act.Text + "','" + this.txtfine_vlu.Text + "','" + this.txtfine_bkid.Text + "','" + this.txtfine_mid.Text + "','" + DateTime.Now.ToShortDateString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Left flieds");
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
                con.Close();
            }
            con.Close();
        }

        public void SaveDamageFine()
        {
            try
            {
                if (!(txtfine_bkid.Text == "") && !(txtfine_pg.Text == "") && !(txtfine_mid.Text == "") && !(txtfine_vlu.Text == "") && !(txtfine_risit.Text == ""))
                {
                    con.Open();
                    string query = "INSERT INTO [Library_Management_System].[dbo].[Damage_Fine]([Receipt_NO],[Member_Type],[Action_Type],[Page],[Fine_Value],[Book_ID],[Member_ID],[Fine_Date]) VALUES ('" + this.txtfine_risit.Text + "','" + this.txtfinem_type.Text + "','" + this.cmbfine_act.Text + "','" + this.txtfine_pg.Text + "','" + this.txtfine_vlu.Text + "','" + this.txtfine_bkid.Text + "','" + this.txtfine_mid.Text + "','" + DateTime.Now.ToShortDateString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Left flieds");
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            con.Close();
        }

        public void SaveLostFine()
        {
            try
            {
                if (!(txtfine_bkid.Text == "") && !(txtfine_mid.Text == "") && !(txtfine_vlu.Text == "") && !(txtfine_risit.Text == ""))
                {
                    con.Open();
                    string query = "INSERT INTO [Library_Management_System].[dbo].[Lost_Fine]([Receipt_No],[Member_Trpe],[Action_Type],[Fine_Value],[Book_ID],[Member_ID],[Fine_Date]) VALUES ('" + this.txtfine_risit.Text + "','" + this.txtfinem_type.Text + "','" + this.cmbfine_act.Text + "','" + this.txtfine_vlu.Text + "','" + this.txtfine_bkid.Text + "','" + this.txtfine_mid.Text + "','" + DateTime.Now.ToShortDateString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Left flieds");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            con.Close();
        }

        public void ClearData()
        {
            cmbfine_act.SelectedIndex = -1;
            txtfinem_type.Clear();
            txtfine_bkid.Clear();
            txtfine_bkcat.Clear();
            txtfine_bkddc.Clear();
            txtfine_bkttl.Clear();
            txtfine_mid.Clear();
            txtfine_mname.Clear();
            txtfine_risit.Clear();
            txtfine_vlu.Clear();

            if (!(txtfine_duedt.Text == ""))
            {
                txtfine_duedt.Clear();
            }

            if (!(txtfine_pg.Text == ""))
            {
                txtfine_pg.Clear();
            }
        }
    }
}

