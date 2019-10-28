using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gest_RDV
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox4.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Clear();
                }
            }
            comboBox1.Text = "";

            comboBox2.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            dateTimePicker1.Value = DateTime.Now;
            maskedTextBox1.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            //comboBox2.DropDownStyle = ComboBoxStyle.DropDown;


            Program.cn.Open();
            SqlCommand cmd = new SqlCommand("select CodePatient from Patient ", Program.cn);
            cmd.Connection = Program.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("select CodeMedecin from Medecin", Program.cn);
            cmd2.Connection = Program.cn;
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            dr2.Close();

            Program.cn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand("select NomPatient,SexePatient from Patient where CodePatient = '" + comboBox2.SelectedItem + "'", Program.cn);
            cmd.Connection = Program.cn;
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            textBox2.Text = dr[0].ToString();
            if (dr[1].ToString() == "femme")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            dr.Close();
            Program.cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand("select NomMedecin,SpecialiteMedecin from Medecin where CodeMedecin = '" + comboBox1.SelectedItem + "'", Program.cn);
            cmd.Connection = Program.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox1.Text = dr[0].ToString();
            textBox3.Text = dr[1].ToString();
            dr.Close();
            Program.cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Le numéro de RDV doit étre incrimenté automatiquement
            
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.cn;
            cmd.CommandText = string.Format("insert into RDV(DateRDV,HeureRDV,CodeMedecin,CodePatient) values('{0}','{1}','{2}','{3}')", dateTimePicker1.Value, maskedTextBox1.Text, comboBox1.SelectedItem, comboBox2.Text);
            cmd.ExecuteNonQuery();
            Program.cn.Close();
            MessageBox.Show("RDV ajouter avec succée");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
