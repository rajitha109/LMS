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
    public partial class frmstaff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");

        public frmstaff(string userm)
        {
            InitializeComponent();
            stfill();
            if (userm == "Client")
            {
                btnstf_delete.Enabled = false;
            }
        }

        void refresh()
        {
            txtstf_id.Text = "";
            txtstf_name.Text = "";
            txtstf_nic.Text = "";
            rdostf_male.Checked = false;
            rdostf_female.Checked = false;
            txtstf_contact.Text = "";
            txtstf_email.Text = "";
            txtstf_address.Text = "";
            rdortnstf_vis.Checked = false;
            rdostf_acd.Checked = false;
            rdortnstf_per.Checked = false;
            rdostf_nacd.Checked = false;
            txtstf_id.Focus();
        }


        bool res;
        void validate()
        {
            res = false;
            if (txtstf_id.Text == "")
            {
                MessageBox.Show("Please fill Staff ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstf_id.Focus();
                res = true;
            }

            else if (txtstf_name.Text == "")
            {
                MessageBox.Show("Please fill Staff Name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstf_name.Focus();
                res = true;
            }

            else if (txtstf_nic.Text == "")
            {
                MessageBox.Show("Please fill NIC Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstf_nic.Focus();
                res = true;
            }

            else if ((rdostf_male.Checked == false) && (rdostf_female.Checked == false))
            {
                MessageBox.Show("Please fill Gender of the Staff Member !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdostf_male.Focus();
                res = true;
            }

            else if (txtstf_contact.Text == "")
            {
                MessageBox.Show("Please fill Member Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstf_contact.Focus();
                res = true;
            }

            else if (txtstf_email.Text == "")
            {
                MessageBox.Show("Please fill Member E-Mail Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstf_email.Focus();
                res = true;
            }

            else if (txtstf_address.Text == "")
            {
                MessageBox.Show("Please fill Member Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstf_address.Focus();
                res = true;
            }

            else if ((rdostf_acd.Checked == false) && (rdostf_nacd.Checked == false))
            {
                MessageBox.Show("Please select the member is Academic or Non-Academic !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdostf_acd.Focus();
                res = true;
            }

            else if ((rdostf_acd.Checked == true) && ((rdortnstf_per.Checked== false)&&(rdortnstf_vis.Checked==false)))
            {
                MessageBox.Show("Please select the member is Permenent or Visiting !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdostf_acd.Focus();
                res = true;
            }

            else if (txtstf_contact.TextLength < txtstf_contact.MaxLength)
            {
                MessageBox.Show("Contact Number Should Have 10 Digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstf_contact.Focus();
                res = true;
            }

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnstf_add;
        }
        
        private void btnstf_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void rdostf_acd_CheckedChanged(object sender, EventArgs e)
        {
            grbrtnstf_typ.Enabled = true;
        }

        private void rdostf_nacd_CheckedChanged(object sender, EventArgs e)
        {
            grbrtnstf_typ.Enabled = false;
            rdortnstf_per.Checked = false;
            rdortnstf_vis.Checked = false;
        }


        string gender;
        string member;
        string memtype;
        private void btnstf_add_Click_1(object sender, EventArgs e)
        {
            validate();

            if (res == false)
            {
                if (rdostf_male.Checked == true)
                {
                    gender = rdostf_male.Text;
                }

                else if (rdostf_female.Checked == true)
                {
                    gender = rdostf_female.Text;
                }

                if (rdostf_acd.Checked == true)
                {
                    member = rdostf_acd.Text;
                }

                else if (rdostf_nacd.Checked == true)
                {
                    member = rdostf_nacd.Text;
                }

                if (rdortnstf_vis.Checked == true)
                {
                    memtype = rdortnstf_vis.Text;
                }

                else if (rdortnstf_per.Checked == true)
                {
                    memtype = rdortnstf_per.Text;
                }

                string phone = txtstf_contact.Text;
                phone = 94 + phone.Substring(phone.Length - 9);

                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Staff_Member where Member_ID='" + txtstf_id.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int i = dt.Rows.Count;

                if (i > 0)
                {
                    MessageBox.Show("The staff ID '" + txtstf_id.Text + "' is already exist !", "Duplicated Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }

                else
                {
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(@"insert into Staff_Member(
                    [Member_ID]
           ,[Name]
           ,[NIC]
           ,[Gender]
           ,[Contact_NO]
           ,[Email]
           ,[Address]
           ,[Academic/Non_Academic]
           ,[Permenent/Visiting]
)

                    values('" + txtstf_id.Text + "', '" + txtstf_name.Text + "', '" + txtstf_nic.Text + "','" + gender + "','" + phone + "','" + txtstf_email.Text + "', '" + txtstf_address.Text + "','" + member + "','" + memtype + "')", con);
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("The Staff Member '" + txtstf_id.Text + "' is added to the inventory successfuly !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        void stfill()
        {
            txtstf_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtstf_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Staff_Member ", con);
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

            txtstf_id.AutoCompleteCustomSource = col;
        }

        private void btnstf_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult s = MessageBox.Show("Do You Want To Delete Staff Member details for '" + txtstf_id.Text + "'", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (s == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"delete from Staff_Member where Member_ID='" + txtstf_id.Text + "'", con);
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

        private void btnstf_update_Click(object sender, EventArgs e)
        {
            validate();
            if (res == false)
            {
                DialogResult s = MessageBox.Show("Do you wan to update '" + txtstf_id.Text + "' details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (s == DialogResult.Yes)
                {
                    if (rdostf_male.Checked == true)
                    {
                        gender = rdostf_male.Text;
                    }

                    else if (rdostf_female.Checked == true)
                    {
                        gender = rdostf_female.Text;
                    }

                    if (rdostf_acd.Checked == true)
                    {
                        member = rdostf_acd.Text;
                    }

                    else if (rdostf_nacd.Checked == true)
                    {
                        member = rdostf_nacd.Text;
                    }

                    if (rdortnstf_vis.Checked == true)
                    {
                        memtype = rdortnstf_vis.Text;
                    }

                    else if (rdortnstf_per.Checked == true)
                    {
                        memtype = rdortnstf_per.Text;
                    }

                    try
                    {
                        string phone = txtstf_contact.Text;
                        phone = 94 + phone.Substring(phone.Length - 9);

                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"update Staff_Member set Name='" + txtstf_name.Text + "',NIC='" + txtstf_nic.Text + "',Gender='" + gender + "',Contact_NO='" + phone + "',Email='" + txtstf_email.Text + "',Address='" + txtstf_address.Text + "',[Academic/Non_Academic]='" + member + "',[Permenent/Visiting]='" + memtype + "' where Member_ID='" + txtstf_id.Text + "'", con);
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

        private void txtstf_id_TextChanged(object sender, EventArgs e)
        {
            txtstf_name.Text = "";
            txtstf_nic.Text = "";
            rdostf_male.Checked = false;
            rdostf_female.Checked = false;
            txtstf_contact.Text = "";
            txtstf_email.Text = "";
            txtstf_address.Text = "";
            rdortnstf_vis.Checked = false;
            rdostf_acd.Checked = false;
            rdortnstf_per.Checked = false;
            rdostf_nacd.Checked = false;

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"SELECT 
                    Name, 
                    NIC, 
                    Gender,     
                    Contact_NO, 
                    Email, 
                    Address, 
                    [Academic/Non_Academic], 
                    [Permenent/Visiting] FROM Staff_Member where Member_ID='" + txtstf_id.Text + "'", con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string sname = reader["Name"].ToString();
                    string nic = reader["NIC"].ToString();
                    string gend = reader["Gender"].ToString();
                    string phone = reader["Contact_NO"].ToString();
                    phone = 0+phone.Substring(phone.Length - 9);
                    string email = reader["Email"].ToString();
                    string address = reader["Address"].ToString();
                    string ac = reader["Academic/Non_Academic"].ToString();
                    string per = reader["Permenent/Visiting"].ToString();

                    txtstf_name.Text = sname;
                    txtstf_nic.Text = nic;
                    if (gend == "Male")
                    {
                        rdostf_male.Checked = true;
                    }
                    else if (gend == "Female")
                    {
                        rdostf_female.Checked = true;
                    }
                    if (ac == "Academic")
                    {
                        rdostf_acd.Checked = true;
                    }
                    else if (ac == "Non-Academic")
                    {
                        rdostf_nacd.Checked = true;
                    }

                    if (per == "Permeant")
                    {
                        rdortnstf_per.Checked = true;
                    }
                    else if (per == "Visiting")
                    {
                        rdortnstf_vis.Checked = true;
                    }
                    txtstf_contact.Text = phone;
                    txtstf_email.Text = email;
                    txtstf_address.Text = address;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdortnstf_vis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grbStf1_Enter(object sender, EventArgs e)
        {

        }

        private void txtstf_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
