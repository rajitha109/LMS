using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;//Serial Port Library
using System.Text.RegularExpressions;//regex
using System.Threading;//threads
using System.Data.SqlClient;


namespace LibraryManagementSystem
{
    public partial class frmsms : Form
    {
        public frmsms()
        {
            InitializeComponent();
        }
        //database connectivity
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();






        
        private SerialPort sp;//serial port

        private void sms_Load(object sender, EventArgs e)
        {
            cbo_comport.Items.Clear();
            cboload();//combo box
            dbload();//database load
            this.AcceptButton = btnsms_send;

        }


        //load combo box items
        public void cboload()
        {
            // load COM Port numbers
            string[] ports = SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                cbo_comport.Items.Add(port);
            }
        }


        //Database
        public void dbload()
        {
            con.Open();
                
            
                DateTime nowd = DateTime.Now;           

                String s = "Select Contact_NO from Borrow where '" + nowd + "'>Due_Date";

                //bkDataSet ds = new bkDataSet();
                SqlDataAdapter da = new SqlDataAdapter(s, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                con.Close();
                da.Fill(dt);

                //cbono.Items.Add(dt);
                cbo_phoneno.DataSource = dt;
                cbo_phoneno.DisplayMember = "Contact_NO";

                dtgrid_sms.ReadOnly = true;
                dtgrid_sms.DataSource = dt;
            


            con.Close();
        }

        
        private void btnsms_send_Click(object sender, EventArgs e)
        {
            
                if (cbo_phoneno.Text != "" && txt_msg.Text != "" && cbo_phoneno.Text != "")
                {
                    try
                    {
                        SerialPort sp = new SerialPort(cbo_comport.Text, 115200);//Connect to dongle
                        Thread.Sleep(1000);//excecution time

                        sp.Open();//open the connection


                        string number = cbo_phoneno.Text;
                        string message = txt_msg.Text;

                        sp.Write("AT+CMGF=1\r");// Dongle configuration to send plain text
                        Thread.Sleep(1000);//                 

                        Regex phoneNo = new Regex(@"^\d{11}$");
                        if (phoneNo.IsMatch(number))
                        {


                            sp.Write("AT+CMGS=\"" + number + "\"\r\n");//Set the destination
                            Thread.Sleep(1000);//timeout

                            sp.Write(message + "\x1A");//character settings, These character can be used in a standard SMS message without requiring special encoding
                            Thread.Sleep(1000);//timeout
                            MessageBox.Show("Message Sent Successfully to  " + cbo_phoneno.Text);



                        }


                        else
                        {
                            MessageBox.Show("Invalid Phone No " + number);
                        }


                    }



                    catch (Exception)
                    {
                        //exception handling
                        MessageBox.Show("Your Message has not been sent to " + cbo_phoneno.Text + "\n Select the Valid Port ", "Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbo_phoneno.Focus();
                    }


                }

                else
                {


                    MessageBox.Show("Empty Fields");//empty fields
                    cbo_phoneno.BackColor = Color.PaleVioletRed;
                    cbo_phoneno.Focus();



                }

            

        }

        private void dtgrid_sms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
