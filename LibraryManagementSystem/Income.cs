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
    public partial class frmincome : Form
    {
        public frmincome()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");

        private void frmincome_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnincm_add;          
        }

        private void btnincm_add_Click(object sender, EventArgs e)
        {
            if (cmbincm_action.Text == "Sell")
            {
                SaveSellIncome();
            }
            else if (cmbincm_action.Text == "Other")
            {
                SaveOtherIncome();
            }
        }

        private void btnincm_refresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cmbincm_Ityp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbincm_Ityp.Text == "Other")
            {
                txtincm_SNO.Enabled = true;
            }
            else
            {
                txtincm_SNO.Enabled = false;
            }
        }

        private void chkincm_crtrst_CheckedChanged(object sender, EventArgs e)
        {
            ReceiptGen();
        }

        private void cmbincm_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            Look();
        }

        private void txtincm_Icap_TextChanged(object sender, EventArgs e)//Text change event
        {
            CalIncomesell();
        }

        private void txtinccm_vpu_TextChanged(object sender, EventArgs e)//Text change event
        {
            CalIncomesell();
        }

        public void CalIncomesell()//Calculate selling income
        {
            double Icap, VPU;
            bool isIValid = double.TryParse(txtincm_Icap.Text, out Icap);
            bool isUValid = double.TryParse(txtinccm_vpu.Text, out VPU);

            if (isIValid && isUValid)
            {
                double Cal = Icap * VPU;
                lblincm_Sdis.Text = Convert.ToString(Cal);
            }
            else
            {
                lblincm_Sdis.Text = "Invalied Input";
            }  
        }

        private void txtincm_Ocap_TextChanged(object sender, EventArgs e)//Text change event
        {
            CalIncomeOther();
        }

        private void txtincm_Ovlu_TextChanged(object sender, EventArgs e)//Text change event
        {
            CalIncomeOther();
        }

        public void CalIncomeOther()//Calulate other income
        {
            double VPU, Qun;
            bool isQValid = double.TryParse(txtincm_Ocap.Text, out Qun);
            bool isUValid = double.TryParse(txtincm_Ovlu.Text, out VPU);

            if (isUValid && isQValid)
            {
                double Cal = Qun * VPU;
                lblincm_Odis.Text = Convert.ToString(Cal);
            }
            else
            {
                lblincm_Odis.Text = "Invalied Input";
            } 
        }

        public void ReceiptGen()//Genarate receipt for oyher income
        {
            string rstp = "HTC/i";
            con.Open();
            SqlCommand cmd_gen = new SqlCommand("SELECT COUNT([Receipt_NO]) FROM [Library_Management_System].[dbo].[Other_Income]", con);
            int i = Convert.ToInt32(cmd_gen.ExecuteScalar());
            con.Close();

            i++;
            txtincm_rstno.Text = rstp + i.ToString();
        }

        public void SaveSellIncome()
        {
            try
            {
                if (!(cmbincm_action.Text == "") && !(txtincm_rstno.Text == "") && !(cmbincm_Ityp.Text == "") && !(txtincm_Icap.Text == "") && !(cmbincm_Sunit.Text == "") && !(txtinccm_vpu.Text == "") && !(txtincm_Slctn.Text == "") && !(lblincm_Sdis.Text == ""))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Sell_Income (Receipt_NO, Action_Type, Item_Type, Other_Type, Item_ID, Item_Cap, Item_Unit, Value_Pre_Unit, Form, [To], Location, Income) VALUES ('" + this.txtincm_rstno.Text + "','" + this.cmbincm_action.Text + "','" + this.cmbincm_Ityp.Text + "','" + this.txtincm_SNO.Text + "','" + this.txtincm_itemID.Text + "','" + this.txtincm_Icap.Text + "','" + this.cmbincm_Sunit.Text + "','" + this.txtinccm_vpu.Text + "','" + dtpincm_Sfrom.Value.ToShortDateString() + "','" + dtpincm_Sto.Value.ToShortDateString() + "','" + this.txtincm_Slctn.Text + "','" + this.lblincm_Sdis.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Done Saving");
                        ClearData();
                }
                else
                {
                    MessageBox.Show("You left filed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            con.Close();
        }

        public void SaveOtherIncome()
        {
            try
            {
                if (!(cmbincm_action.Text == "") && !(txtincm_rstno.Text == "") && !(txtincm_Oearn.Text == "") && !(txtincm_Omore.Text == "") && !(txtincm_Ocap.Text == "") && !(txtincm_Ounit.Text == "") && !(txtincm_Ovlu.Text == "") && !(txtincm_Olctn.Text == "") && !(lblincm_Odis.Text == ""))
                {
                    con.Open();

                    string query = "INSERT INTO [Library_Management_System].[dbo].[Other_Income]([Receipt_No],[Action_Type],[More_Details],[Earning_Capacity],[Earning_Unit],[Eaarinig_Value],[From],[To],[Location],[Income])VALUES ('" + this.txtincm_rstno.Text + "','" + this.cmbincm_action.Text + "','" + this.txtincm_Omore.Text + "','" + this.txtincm_Ocap.Text + "','" + this.txtincm_Ounit.Text + "','" + this.txtincm_Ovlu.Text + "','" + dtpincm_Ofrom.Value.ToShortDateString() + "','" + dtpincm_Oto.Value.ToShortDateString() + "','" + this.txtincm_Olctn.Text + "','" + this.lblincm_Odis.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("You Have Left Fileds");
                }
            }
            catch
            {
                con.Close();
            }
            con.Close();
        }

        public void ClearData()
        {
            
            if (cmbincm_action.Text == "Sell")
            {
                if (cmbincm_Ityp.Text == "Other")
                {
                    txtincm_SNO.Clear();
                }
                if (!(txtincm_itemID.Text == ""))
                {
                    txtincm_itemID.Clear();
                }
                txtincm_Icap.Clear();
                cmbincm_Sunit.SelectedIndex = -1;
                txtinccm_vpu.Clear();
                txtincm_Slctn.Clear();
                cmbincm_Ityp.SelectedIndex = -1;
                lblincm_Sdis.Text = "";
            }
            if (cmbincm_action.Text == "Other")
            {
                txtincm_Oearn.Clear();
                txtincm_Omore.Clear();
                txtincm_Ocap.Clear();
                txtincm_Ounit.Clear();
                txtincm_Ovlu.Clear();
                txtincm_Olctn.Clear();
                chkincm_crtrst.Checked = false;
                lblincm_Odis.Text = "";
            }
            cmbincm_action.SelectedIndex = -1;
            txtincm_rstno.Clear();
        }

        public void Look()//Lock and unlock select side
        {
            if (cmbincm_action.Text == "Sell")
            {
                cmbincm_Ityp.Enabled = true;//Sell
                txtincm_SNO.Enabled = true;
                txtincm_itemID.Enabled = true;
                txtincm_Icap.Enabled = true;
                cmbincm_Sunit.Enabled = true;
                txtinccm_vpu.Enabled = true;
                dtpincm_Sfrom.Enabled = true;
                dtpincm_Sto.Enabled = true;
                txtincm_Slctn.Enabled = true;

                txtincm_Oearn.Enabled = false;//Other
                txtincm_Omore.Enabled = false;
                txtincm_Ocap.Enabled = false;
                txtincm_Ounit.Enabled = false;
                txtincm_Ovlu.Enabled = false;
                dtpincm_Ofrom.Enabled = false;
                dtpincm_Oto.Enabled = false;
                txtincm_Olctn.Enabled = false;
                chkincm_crtrst.Enabled = false;
            }
            else if (cmbincm_action.Text == "Other")
            {
                txtincm_Oearn.Enabled = true;//Other
                txtincm_Omore.Enabled = true;
                txtincm_Ocap.Enabled = true;
                txtincm_Ounit.Enabled = true;
                txtincm_Ovlu.Enabled = true;
                dtpincm_Ofrom.Enabled = true;
                dtpincm_Oto.Enabled = true;
                txtincm_Olctn.Enabled = true;
                chkincm_crtrst.Enabled = true;

                cmbincm_Ityp.Enabled = false;//Sell
                txtincm_SNO.Enabled = false;
                txtincm_itemID.Enabled = false;
                txtincm_Icap.Enabled = false;
                cmbincm_Sunit.Enabled = false;
                txtinccm_vpu.Enabled = false;
                dtpincm_Sfrom.Enabled = false;
                dtpincm_Sto.Enabled = false;
                txtincm_Slctn.Enabled = false;
            }
            else if (cmbincm_action.Text == "")
            {
                cmbincm_Ityp.Enabled = false;//Sell
                txtincm_SNO.Enabled = false;
                txtincm_itemID.Enabled = false;
                txtincm_Icap.Enabled = false;
                cmbincm_Sunit.Enabled = false;
                txtinccm_vpu.Enabled = false;
                dtpincm_Sfrom.Enabled = false;
                dtpincm_Sto.Enabled = false;
                txtincm_Slctn.Enabled = false;

                txtincm_Oearn.Enabled = false;//Other
                txtincm_Omore.Enabled = false;
                txtincm_Ocap.Enabled = false;
                txtincm_Ounit.Enabled = false;
                txtincm_Ovlu.Enabled = false;
                dtpincm_Ofrom.Enabled = false;
                dtpincm_Oto.Enabled = false;
                txtincm_Olctn.Enabled = false;
                chkincm_crtrst.Enabled = false;
            }
        }

    }
}
