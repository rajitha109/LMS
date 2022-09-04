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
    public partial class frmpayroll : Form
    {
        public frmpayroll()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        double CalE,CalD;

        private void frmpayroll_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnpay_add;
        }

        private void textBoxX10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpay_add_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnpay_rfsh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtpay_ernbas_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_ernlvn_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_alncvlu1_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_alncvlu2_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_alncvlu3_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_alncvlu4_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_alncvlu5_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_stmp_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_wop_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_agr_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_fstad_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_lnvlu1_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_lnvlu2_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_lnvlu3_TextChanged(object sender, EventArgs e)
        {
            CalPayroll();
        }

        private void txtpay_ded_TextChanged(object sender, EventArgs e)
        {
            NetCal();
        }

        public void CalPayroll()
        {           
            if (!(txtpay_ernbas.Text == "") && !(txtpay_ernlvn.Text == ""))
            {
                double ern, lvn;
                bool iseValid = double.TryParse(txtpay_ernbas.Text, out ern);
                bool islValid = double.TryParse(txtpay_ernlvn.Text, out lvn);
                if (iseValid && islValid)
                {
                    CalE = ern + lvn;
                    txtpay_grs.Text = Convert.ToString(CalE);
                }
                else
                {
                    txtpay_grs.Text = "Invalid Text";
                }

            }
            if (!(txtpay_ernbas.Text == "") && !(txtpay_ernlvn.Text == "") && !(txtpay_alncvlu1.Text == ""))
            {
                double ern, lvn,alw1;
                bool iseValid = double.TryParse(txtpay_ernbas.Text, out ern);
                bool islValid = double.TryParse(txtpay_ernlvn.Text, out lvn);
                bool is1Valid = double.TryParse(txtpay_alncvlu1.Text, out  alw1);
                if (iseValid && islValid && is1Valid)
                {
                    CalE = ern + lvn+alw1;
                    txtpay_grs.Text = Convert.ToString(CalE);
                }
                else
                {
                    txtpay_grs.Text = "Invalid Text";
                }
            }
            if (!(txtpay_ernbas.Text == "") && !(txtpay_ernlvn.Text == "") && !(txtpay_alncvlu1.Text == "")&&!(txtpay_alncvlu2.Text==""))
            {
                double ern, lvn, alw1,alw2;
                bool iseValid = double.TryParse(txtpay_ernbas.Text, out ern);
                bool islValid = double.TryParse(txtpay_ernlvn.Text, out lvn);
                bool is1Valid = double.TryParse(txtpay_alncvlu1.Text, out  alw1);
                bool is2Valid = double.TryParse(txtpay_alncvlu2.Text, out alw2);
                if (iseValid && islValid && is1Valid && is2Valid)
                {
                    CalE = ern + lvn + alw1+alw2;
                    txtpay_grs.Text = Convert.ToString(CalE);
                }
                else
                {
                    txtpay_grs.Text = "Invalid Text";
                }
            }
            if (!(txtpay_ernbas.Text == "") && !(txtpay_ernlvn.Text == "") && !(txtpay_alncvlu1.Text == "") && !(txtpay_alncvlu2.Text == "")&&!(txtpay_alncvlu3.Text==""))
            {
                double ern, lvn, alw1, alw2,alw3;
                bool iseValid = double.TryParse(txtpay_ernbas.Text, out ern);
                bool islValid = double.TryParse(txtpay_ernlvn.Text, out lvn);
                bool is1Valid = double.TryParse(txtpay_alncvlu1.Text, out  alw1);
                bool is2Valid = double.TryParse(txtpay_alncvlu2.Text, out alw2);
                bool is3Valid = double.TryParse(txtpay_alncvlu3.Text, out alw3);
                if (iseValid && islValid && is1Valid && is2Valid && is3Valid)
                {
                    CalE = ern + lvn + alw1 + alw2+alw3;
                    txtpay_grs.Text = Convert.ToString(CalE);
                }
                else
                {
                    txtpay_grs.Text = "Invalid Text";
                }
            }
            if (!(txtpay_ernbas.Text == "") && !(txtpay_ernlvn.Text == "") && !(txtpay_alncvlu1.Text == "") && !(txtpay_alncvlu2.Text == "") && !(txtpay_alncvlu3.Text == "") && !(txtpay_alncvlu4.Text == ""))
            {
                double ern, lvn, alw1, alw2,alw3,alw4;
                bool iseValid = double.TryParse(txtpay_ernbas.Text, out ern);
                bool islValid = double.TryParse(txtpay_ernlvn.Text, out lvn);
                bool is1Valid = double.TryParse(txtpay_alncvlu1.Text, out  alw1);
                bool is2Valid = double.TryParse(txtpay_alncvlu2.Text, out alw2);
                bool is3Valid = double.TryParse(txtpay_alncvlu3.Text, out alw3);
                bool is4Valid = double.TryParse(txtpay_alncvlu4.Text, out alw4);
                if (iseValid && islValid && is1Valid && is2Valid && is3Valid && is4Valid)
                {
                    CalE = ern + lvn + alw1 + alw2+alw3+alw4;
                    txtpay_grs.Text = Convert.ToString(CalE);
                }
                else
                {
                    txtpay_grs.Text = "Invalid Text";
                }
            }
            if (!(txtpay_ernbas.Text == "") && !(txtpay_ernlvn.Text == "") && !(txtpay_alncvlu1.Text == "") && !(txtpay_alncvlu2.Text == "") && !(txtpay_alncvlu3.Text == "") && !(txtpay_alncvlu4.Text == "") && !(txtpay_alncvlu5.Text == ""))
            {
                double ern, lvn, alw1, alw2, alw3, alw4,alw5;
                bool iseValid = double.TryParse(txtpay_ernbas.Text, out ern);
                bool islValid = double.TryParse(txtpay_ernlvn.Text, out lvn);
                bool is1Valid = double.TryParse(txtpay_alncvlu1.Text, out  alw1);
                bool is2Valid = double.TryParse(txtpay_alncvlu2.Text, out alw2);
                bool is3Valid = double.TryParse(txtpay_alncvlu3.Text, out alw3);
                bool is4Valid = double.TryParse(txtpay_alncvlu4.Text, out alw4);
                bool is5Valid = double.TryParse(txtpay_alncvlu5.Text, out alw5);
                if (iseValid && islValid && is1Valid && is2Valid && is3Valid && is4Valid)
                {
                    CalE = ern + lvn + alw1 + alw2 + alw3 + alw4+alw5;
                    txtpay_grs.Text = Convert.ToString(CalE);
                }
                else
                {
                    txtpay_grs.Text = "Invalid Text";
                }
            }


            if (!(txtpay_stmp.Text == "") && !(txtpay_wop.Text == "") && !(txtpay_agr.Text == "") &&!(txtpay_fstad.Text==""))
            {
                double stm, wop,agr,fst;
                bool issValid = double.TryParse(txtpay_stmp.Text, out stm);
                bool iswValid = double.TryParse(txtpay_wop.Text, out wop);
                bool isaValid = double.TryParse(txtpay_agr.Text, out agr);
                bool isfValid = double.TryParse(txtpay_fstad.Text, out fst);
                if (issValid && iswValid && isaValid && isfValid )
                {
                    CalD = stm + wop+agr+fst;
                    txtpay_ded.Text = Convert.ToString(CalD);
                }
                else
                {
                    txtpay_ded.Text = "Invalid Text";
                }
            }

            if (!(txtpay_stmp.Text == "") && !(txtpay_wop.Text == "") && !(txtpay_agr.Text == "") && !(txtpay_fstad.Text == "")&&!(txtpay_lnvlu1.Text==""))
            {
                double stm, wop, agr, fst,ln1;
                bool issValid = double.TryParse(txtpay_stmp.Text, out stm);
                bool iswValid = double.TryParse(txtpay_wop.Text, out wop);
                bool isaValid = double.TryParse(txtpay_agr.Text, out agr);
                bool isfValid = double.TryParse(txtpay_fstad.Text, out fst);
                bool is1Valid = double.TryParse(txtpay_lnvlu2.Text, out ln1);
                if (issValid && iswValid && isaValid && isfValid && is1Valid)
                {
                    CalD = stm + wop + agr + fst+ ln1;
                    txtpay_ded.Text = Convert.ToString(CalD);
                }
                else
                {
                    txtpay_ded.Text = "Invalid Text";
                }
            }

            if (!(txtpay_stmp.Text == "") && !(txtpay_wop.Text == "") && !(txtpay_agr.Text == "") && !(txtpay_fstad.Text == "") && !(txtpay_lnvlu1.Text == "") && !(txtpay_lnvlu2.Text == ""))
            {
                double stm, wop, agr, fst, ln1 ,ln2;
                bool issValid = double.TryParse(txtpay_stmp.Text, out stm);
                bool iswValid = double.TryParse(txtpay_wop.Text, out wop);
                bool isaValid = double.TryParse(txtpay_agr.Text, out agr);
                bool isfValid = double.TryParse(txtpay_fstad.Text, out fst);
                bool is1Valid = double.TryParse(txtpay_lnvlu1.Text, out ln1);
                bool is2Valid = double.TryParse(txtpay_lnvlu2.Text, out ln2);
                if (issValid && iswValid && isaValid && isfValid && is1Valid && is2Valid)
                {
                    CalD = stm + wop + agr + fst + ln1 + ln2;
                    txtpay_ded.Text = Convert.ToString(CalD);
                }
                else
                {
                    txtpay_ded.Text = "Invalid Text";
                }
            }

            if (!(txtpay_stmp.Text == "") && !(txtpay_wop.Text == "") && !(txtpay_agr.Text == "") && !(txtpay_fstad.Text == "") && !(txtpay_lnvlu1.Text == "") && !(txtpay_lnvlu2.Text == "") && !(txtpay_lnvlu3.Text == ""))
            {
                double stm, wop, agr, fst, ln1, ln2, ln3;
                bool issValid = double.TryParse(txtpay_stmp.Text, out stm);
                bool iswValid = double.TryParse(txtpay_wop.Text, out wop);
                bool isaValid = double.TryParse(txtpay_agr.Text, out agr);
                bool isfValid = double.TryParse(txtpay_fstad.Text, out fst);
                bool is1Valid = double.TryParse(txtpay_lnvlu1.Text, out ln1);
                bool is2Valid = double.TryParse(txtpay_lnvlu2.Text, out ln2);
                bool is3Valid = double.TryParse(txtpay_lnvlu3.Text, out ln3);
                if (issValid && iswValid && isaValid && isfValid && is1Valid && is2Valid && is3Valid)
                {
                    CalD = stm + wop + agr + fst + ln1 + ln2 + ln3;
                    txtpay_ded.Text = Convert.ToString(CalD);
                }
                else
                {
                    txtpay_ded.Text = "Invalid Text";
                }
            }
        }

        public void NetCal()//Calculate net amount of payment
        {
            try
            {
                if (!(txtpay_grs.Text == "") && !(txtpay_ded.Text == ""))
                {
                    double grs = Convert.ToDouble(txtpay_grs.Text);
                    double ded = Convert.ToDouble(txtpay_ded.Text);
                    lblpay_net.Text = (grs - ded).ToString();
                }
            }
            catch (Exception)
            {
                
            }
        }

        public void SaveData()
        {
            try
            {
                if (!(txtpay_empNO.Text == "") && !(txtpay_empname.Text == "") && !(txtpay_empdesi.Text == "") && !(txtpay_ernbas.Text == "") && !(txtpay_ernlvn.Text == "") && !(txtpay_stmp.Text == "") && !(txtpay_wop.Text == "") && !(txtpay_fstad.Text == "") && !(txtpay_agr.Text == ""))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Payroll (Emp_NO, PayDate, Name, Designation, Basic, Cost_Of_Living, Alw1_Title, Alw1_Value, Alw2_Value, Alw3_Title, Alw3_Value, Alw4_Title, Alw4_Value, Alw5_Title, Alw5_Value, STAMP, [W&OP], Agrahara, Fest_Adv,Lon1_Title, Lon1_Value, Net_Pay, Ded_pay, Gross_Pay, Lon3_Value, Lon3_Title, Lon2_Value, Lon2_Title, Alw2_Title) VALUES('" + txtpay_empNO.Text + "','" + dtppay_day.Value.ToString() + "','" + txtpay_empname.Text + "','" + txtpay_empdesi.Text + "','" + txtpay_ernbas.Text + "','" + txtpay_ernlvn.Text + "','" + txtpay_alncttl1.Text + "','" + txtpay_alncvlu1.Text + "','" + txtpay_alncttl2.Text + "','" + txtpay_alncvlu2.Text + "','" + txtpay_alncttl3.Text + "','" + txtpay_alncvlu3.Text + "','" + txtpay_alncttl4.Text + "','" + txtpay_alncvlu4.Text + "','" + txtpay_alncttl5.Text + "','" + txtpay_alncvlu5.Text + "','" + txtpay_stmp.Text + "','" + txtpay_wop.Text + "','" + txtpay_agr.Text + "','" + txtpay_fstad.Text + "','" + txtpay_lnttl1.Text + "','" + txtpay_lnvlu1.Text + "','" + txtpay_lnttl2.Text + "','" + txtpay_lnvlu2.Text + "','" + txtpay_lnttl3.Text + "','" + txtpay_lnvlu3.Text + "','" + txtpay_grs.Text + "','" + txtpay_ded.Text + "','" + lblpay_net.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DONE");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Plese fill files");
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
                con.Close();
            }
            con.Close();
        }
        public void ClearData()
        {
            txtpay_empNO.Clear();
            txtpay_empname.Clear();
            txtpay_empdesi.Clear();
            txtpay_ernbas.Clear();
            txtpay_ernlvn.Clear();
            txtpay_stmp.Clear();
            txtpay_wop.Clear();
            txtpay_fstad.Clear();
            txtpay_agr.Clear();
            txtpay_grs.Clear();
            txtpay_ded.Clear();
            lblpay_net.Text = "";
            if (!(txtpay_alncttl1.Text == "") && !(txtpay_alncvlu1.Text == ""))
            {
                txtpay_alncttl1.Clear();
                txtpay_alncvlu1.Clear();
            }
            if (!(txtpay_alncttl2.Text == "") && !(txtpay_alncvlu2.Text == ""))
            {
                txtpay_alncttl2.Clear();
                txtpay_alncvlu2.Clear();
            }
            if (!(txtpay_alncttl3.Text == "") && !(txtpay_alncvlu3.Text == ""))
            {
                txtpay_alncttl3.Clear();
                txtpay_alncvlu3.Clear();
            }
            if (!(txtpay_alncttl4.Text == "") && !(txtpay_alncvlu4.Text == ""))
            {
                txtpay_alncttl4.Clear();
                txtpay_alncvlu4.Clear();
            }
            if (!(txtpay_alncttl5.Text == "") && !(txtpay_alncvlu5.Text == ""))
            {
                txtpay_alncttl5.Clear();
                txtpay_alncvlu5.Clear();
            }
            if (!(txtpay_lnttl1.Text == "") && !(txtpay_lnvlu1.Text == ""))
            {
                txtpay_lnttl1.Clear();
                txtpay_lnvlu1.Clear();
            }
            if (!(txtpay_lnttl2.Text == "") && !(txtpay_lnvlu2.Text == ""))
            {
                txtpay_lnttl2.Clear();
                txtpay_lnvlu2.Clear();
            }
            if (!(txtpay_lnttl3.Text == "") && !(txtpay_lnvlu3.Text == ""))
            {
                txtpay_lnttl3.Clear();
                txtpay_lnvlu3.Clear();
            }
        }
    }
}
