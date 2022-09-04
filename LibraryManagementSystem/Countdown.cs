using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Countdown : DevComponents.DotNetBar.Office2007Form
    {
        public Countdown()
        {
            InitializeComponent();
        }

        int s;

        void timer()
        {
            s = 20;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == 0)
            {
                timer1.Stop();
                frmlogin obj = new frmlogin();
                this.Hide();
                obj.Show();

            }

            string ss = Convert.ToString(s);
            lblsecondsleft.Text = ss;
        }

        private void Countdown_Load(object sender, EventArgs e)
        {
            timer();
        }
    }
}
