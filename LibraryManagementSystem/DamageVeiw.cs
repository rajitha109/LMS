﻿using System;
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
    public partial class frmDamageVeiw : Form
    {
        public frmDamageVeiw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Library_Management_System;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        private void frmDamageVeiw_Load(object sender, EventArgs e)
        {
            string select = "SELECT * FROM [Library_Management_System].[dbo].[Damage_Fine]";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            grddamage.ReadOnly = true;
            grddamage.DataSource = dt;
            grddamage.Dock = DockStyle.Fill;
        }
    }
}
