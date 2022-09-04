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
using System.IO.Ports;//Serial Port Library
using System.Text.RegularExpressions;//regex
using System.Threading;
using System.Management;

namespace LibraryManagementSystem
{
    public partial class Resetpass : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_Management_System;Integrated Security=True");
        string phonenumber;
        string number;
        int pinnumber;

        private SerialPort sp;

        public Resetpass()
        {
            InitializeComponent();
        }

        private void btnempM_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT [Name]
      ,[ContactNo]
  FROM [dbo].[EmpRegistrations] where EmpNO='"+txtid.Text+"'",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbluname.Text = dr.GetValue(0).ToString();
                    string num = dr.GetValue(1).ToString();
                    num = 0 + num.Substring(num.Length - 9);
                    lblpnum.Text = num;
                    number = num;
                    phonenumber = 94 + num.Substring(num.Length - 9);
                }
                lblcon.Visible = true;
                lblpnum.Visible = true;
                lbluname.Visible = true;
                lblun.Visible = true;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            lblpnum.Text = "";
            lbluname.Text = "";

            SqlCommand cmd = new SqlCommand(@"SELECT [Name]
      ,[ContactNo]
  FROM [dbo].[EmpRegistrations] where EmpNO='" + txtid.Text + "'", con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lbluname.Text = reader["Name"].ToString();
                    string num = reader["ContactNo"].ToString();
                    num = 0 + num.Substring(num.Length - 9);
                    lblpnum.Text = num;
                    number = num;
                    phonenumber = 94 + num.Substring(num.Length - 9);
                }
                if (lblpnum.Text != "")
                {
                    chkagr.Enabled = true;
                }

                else if(lblpnum.Text == "")
                {
                    chkagr.Enabled = false;
                    chkagr.Checked = false;
                    btngetcode.Enabled = false;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkagr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkagr.Checked == true)
            {
                btngetcode.Enabled = true;
                btnsrc.Enabled = false;
                txtid.Enabled = false;
            }

            else
            {
                btngetcode.Enabled = false;
                btnsrc.Enabled = true;
                txtid.Enabled = true;
            }
        }

        private void btngetcode_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("A 6 digit password reset code will be send to "+number+"","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (s == DialogResult.OK)
            {
                try
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "Select * from Win32_PnPEntity");
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        if (queryObj["Caption"].ToString().Contains("3G PC UI Interface (COM"))
                        {
                            string portname = queryObj["Caption"].ToString();
                            int start = portname.IndexOf("(") + 1;
                            int end = portname.IndexOf(")", start);
                            string portnum = portname.Substring(start, end - start);
                            label2.Text = portnum;
                        }
                    }

                    if (label2.Text == "label2")
                    {
                        MessageBox.Show("Please Plug A Gsm Dongle To Recieve Pin Number!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                    else
                    {
                        try
                        {
                            this.sp = new SerialPort();
                            this.sp.PortName = label2.Text;
                            this.sp.BaudRate = 9600;
                            this.sp.Parity = Parity.None;
                            this.sp.DataBits = 8;
                            this.sp.StopBits = StopBits.One;
                            this.sp.Handshake = Handshake.RequestToSend;
                            this.sp.DtrEnable = true;
                            this.sp.RtsEnable = true;
                            this.sp.NewLine = System.Environment.NewLine;
                            sp.Open();
                            send_sms();
                            if (true)
                            {
                                MessageBox.Show("Pin Number Has Been Send To Your Mobile.!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                txtrcode.Enabled = true;
                                btngobk.Visible = true;
                                btngetcode.Enabled = false;
                                chkagr.Enabled = false;
                            }

                            else
                            {
                                MessageBox.Show("Error sendin message..!");
                            }


                        }



                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            else
            {
                txtrcode.Enabled = false;
                btngobk.Visible = false;
            }
        }

        public bool send_sms()
        {
            string cellnum = phonenumber;
            int ran = new Random().Next(100000, 999999);
            pinnumber = ran;
            string sms = "Your password reset code is " + ran.ToString() +Environment.NewLine+"(Hasalaka Tec Library Management System)";

            if (sp.IsOpen)
            {
                this.sp.WriteLine(@"AT" + (char)(13));
                Thread.Sleep(200);
                this.sp.WriteLine(@"AT+CMGF=1" + (char)(13));
                Thread.Sleep(200);
                this.sp.WriteLine(@"AT+CMGS=""" + cellnum + @"""" + (char)(13));
                Thread.Sleep(200);
                this.sp.WriteLine(sms + (char)(26));
                return true;
            }


            return false;
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Are you sure you want to go to Previous stage", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (s == DialogResult.Yes)
            {
                txtrcode.Enabled = false;
                btngobk.Visible = false;
                btngetcode.Enabled = true;
                chkagr.Enabled = true;
                txtrcode.Text = "";
            }

            else
            {
            }
            
        }

        private void txtrcode_TextChanged(object sender, EventArgs e)
        {
            if (txtrcode.Text == pinnumber.ToString())
            {
                btncheck.Enabled = true;
            }
            else
            {
                btncheck.Enabled = false;
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (txtrcode.Text == pinnumber.ToString())
            {
                DialogResult s = MessageBox.Show("Pinnumber is matched correctly."+Environment.NewLine+" Do you wish to proceed?", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (s == DialogResult.Yes)
                {
                    btncheck.Enabled = false;
                    txtnpass.Enabled = true;
                    txtconpass.Enabled = true;
                    txtrcode.Enabled = false;
                    btngobk.Enabled = false;
                    btncancel.Visible = true;
                    txtnpass.Focus();
                }

                else
                {
                }
            }
        }

        private void txtnpass_TextChanged(object sender, EventArgs e)
        {
            if (txtnpass.Text != "" && txtnpass.Text == txtconpass.Text)
            {
                btnresetpass.Enabled = true;
            }
            else
            {
                btnresetpass.Enabled = false;
            }
        }

        private void txtconpass_TextChanged(object sender, EventArgs e)
        {
            if (txtconpass.Text != "" && txtconpass.Text == txtnpass.Text)
            {
                btnresetpass.Enabled = true;
            }
            else
            {
                btnresetpass.Enabled = false;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Are you sure you want to cancel passwort reset"+Environment.NewLine+"*all the progress will be terminated!", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (s == DialogResult.Yes)
            {
                this.Close();
            }

            else
            {
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnresetpass_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[EmpRegistrations]
   SET [Password] = '"+txtnpass.Text+"'WHERE EmpNO='"+txtid.Text+"'",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password reset successfuly..!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
