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
    public partial class frmstudent : Form
    {
        //connection String
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");

        public frmstudent(string userm)
        {
            InitializeComponent();
            Sfill();
            cfill();
            if (userm == "Client")
            {
                btnstu_delete.Enabled = false;
            }
            load_Course();
            txtstu_cid.SelectedIndex = -1;
        }

        //refreshing text boxes
        void refresh()
        {
            txtstu_id.Text = "";
            txtstu_name.Text = "";
            txtstu_addno.Text = "";
            txtstu_nic.Text = "";
            rdo_male.Checked = false;
            rdostu_female.Checked = false;
            txtstu_formno.Text = "";
            txtstu_contact.Text = "";
            txtstu_email.Text = "";
            txtstu_cid.Text = "";
            txtstu_enroll.Text = "";
            txtstu_address.Text = "";
            txtstu_cid.SelectedIndex = -1;
            txtstu_id.Focus();
        }

        void load_Course()
        {
            try
            {
                con.Open();
                String s = "SELECT [Course_ID] FROM [dbo].[Course]";//+ cbo_phoneno.SelectedValue;

                //bkDataSet ds = new bkDataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(s, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                con.Close();
                da.Fill(dt);

                //cbono.Items.Add(dt);
                txtstu_cid.DataSource = dt;
                txtstu_cid.DisplayMember = "Course_ID";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //validating textboxes
        bool res;
        void validate()
        {
            res = false;

            if (txtstu_id.Text == "")
            {
                MessageBox.Show("Please fill Student ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_id.Focus();
                res = true;
            }

            else if (txtstu_name.Text == "")
            {
                MessageBox.Show("Please fill Student Name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_name.Focus();
                res = true;
            }

            else if (txtstu_addno.Text == "")
            {
                MessageBox.Show("Please fill Student Admission Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_addno.Focus();
                res = true;
            }

            else if (txtstu_nic.Text == "")
            {
                MessageBox.Show("Please fill Student NIC Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_nic.Focus();
                res = true;
            }

            else if ((rdo_male.Checked == false) && (rdostu_female.Checked == false))
            {
                MessageBox.Show("Please select the gender of student !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
            }

            else if (txtstu_formno.Text == "")
            {
                MessageBox.Show("Please fill Form Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_formno.Focus();
                res = true;
            }

            else if (txtstu_contact.Text == "")
            {
                MessageBox.Show("Please fill Student Contact Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_contact.Focus();
                res = true;
            }

            else if (txtstu_email.Text == "")
            {
                MessageBox.Show("Please fill Student E-mail Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_email.Focus();
                res = true;
            }

            else if (txtstu_cid.Text == "")
            {
                MessageBox.Show("Please fill Course ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_cid.Focus();
                res = true;
            }

            else if (txtstu_enroll.Text == "")
            {
                MessageBox.Show("Please fill Enroll Date !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_enroll.Focus();
                res = true;
            }

            else if (txtstu_address.Text == "")
            {
                MessageBox.Show("Please fill Student Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_address.Focus();
                res = true;
            }

            else if (txtstu_contact.TextLength < txtstu_contact.MaxLength)
            {
                MessageBox.Show("Contact Number Should Have 10 Digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstu_contact.Focus();
                res = true;
            }
        }

        //student Autofill
        void Sfill()
        {
            txtstu_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtstu_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Student_Member ", con);
            SqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["Member_ID"].ToString();
                    col.Add(id);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtstu_id.AutoCompleteCustomSource = col;
        }

        void cfill()
        {
           /* txtstu_cid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtstu_cid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Tbl_Courses ", con);
            SqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["Course_ID"].ToString();
                    col.Add(id);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtstu_cid.AutoCompleteCustomSource = col;*/
        }



        private void members_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnstu_add;
        }


        private void btnstu_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        string gender;
        private void btnstu_add_Click(object sender, EventArgs e)
        {
            validate();

            if (res == false)
            {
                if (rdo_male.Checked == true)
                {
                    gender = rdo_male.Text;
                }

                else if (rdostu_female.Checked == true)
                {
                    gender = rdostu_female.Text;
                }

                string phone = txtstu_contact.Text;
                phone = phone.Substring(phone.Length - 9);
                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Student_Member where Member_ID='" + txtstu_id.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int i = dt.Rows.Count;

                if (i > 0)
                {
                    MessageBox.Show("The Student Number '" + txtstu_id.Text + "' is already exist !", "Duplicated Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }

                else
                {
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(@"insert into Student_Member(
                    Member_ID, 
                    Name, 
                    Admission_NO, 
                    NIC, Gender, 
                    Form_NO, 
                    Contact_NO, 
                    Email, 
                    Course_ID, 
                    Enroll_Date, 
                    Address)

                    values('" + txtstu_id.Text + "', '" + txtstu_name.Text + "', '" + txtstu_addno.Text + "','" + txtstu_nic.Text + "','" + gender + "','" + txtstu_formno.Text + "', '" + phone + "','" + txtstu_email.Text + "','" + txtstu_cid.Text + "','" + txtstu_enroll.Text + "','" + txtstu_address.Text + "')", con);
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("The Student Number '" + txtstu_id.Text + "' is added to the inventory successfuly !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        }

        //to enter only numbers for the phone number
        private void txtstu_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnstu_update_Click(object sender, EventArgs e)
        {
            validate();
            if (res == false)
            {
                DialogResult s = MessageBox.Show("Do you wan to update '" + txtstu_id.Text + "' details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (s == DialogResult.Yes)
                {
                    string phone = txtstu_contact.Text;
                    phone = phone.Substring(phone.Length - 9);

                    if (rdo_male.Checked == true)
                    {
                        gender = rdo_male.Text;
                    }

                    else if (rdostu_female.Checked == true)
                    {
                        gender = rdostu_female.Text;
                    }
                    try
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"update Student_Member set Name='" + txtstu_name.Text + "',Admission_NO='" + txtstu_addno.Text + "',NIC='" + txtstu_nic.Text + "',Gender='" + gender + "',Form_NO='" + txtstu_formno.Text + "',Contact_NO='" + phone + "',Email='" + txtstu_email.Text + "',Course_ID='" + txtstu_cid.Text + "',Enroll_Date='" + txtstu_enroll.Text + "',Address='" + txtstu_address.Text + "' where Member_ID='" + txtstu_id.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        refresh();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    refresh();
                }
            }
        }

        private void btnstu_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult s = MessageBox.Show("Do You Want To Delete course details for '" + txtstu_id.Text + "'", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (s == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"delete from Student_Member where Member_ID='" + txtstu_id.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    refresh();
                }
                else
                {
                    refresh();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtstu_id_TextChanged(object sender, EventArgs e)
        {
            txtstu_name.Text = "";
            txtstu_addno.Text = "";
            txtstu_nic.Text = "";
            rdo_male.Checked = false;
            rdostu_female.Checked = false;
            txtstu_formno.Text = "";
            txtstu_contact.Text = "";
            txtstu_email.Text = "";
            txtstu_cid.Text = "";
            txtstu_enroll.Text = "";
            txtstu_address.Text = "";
            txtstu_cid.SelectedIndex = -1;

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"SELECT 
                     Name, 
                    Admission_NO, 
                    NIC, Gender, 
                    Form_NO, 
                    Contact_NO, 
                    Email, 
                    Course_ID, 
                    Enroll_Date, 
                    Address FROM Student_Member where Member_ID='" + txtstu_id.Text + "'", con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string sname = reader["Name"].ToString();
                    string addno = reader["Admission_NO"].ToString();
                    string nic = reader["NIC"].ToString();
                    string gend = reader["Gender"].ToString();
                    string fno = reader["Form_NO"].ToString();
                    string contact = reader["Contact_NO"].ToString();
                    contact = 0+contact.Substring(contact.Length-9);
                    string email = reader["Email"].ToString();
                    string cid = reader["Course_ID"].ToString();
                    string date = reader["Enroll_Date"].ToString();
                    string address = reader["Address"].ToString();
                    txtstu_name.Text = sname;
                    txtstu_addno.Text = addno;
                    txtstu_nic.Text = nic;
                    if (gend == "Male")
                    {
                        rdo_male.Checked = true;
                    }
                    else if (gend == "Female")
                    {
                        rdostu_female.Checked = true;
                    }
                    txtstu_formno.Text = fno;
                    txtstu_contact.Text = contact;
                    txtstu_email.Text = email;
                    txtstu_cid.Text = cid;
                    txtstu_enroll.Text = date;
                    txtstu_address.Text = address;
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtstu_contact_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
