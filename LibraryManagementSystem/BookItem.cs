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
    public partial class frmbook : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public frmbook(string userm)
        {
            InitializeComponent();
            lblumode.Text = userm;
            FillCombo();
            cbobk_cat.SelectedIndex = -1;
        }
        

        void user()
        {
            if (lblumode.Text == "Super Admin")
            {
                btnbk_delete.Enabled = true;
            }
        }

        void FillCombo()
        {
            con.Open();
            string query = "SELECT * FROM [Library_Management_System].[dbo].[Book_Category]";
            SqlCommand cmdfill = new SqlCommand(query, con);
            SqlDataReader rdr;
            con.Close();
            try
            {
                con.Open();
                rdr = cmdfill.ExecuteReader();
                while (rdr.Read())
                {
                    string cat = rdr.GetString(2);
                    cbobk_cat.Items.Add(cat);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnbk_save;
            user();

        }

        private void btnSupdate_Click(object sender, EventArgs e)
        {

        }

        private void btn_B_update_Click(object sender, EventArgs e)
        {

        }

        private void grbbkdt_Enter(object sender, EventArgs e)
        {

        }
        public void m_clear()//clear method
        {
            txtbk_id.Clear();
            txtbk_ttl.Clear();
            txtbk_auth.Clear();
            txtbk_ddc.Clear();
            txtbk_edi.Clear();
            txtbk_othrdtls.Clear();
            txtbk_price.Clear();
            txtbk_pubd.Clear();
            txtbk_pub.Clear();
            txtbk__rcivdby.Clear();
            txtbk_isbn.Clear();
            chk_bk_ach.Checked = false;
            chkbk_ref.Checked = false;
            cbobk_cat.SelectedIndex = -1;
            cbobk_lang.SelectedIndex = -1;
            txtbk_id.Focus();
            
        
        
        }

        private void btnbk_refresh_Click(object sender, EventArgs e)
        {
            m_clear();//call clear method
        }
        Double number;

        private void btnbk_fill_Click(object sender, EventArgs e)
        {
           
           
        }
        private void btnbk_add_Click(object sender, EventArgs e)
        {
           
        }

        private void txtbk_id_TextChanged(object sender, EventArgs e)
        {
            
            if (txtbk_id.Text != "")
            {
                txtbk_ttl.Clear();
                txtbk_auth.Clear();
                txtbk_ddc.Clear();
                txtbk_edi.Clear();
                txtbk_othrdtls.Clear();
                txtbk_price.Clear();
                txtbk_pubd.Clear();
                txtbk_pub.Clear();
                txtbk__rcivdby.Clear();
                txtbk_isbn.Clear();
                chk_bk_ach.Checked = false;
                chkbk_ref.Checked = false;
                cbobk_cat.SelectedIndex = -1;
                cbobk_lang.SelectedIndex = -1;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Book WHERE (Book_ID ='" + txtbk_id.Text + "')", con);
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {


                    if (dr.Read())
                    {
                        cbobk_lang.Text = dr.GetValue(1).ToString();
                        txtbk_ttl.Text = dr.GetValue(2).ToString();
                        cbobk_cat.Text = dr.GetValue(3).ToString();
                        txtbk_edi.Text = dr.GetValue(4).ToString();
                        txtbk_ddc.Text = dr.GetValue(6).ToString();

                        txtbk_isbn.Text = dr.GetValue(5).ToString();
                        txtbk_auth.Text = dr.GetValue(7).ToString();
                        txtbk_pub.Text = dr.GetValue(8).ToString();
                        txtbk_pubd.Text = dr.GetValue(9).ToString();
                        txtbk_price.Text = dr.GetValue(11).ToString();
                        txtbk__rcivdby.Text = dr.GetValue(12).ToString();
                        txtbk_othrdtls.Text = dr.GetValue(13).ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                con.Close();
            }

            else
            {
                m_clear();
            }
            
        }

        private void btnbk_refresh_Click_1(object sender, EventArgs e)
        {
            m_clear();//call clear method
        }

        

        private void btnbk_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (txtbk_id.Text != "" && txtbk_ttl.Text != "" && cbobk_cat.Text != "" && txtbk_auth.Text != "" && cbobk_lang.SelectedIndex!=0)
                {



                    string insert = "INSERT INTO [Library_Management_System].[dbo].[Book]([Book_ID],[Language],[Title],[Category],[Edition],[ISBN],[DDC_No],[Author],[Publisher],[Publication_Date],[Attachment],[Price],[Recieved_By],[Other_Details],[Reference],[Availability]) VALUES (N'" + txtbk_id.Text + "','"+cbobk_lang.Text+"',N'" + txtbk_ttl.Text + "',N'" + cbobk_cat.Text + "',N'" + txtbk_edi.Text + "',N'" + txtbk_isbn.Text + "','" + txtbk_ddc.Text + "',N'" + txtbk_auth.Text + "',N'" + txtbk_pub.Text + "',N'" + txtbk_pubd.Text + "',N'" + chk_bk_ach.Checked + "',N'" + txtbk_price.Text + "',N'" + txtbk__rcivdby.Text + "',N'" + txtbk_othrdtls.Text + "',N'" + chkbk_ref.Checked + "',N'" + "available" + "')";
                                  
                    SqlCommand cmd = new SqlCommand(insert, con);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully inserted");
                    m_clear();
                    
                    

                }
                else if(txtbk_id.Text=="")
                {
                    MessageBox.Show("Please Enter The Book ID");
                    

                }
                else if (cbobk_lang.SelectedIndex==-1)
                {
                    MessageBox.Show("Please Select The Category");
                }
                
                else if (txtbk_ttl.Text=="")
                {
                    MessageBox.Show("Please Enter The Title");

                }
                else if (cbobk_cat.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select The Category");
                }
                else if (txtbk_auth.Text == "")
                {
                    MessageBox.Show("Please Enter The Author's Name");
                }




            }


            catch (SqlException )
            {

                MessageBox.Show("Book Id is  Already In The Records ");
                con.Close();






            }






            con.Close();
            
        }

        private void btnbk_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbk_id.Text != "" && txtbk_ttl.Text != "" && cbobk_cat.Text != "" && cbobk_lang.SelectedIndex!=0)
                {
                    
                    con.Open();



                    String upd = "UPDATE [Library_Management_System].[dbo].[Book]SET [Title] =N'" + txtbk_ttl.Text + "' ,[Category] =N'" + cbobk_cat.Text + "' ,[Edition] =N'" + txtbk_edi.Text + "' ,[ISBN] =N'" + txtbk_isbn.Text + "' ,[DDC_No] =N'" + txtbk_ddc.Text + "' ,[Author] =N'" + txtbk_auth.Text + "' ,[Publisher] =N'" + txtbk_pub.Text + "' ,[Publication_Date] = N'" + txtbk_pubd.Text + "' , [Attachment] ='" + chk_bk_ach.Checked + "' ,[Price] =N'" + txtbk_price.Text + "' ,[Recieved_By] =N'" + txtbk__rcivdby.Text + "',[Other_Details] =N'" + txtbk_othrdtls.Text + "' , [Reference] =N'" + chkbk_ref.Checked + "' ,[Availability] ='" + "available" + "'   WHERE ([Book_ID]=N'" + txtbk_id.Text + "')";
                    SqlCommand cmd = new SqlCommand(upd,con);
                    
                    
                    
                    
                    
                   

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have Successfully Updated the Data ");
                    m_clear();
                    con.Close();
                    
                }
                else
                {
                    MessageBox.Show("ID ,Title ,Language,Category,Author Fields Cannot be Empty");
                }
            }
            catch (Exception)
            {
               MessageBox.Show("Please Check The Id You Have Entered");


            }
        }

        





            

        private void btnbk_delete_Click(object sender, EventArgs e)
        {
            if (txtbk_id.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Book WHERE Book_ID=@bkid", con);
                
                cmd.Parameters.Add(new SqlParameter("@bkid", txtbk_id.Text));
                DialogResult s = MessageBox.Show("Are You Sure Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (s == DialogResult.Yes)
                {
                    try
                    {

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Successfully");
                        con.Close();
                        m_clear();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter The Book's Id You Want To Delete ");
            
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
        }

      

       

       

        

       
    }


