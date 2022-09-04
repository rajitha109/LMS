using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//To send Email
using System.Net.Mail;//To Send Email
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class frmemail : Form
    {
        public frmemail()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string smtpAddress;

        int portNumber = 587;
        bool enableSSL = true;

        string emailFrom;
        string password;
        string emailTo;
        string subject;
        string body;

        private void email_Load(object sender, EventArgs e)
        {
            cboload();//load items
            dbload();
            this.AcceptButton = btn_send;

        }

        private void lbl_pwd_Click(object sender, EventArgs e)
        {

        }
        public void cboload()
        {
            cbo_smtp.Items.Add("smtp.mail.yahoo.com");
            cbo_smtp.Items.Add("smtp.gmail.com");
            cbo_smtp.Items.Add("smtp.live.com");
        }











        public static bool IsValidEmailId(String InputEmail)
        {
            Regex reg = new Regex(@"^([\w\.\\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = reg.Match(InputEmail);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //clear Text Boxes
        

        public void dbload()
        {
            con.Open();
            DateTime nowd = DateTime.Now;

            try
            {


                String s = "Select Email from Borrow where '" + nowd + "'>Due_Date";//+ cbo_phoneno.SelectedValue;

                //bkDataSet ds = new bkDataSet();
                SqlDataAdapter da = new SqlDataAdapter(s, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                con.Close();
                da.Fill(dt);

                //cbono.Items.Add(dt);

                dt_email.ReadOnly = true;
                dt_email.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Your Database is not Connected to the server");


            }









        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            smtpAddress = cbo_smtp.Text;

            emailFrom = txt_from.Text;
            password = txt_pwd.Text;

            try
            {
                if (cbo_smtp.SelectedIndex == -1)// && txt_from.Text !="" && txt_pwd.Text !="" && txt_to.Text !="" && txt_sub.Text)
                {
                    MessageBox.Show("Please Select the SMTP Server");
                    cbo_smtp.BackColor = Color.PaleVioletRed;

                }
                else if (txt_from.Text == "")
                {
                    MessageBox.Show("Enter Your Email Address");
                    txt_from.BackColor = Color.PaleVioletRed;


                }
                else if (txt_pwd.Text == "")
                {
                    MessageBox.Show("Please Enter Your Password Correctly");
                    txt_pwd.BackColor = Color.PaleVioletRed;
                }

                else if (txt_to.Text == "")
                {
                    MessageBox.Show("Please Enter the Reciever's email");
                    txt_to.BackColor = Color.PaleVioletRed;
                }

                else if (txt_sub.Text == "")
                {
                    MessageBox.Show("Please Enter the Subject Here");
                    txt_sub.BackColor = Color.PaleVioletRed;

                }

                else if (txt_body.Text == "")
                {
                    MessageBox.Show("Please Enter the Message ");
                    txt_body.BackColor = Color.PaleVioletRed;
                }
                else
                {


                    SmtpClient client = new SmtpClient(smtpAddress);
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Timeout = 100000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;//

                    client.Credentials = new NetworkCredential(
                    emailFrom, password);

                    //check whether the Email is Valid 
                    string UserEmail = txt_from.Text;
                    MailMessage msg = new MailMessage();
                    if (IsValidEmailId(UserEmail))
                    {
                        msg.From = new MailAddress(emailFrom);
                    }
                    else
                    {
                        MessageBox.Show("Your Email is Not a Valid Email Address");
                    }


                    msg.To.Add(txt_to.Text);//can send one or more emails by separatly add them usaing comma 
                    msg.From = new MailAddress(txt_from.Text);
                    msg.Subject = txt_sub.Text;
                    msg.Body = txt_body.Text;

                    client.Send(msg);
                    MessageBox.Show("Successfully Sent Message.");


                }




            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your Internet connection OR " + "\n" + "Check whether you have entered the correct Details Above");
            }


        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_from.Clear();
            txt_body.Clear();
            txt_pwd.Clear();
            txt_sub.Clear();
            txt_to.Clear();
            txt_from.Focus();//focus 
        }

        private void dt_email_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = this.dt_email.Rows[i];
                txt_to.Text = row.Cells[0].Value.ToString();

            }
        }
    }
}
    



