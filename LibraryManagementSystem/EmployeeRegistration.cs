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
    public partial class EmployeeRegistration : Form
    {


        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        public EmployeeRegistration()
        {
            InitializeComponent();
            txtPwd.PasswordChar = '*';
            txtPwd.MaxLength = 20;
            check();
        }

        void disable()
        {
            txtAdd.Enabled = false;
            txtCnt.Enabled
                = false;
            txtDsg.Enabled
                = false;
            txtName.Enabled
                = false;
            txtNIC.Enabled
                = false;
            txtPwd.Enabled
                = false;
            rdoFemale.Enabled
                = false;
            rdoMale.Enabled
                = false;

        }

        void enable()
        {
            txtEmpNo.Enabled = true;
            txtAdd.Enabled = true;
            txtCnt.Enabled
                = true;
            txtDsg.Enabled
                = true;
            txtName.Enabled
                = true;
            txtNIC.Enabled
                = true;
            txtPwd.Enabled
                = true;
            rdoFemale.Enabled
                = true;
            rdoMale.Enabled
                = true;

        }

        bool val;
        string utype;

        private void btnempM_add_Click(object sender, EventArgs e)
        {
            val = false;

            if (chkadmin.Checked == false && chkclient.Checked == false)
            {
                MessageBox.Show("Please Select User Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                val = true;
            }

            else if (txtEmpNo.Text == "") {
                MessageBox.Show("Please Fill Employee No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpNo.Focus();
                val = true;
            }

            else if (txtName.Text == "")
            {
                MessageBox.Show("Please Fill Employee Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpNo.Focus();
                val = true;
            }

            else if (txtPwd.Text == "")
            {
                MessageBox.Show("Please Fill Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpNo.Focus();
                val = true;
            }

            else if ((rdoMale.Checked==false && rdoFemale.Checked==false))
            {
                MessageBox.Show("Please Select Employee Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpNo.Focus();
                val = true;
            }

            else if (txtNIC.Text == "")
            {
                MessageBox.Show("Please Fill Employee NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpNo.Focus();
                val = true;
            }

            else if (txtAdd.Text == "")
            {
                MessageBox.Show("Please Fill Employee Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpNo.Focus();
                val = true;
            }

            else if (txtDsg.Text == "")
            {
                MessageBox.Show("Please Fill Employee Designtion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpNo.Focus();
                val = true;
            }

            else if (txtCnt.TextLength < txtCnt.MaxLength)
            {
                MessageBox.Show("Contact Number Should Have 10 Digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCnt.Focus();
                val = true;
            }

            if(chkadmin.Checked==true)
            {
                utype = chkadmin.Text;
            }

            else if (chkclient.Checked == true)
            {
                utype = chkclient.Text;
            }
            else
            {
                utype = "";
            }

            string contactnum = txtCnt.Text;
            contactnum = 94+contactnum.Substring(contactnum.Length-9 );

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM EmpRegistrations where EmpNO='" + txtEmpNo.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    int i = dt.Rows.Count;

                    if (i > 0)
                    {
                        MessageBox.Show("The Employee ID '" + txtEmpNo.Text + "' is already exist !", "Duplicated Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }

                    else if (val==false && i==0)
                    {
                        SqlCommand cmd1 = new SqlCommand(@"INSERT INTO EmpRegistrations (U_type,EmpNO, Name, Password, Gender, NIC_NO, Address, Designation, ContactNo)
                                VALUES ('" + utype + "','" + txtEmpNo.Text + "','" + txtName.Text + "', '" + txtPwd.Text + "', @gender,'" + txtNIC.Text + "','" + txtAdd.Text + "','" + txtDsg.Text + "','" + contactnum + "')", con);

                        if (rdoMale.Checked)
                        {
                            cmd1.Parameters.AddWithValue("@gender", "Male");
                        }
                        else
                        {
                            cmd1.Parameters.AddWithValue("@gender", "Female");
                        }
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Employee Added Successfully");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text == "")
            {
                MessageBox.Show("Please Fill Employee ID You want to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtCnt.TextLength < txtCnt.MaxLength)
            {
                MessageBox.Show("Contact Number Should Have 10 Digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCnt.Focus();
            }

            else
            {
                string contactnum = txtCnt.Text;
                contactnum = 94 + contactnum.Substring(contactnum.Length - 9);
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE EmpRegistrations SET U_type=@utype ,Name = '" + txtName.Text + "', Password = '" + txtPwd.Text + "', Gender = @gender, NIC_NO = '" + txtNIC.Text + "', Address = '" + txtAdd.Text + "', Designation = '" + txtDsg.Text + "', ContactNo = '" + contactnum + "' WHERE (EmpNO = '" + txtEmpNo.Text + "')", con);
                    if (rdoMale.Checked)
                    {
                        cmd.Parameters.AddWithValue("@gender", "Male");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@gender", "Female");
                    }

                    if (chkadmin.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@utype", "Administrator");
                    }

                    else if (chkclient.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@utype", "Client");
                    }

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee Updated Successfully");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text == "")
            {
                MessageBox.Show("Please Fill Employee ID You want to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM EmpRegistrations WHERE EmpNo = ('" + txtEmpNo.Text + "')", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtName.Text = dr.GetValue(2).ToString();
                        txtNIC.Text = dr.GetValue(5).ToString();
                        txtAdd.Text = dr.GetValue(6).ToString();
                        txtDsg.Text = dr.GetValue(7).ToString();
                        string contct = dr.GetValue(8).ToString();
                        contct = 0 + contct.Substring(contct.Length - 9);

                        if (dr.GetValue(4).ToString() == "Male")
                        {
                            rdoMale.Checked = true;
                        }
                        else if (dr.GetValue(4).ToString() == "Female")
                        {
                            rdoFemale.Checked = true;
                        }

                        if (dr.GetValue(0).ToString() == "Administrator")
                        {
                            chkadmin.Checked = true;
                        }
                        else if (dr.GetValue(0).ToString() == "Client")
                        {
                            chkclient.Checked = true;
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text == "")
            {
                MessageBox.Show("Please Fill Employee ID You want to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    DialogResult s = MessageBox.Show("Are you sure you want to delete Employee Number '" + txtEmpNo.Text + "'", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if (s == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM EmpRegistrations WHERE EmpNo = ('" + txtEmpNo.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Employee Deleted Successfully");
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
                    con.Close();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() 
        {
            chkadmin.Checked = false;
            chkclient.Checked = false;
            txtEmpNo.Text = "";
            txtName.Text = "";
            txtPwd.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtNIC.Text = "";
            txtAdd.Text = "";
            txtDsg.Text = "";
            txtCnt.Text = "";
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            disable();
            this.AcceptButton = btnempM_add;
        }

        private void chkadmin_CheckedChanged(object sender, EventArgs e)
        {
            enable();
            chkclient.Checked = false;
            check();
        }

        private void chkclient_CheckedChanged(object sender, EventArgs e)
        {
            enable();
            chkadmin.Checked = false;
            check();
        }

        void check()
        {
            if ((chkadmin.Checked == true) || (chkclient.Checked == true))
            {
                enable();
            }
            else
            {
                disable();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
