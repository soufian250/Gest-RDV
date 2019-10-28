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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Le champ de Code est vide");
            }
            else
            {
                if (Program.ExistePatient(textBox1.Text) == false)
                {
                    MessageBox.Show("Patient n'existe pas");
                }
                else
                {

                    Mise_a_JourData();

                    SqlCommand cmd2 = new SqlCommand(string.Format("select NomPatient,AdressePatient,Datenaissance,SexePatient from Patient where CodePatient='{0}'", textBox1.Text));
                    cmd2.Connection = Program.cn;
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    dr2.Read();
                    textBox2.Text = dr2[0].ToString();
                    textBox3.Text = dr2[1].ToString();
                    dateTimePicker1.Value = DateTime.Parse(dr2[2].ToString());
                    if (dr2[3].ToString() == "femme")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;

                    dr2.Close();
                    Program.cn.Close();
                    VidierLesChamp();

                }


            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.cn.Open();
            // dataGridView1.Rows[((DataGridView)sender).SelectedCells[0].RowIndex].Cells[0].Value)
            SqlCommand cmd = new SqlCommand(string.Format("select NumeroRDV,CodeMedecin,DateRDV,HeureRDV from RDV where CodeMedecin = {0} ", dataGridView1.CurrentRow.Cells[3].Value),Program.cn);
            cmd.Connection = Program.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox5.Text = dr[0].ToString();
            comboBox1.Text = dr[1].ToString();
            dateTimePicker2.Value = DateTime.Parse(dr[2].ToString());
            maskedTextBox1.Text = dr[3].ToString();
            dr.Close();
            Program.cn.Close();

            //Form2 FR = new Form2();
            //FR.MdiParent = this;
            //FR.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Program.cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update RDV set DateRDV='{0}' , HeureRDV='{1}' , CodeMedecin='{2}' where NumeroRDV= '{3}'", dateTimePicker2.Value, maskedTextBox1.Text, comboBox1.Text,textBox5.Text), Program.cn);
            cmd.Connection = Program.cn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Enregistrement avec succées");
            //Changer la date instantaniement
           // **dataGridView1.Rows[int.Parse(textBox5.Text)].Cells[2].Value = maskedTextBox1.Text;
            Program.cn.Close();

            Mise_a_JourData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from RDV where NumeroRDV='{0}'", textBox5.Text), Program.cn);
            cmd.Connection = Program.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView1.DataSource = t;
            dr.Close();
            Program.cn.Close();
            VidierLesChamp();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Clear();
                }
            }
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dataGridView1.DataSource = null;
            VidierLesChamp();
            
        }

        private void VidierLesChamp()
        {
            textBox5.Text = "";
            dateTimePicker2.Value = DateTime.Now;
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
        }

        private void Mise_a_JourData()
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from RDV where CodePatient='{0}'", textBox1.Text), Program.cn);
            cmd.Connection = Program.cn;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView1.DataSource = t;
            dr.Close();
        }
    }
}
