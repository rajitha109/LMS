using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class frmsplash : Form
    {
        bool test = false;
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        public frmsplash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void testcon()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Closed)
                {
                    con.Close();
                }
                else if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Database is not found please restore database","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                test = true;
            }
        }
        
        int timeLeft;

        private void frmsplash_Load(object sender, EventArgs e)
        {
            timeLeft = 100;
            tmrsp.Start();
        }

        private void tmrsp_Tick(object sender, EventArgs e)
        {
            
            if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;
                this.prosp.Increment(1);


            }

            else
            {
                tmrsp.Stop();
                testcon();
                
                if (test == true)
                {
                    restore lg = new restore();
                    lg.Show();
                    this.Hide();
                }

                else
                {
                    frmlogin lg = new frmlogin();
                    lg.Show();
                    this.Hide();
                }

            }
        }
    }
}
