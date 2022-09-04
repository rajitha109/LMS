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
    public partial class frmmagzine : Form
    {
        public frmmagzine(string userm)
        {
            InitializeComponent();
            if (userm == "Super Admin")
            {
                btnmag_del.Enabled = true;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();


        private void frmmagzine_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnmag_save;
        }
        public void mclear()
        {
            txt_mag_id.Text = "";
            txt_mag_name.Text = "";
            txt_mag_cat.Text = "";
            txt_mag_vol.Text = "";
            txt_mag_price.Text = "";
            txt_mag_art.Text = "";
            chk_mag_ach.Checked = false;

        }

        private void btnmag_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (txt_mag_id.Text == "")
                {
                    MessageBox.Show("Please Enter The Magazine ID");

                }
                else if (txt_mag_name.Text == "")
                {
                    MessageBox.Show("Please Enter The Magazine Name");

                }
            



                else
                {
                    string insert = "INSERT INTO [Library_Management_System].[dbo].[Magazine]([Magazine_ID],[Name],[Category],[Volume],[WithCD/DVD],[Price],[Artical_List]) VALUES (N'" + txt_mag_id.Text + "',N'" + txt_mag_name.Text + "',N'" + txt_mag_cat.Text + "',N'" + txt_mag_vol.Text + "','" + chk_mag_ach.Checked + "',N'" + txt_mag_price.Text + "',N'" + txt_mag_art.Text + "')";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Saved Successfully");


                }

            }


            catch (SqlException)
            {
                MessageBox.Show("Magazine Id is Already in the Database");

            }
            con.Close();
        }

        private void btnmag_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mag_id.Text != "" && txt_mag_name.Text != "" && txt_mag_cat.Text != "")
                {
                    con.Open();
                    string upd = "UPDATE [Library_Management_System].[dbo].[Magazine] SET [Name] =N'" + txt_mag_name.Text + "' ,[Category] =N'" + txt_mag_cat.Text + "' ,[Volume] =N'" + txt_mag_vol.Text + "' ,[WithCD/DVD] = '" + chk_mag_ach.Checked + "' ,[Price] =N'" + txt_mag_price.Text + "',[Artical_List] =N'" + txt_mag_art.Text + "'  WHERE (Magazine_ID=N'" + txt_mag_id.Text + "')";
                    SqlCommand cmd = new SqlCommand(upd, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    MessageBox.Show("ID,Name,Category Cannot be Empty");

                }
            }


            catch (SqlException)
            {
                MessageBox.Show("Please Check the Id You Have Entered");

            }
            con.Close();
        }

        private void btnmag_del_Click(object sender, EventArgs e)
        {
            if (txt_mag_id.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Magazine WHERE Magazine_ID=@magid", con);

                cmd.Parameters.Add(new SqlParameter("@magid", txt_mag_id.Text));
                DialogResult s = MessageBox.Show("Are You Sure Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (s == DialogResult.Yes)
                {
                    try
                    {

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Deleted Successfully");

                        mclear();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter The Book's Id You Want To Delete ");

            }
        }

        private void btnmag_ref_Click(object sender, EventArgs e)
        {
            mclear();//Clear method
        }

        private void txt_mag_id_TextChanged(object sender, EventArgs e)
        {
            txt_mag_name.Text = "";
            txt_mag_cat.Text = "";
            txt_mag_vol.Text = "";
            txt_mag_price.Text = "";
            txt_mag_art.Text = "";
            chk_mag_ach.Checked = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Magazine WHERE (Magazine_ID ='" + txt_mag_id.Text + "')", con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {


                if (dr.Read())
                {
                    txt_mag_name.Text = dr.GetValue(1).ToString();
                    txt_mag_cat.Text = dr.GetValue(2).ToString();
                    txt_mag_vol.Text = dr.GetValue(3).ToString();
                    txt_mag_price.Text = dr.GetValue(5).ToString();

                    txt_mag_art.Text = dr.GetValue(6).ToString();



                }
            }
            catch (Exception)
            {
                MessageBox.Show("Magazine ID is Not  Exicites");


            }
            con.Close();

        }
    }
}
