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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from RDV where DateRDV='{0}'", dateTimePicker1.Value));
            cmd.Connection = Program.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView1.DataSource = t;
            dr.Close();
            Program.cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.cn.Open();
            // dataGridView1.Rows[((DataGridView)sender).SelectedCells[0].RowIndex].Cells[0].Value)
            SqlCommand cmd = new SqlCommand(string.Format("select m.NomMedecin,m.SpecialiteMedecin from Medecin m inner join RDV r on m.CodeMedecin=r.CodeMedecin where r.NumeroRDV='{0}'", dataGridView1.CurrentRow.Cells[0].Value));
            cmd.Connection = Program.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox1.Text = dr[0].ToString();
            comboBox1.Text = dr[1].ToString();
            dr.Close();
           
            SqlCommand cmd2 = new SqlCommand(string.Format("select p.NomPatient,p.Datenaissance,p.SexePatient from Patient p inner join RDV r on p.CodePatient=r.CodePatient where r.NumeroRDV = '{0}'", dataGridView1.CurrentRow.Cells[0].Value));
            cmd2.Connection = Program.cn;
            SqlDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
            textBox2.Text = dr2[0].ToString();
            dateTimePicker2.Value = DateTime.Parse(dr2[1].ToString());
            if (dr2[2].ToString()=="femme")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            dr2.Close();
            Program.cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dataGridView1.DataSource = null;


        }
    }
}
