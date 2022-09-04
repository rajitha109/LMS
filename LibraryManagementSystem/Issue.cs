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
    public partial class frmissue : Form
    {
        public frmissue()
        {
            InitializeComponent();
        }

        private void Issue_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnisu;
            //Select NO of Date to due date
            cmbisu_dd.Items.Add("7");
            cmbisu_dd.Items.Add("14");
            cmbisu_dd.Items.Add("21");
            cmbisu_dd.Items.Add("28");
            cbomem_type.Items.Add("Student");
            cbomem_type.Items.Add("Staff");

        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        private void lblisubk_dud_Click(object sender, EventArgs e)
        {

        }

        

        private void frmissue_FormClosing(object sender, FormClosingEventArgs e)
        {



        }


        
        public void mclear()
        {
            txtisubk_id.Text = "";
            txtisum_id.Text = "";
            cmbisu_dd.Text = "";
            cbomem_type.SelectedIndex = -1;
            lblisubk_ttl.Text = "Title";
            lblisubk_cat.Text = "Category";
            lblisubk_dud.Text = "Date";
            lblm_name.Text = "Name";
            txtmem_contact.Text = "";
            txtmem_email.Text = "";



        }


        
        
        private void txtisubk_id_TextChanged(object sender, EventArgs e)
        {
            if (txtisubk_id.Text != "")
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Book WHERE (Book_ID ='" + txtisubk_id.Text + "')", con);
                SqlDataReader dr = cmd.ExecuteReader();

                try
                {


                    if (dr.Read())
                    {
                        lblisubk_ttl.Text = dr.GetValue(2).ToString();
                        lblisubk_cat.Text = dr.GetValue(3).ToString();
                        lblisubk_ddc.Text = dr.GetValue(6).ToString();

                        con.Close();



                    }








                }
                catch (Exception)
                {
                    MessageBox.Show("Book ID is Not  Exicites");


                }
                con.Close();



            }
        }

        
        private void btnisu_Click(object sender, EventArgs e)
        {
            if (txtisubk_id.Text == "")
            {
                MessageBox.Show("Please Enter Book ID");

            }

            else if (txtisum_id.Text == "")
            {
                MessageBox.Show("Please Enter Member ID ");
            }


            else if (cmbisu_dd.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select The No of Days to return");

            }
            else if (cbomem_type.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select The Member Type");

            }
            else if ((txtmem_contact.Text == "") || txtmem_email.Text == "")
            {
                MessageBox.Show("Please Click The Fill Button OR 'CTRL+F' Before Click The Issue Button ");

            }
            else
            {

                {
                    try
                    {
                        con.Open();
                        String insert = "INSERT INTO [Library_Management_System].[dbo].[Borrow]([Book_ID],[Member_ID],[Member_Type],[Issu_Date],[Due_Date],[Contact_NO],[Email]) VALUES ('" + txtisubk_id.Text + "','" + txtisum_id.Text + "','" + cbomem_type.Text+ "','" + dtpissue.Value.ToShortDateString() + "','" + lblisubk_dud.Text + "','" + txtmem_contact.Text + "','" + txtmem_email.Text + "')";
                        SqlCommand cmd = new SqlCommand(insert, con);
                        cmd.ExecuteNonQuery();
                        string avb="";
                        string upd = "UPDATE Book SET Availability='"+avb+"' WHERE (Book_ID='"+txtisubk_id.Text+"')";
                        SqlCommand command = new SqlCommand(upd,con);
                        command.ExecuteNonQuery();
                        

                        con.Close();
                        MessageBox.Show("You Have Successfully Issued The Book");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This Member Has Not Return This Book Yet.Please Return The Book First. ");
                        con.Close();
                    }
                }



            }
            con.Close();

        }

        private void btnisu_refresh_Click(object sender, EventArgs e)
        {
            mclear();
        }

        private void txtisum_id_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (cbomem_type.SelectedIndex == 0)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Student_Member WHERE (Member_ID ='" + txtisum_id.Text + "')", con);
                SqlDataReader dr2 = command.ExecuteReader();
                if (dr2.Read())
                {
                    lblm_name.Text = dr2.GetValue(3).ToString();
                    txtmem_contact.Text = dr2.GetValue(6).ToString();
                    txtmem_email.Text = dr2.GetValue(8).ToString();

                    con.Close();
                }
            }

            else if (cbomem_type.SelectedIndex == 1)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Staff_Member WHERE (Member_ID ='" + txtisum_id.Text + "')", con);
                SqlDataReader dr2 = command.ExecuteReader();
                if (dr2.Read())
                {
                    lblm_name.Text = dr2.GetValue(1).ToString();
                    txtmem_contact.Text = dr2.GetValue(4).ToString();
                    txtmem_email.Text = dr2.GetValue(5).ToString();

                    con.Close();



                }
                con.Close();





            }

            else
            {

                MessageBox.Show("Please Select Member Type Before Enter Member ID");
            }
            con.Close();

        }

        private void cmbisu_dd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d;
            d = int.Parse(cmbisu_dd.Text);
            string date = dtpissue.Value.ToShortDateString();//short date
            DateTime issuedate = DateTime.Parse(date);//convert to date format
            DateTime returndate = issuedate.AddDays(d);//NO of days return
            lblisubk_dud.Text = returndate.ToShortDateString();//Convert short date format and to text box
        
        }

        private void cbomem_type_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
