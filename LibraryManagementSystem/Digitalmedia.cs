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
    public partial class frmdigital : Form
    {
        public frmdigital(string userm)
        {
            InitializeComponent();
            if (userm == "Super Admin")
            {
                btndg_del.Enabled = true;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();


       
        private void txtdg_prc_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmdigital_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btndg_save;
        }

       
        private void btndg_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdg_id.Text != "" && txtdg_ttl.Text != "" && txtdg_auth.Text != "" )
                {
                    con.Open();
                    string query = "INSERT INTO [Library_Management_System].[dbo].[Digital_Media]([Digital_ID],[Title],[Author],[Cateory],[Price],[Source],[Volume],[Other_Details]) VALUES (N'" + this.txtdg_id.Text + "',N'" + this.txtdg_ttl.Text + "',N'" + this.txtdg_auth.Text + "',N'" + this.txtdg_cat.Text + "',N'" + this.txtdg_prc.Text + "',N'" + this.txtdg_src.Text + "',N'" + this.txtdg_vol.Text + "',N'" + this.txtdg_oth.Text+ "')";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully inserted");
                    con.Close();
                    mclear();


                }
                else
                {
                    MessageBox.Show("ID,Title,Author Cannot be Empty");

                }
            }


            catch (SqlException)
            {
                MessageBox.Show("Please Check the Id You Have Entered");

            }
            con.Close();

        }

        private void btndg_del_Click(object sender, EventArgs e)
        {
            if (txtdg_id.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Digital_Media WHERE Digital_ID=@dgid", con);

                cmd.Parameters.Add(new SqlParameter("@dgid", txtdg_id.Text));
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
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter The Book's Id You Want To Delete ");

            }
        }

        
        private void btn_dg_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdg_id.Text != "" && txtdg_ttl.Text != "" && txtdg_auth.Text != "" )
                {
                    con.Open();
                    string upd = "UPDATE [Library_Management_System].[dbo].[Digital_Media] SET [Title] =N'" + txtdg_ttl.Text + "',[Author] =N'" + txtdg_auth.Text + "',[Cateory] =N'" + txtdg_cat.Text + "',[Price] =N'" + txtdg_prc.Text + "',[Source] =N'" + txtdg_src.Text + "',[Volume] =N'" + txtdg_vol.Text + "',[Other_Details] =N'" + txtdg_oth.Text + "' WHERE(Digital_ID=N'" + txtdg_id.Text + "')";
                    cmd = new SqlCommand(upd, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    con.Close();
                    mclear();


                }
                else
                {
                    MessageBox.Show("ID,Title,Author Cannot be Empty");

                }
            }


            catch (SqlException)
            {
                MessageBox.Show("Please Check the Id You Have Entered");

            }
            con.Close();


        }

        private void btndg_ref_Click(object sender, EventArgs e)
        {
            mclear();


        }
        public void mclear()
        {
            txtdg_prc.Text = "";
            txtdg_src.Text = "";
            txtdg_auth.Text = "";
            txtdg_cat.Text = "";
            txtdg_id.Text = "";
            txtdg_oth.Text = "";
            txtdg_ttl.Text = "";
            txtdg_vol.Text = "";


        }

        private void txtdg_id_TextChanged(object sender, EventArgs e)
        {
            txtdg_prc.Text = "";
            txtdg_src.Text = "";
            txtdg_auth.Text = "";
            txtdg_cat.Text = "";
            txtdg_oth.Text = "";
            txtdg_ttl.Text = "";
            txtdg_vol.Text = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Digital_Media WHERE (Digital_ID ='" + txtdg_id.Text + "')", con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {

                if (dr.Read())
                {
                    txtdg_ttl.Text = dr.GetValue(1).ToString();
                    txtdg_auth.Text = dr.GetValue(2).ToString();
                    txtdg_cat.Text = dr.GetValue(3).ToString();
                    txtdg_prc.Text = dr.GetValue(4).ToString();

                    txtdg_src.Text = dr.GetValue(5).ToString();
                    txtdg_vol.Text = dr.GetValue(6).ToString();
                    txtdg_oth.Text = dr.GetValue(7).ToString();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digial Media ID is Not  Exicites");


            }
            con.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void grp_dg_Enter(object sender, EventArgs e)
        {

        }

        private void frmdigital_Load_1(object sender, EventArgs e)
        {
            this.AcceptButton = btndg_save;

        }

    }
}
