﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bolimlar
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Baza"].ConnectionString);
            sqlConnection.Open();

            if (sqlConnection.State ==ConnectionState.Open)
            {
                MessageBox.Show("Ulandi");
            }
        }
    }
}
