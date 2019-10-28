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

namespace Gest_RDV
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Medecin ", Program.cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView1.DataSource = t;
            dr.Close();
           Program.cn.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Patient ", Program.cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView1.DataSource = t;
            dr.Close();
            Program.cn.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from RDV ", Program.cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView1.DataSource = t;
            dr.Close();
            Program.cn.Close();
        }
    }
}
