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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
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
        }

        private void button2_Click(object sender, EventArgs e)
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
                    Program.cn.Open();
                    SqlCommand cmd = new SqlCommand(string.Format("select * from Patient where CodePatient='{0}'", textBox1.Text), Program.cn);
                    cmd.Connection = Program.cn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                    dateTimePicker1.Value = DateTime.Parse(dr[3].ToString());
                    if (dr[4].ToString() == "femme")
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || (!radioButton1.Checked && !radioButton2.Checked) || dateTimePicker1.Value == DateTime.Now)
            {
                MessageBox.Show("Un ou plusieur cham est vide");
            }
            else
            {
                if (Program.ExistePatient(textBox1.Text))
                {
                    MessageBox.Show("Patient déja existé ");
                }
                else
                {
                    string sexe;
                    Program.cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.cn;
                    if (radioButton1.Checked)
                    {
                        sexe = "Femme";
                    }
                    else
                    {
                        sexe = "Homme";
                    }
                    cmd.CommandText = string.Format("insert into Patient values('{0}', '{1}', '{2}','{3}','{4}')", textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, sexe);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajouter avec succées");
                    Program.cn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || (!radioButton1.Checked && !radioButton2.Checked) || dateTimePicker1.Value == DateTime.Now)
            {
                MessageBox.Show("Un ou plusieur cham est vide");
            }
            else
            {
                if (!Program.ExistePatient(textBox1.Text))
                {
                    MessageBox.Show("Patient n'existe pas");
                }
                else
                {
                    string sexe="";
                    Program.cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.cn;
                    if (radioButton1.Checked)
                    {
                        sexe = "femme";
                    }
                    else
                    {
                        sexe = "Homme";
                    }
                    cmd.CommandText = string.Format("update Patient set NomPatient='{0}',AdressePatient='{1}',Datenaissance='{2}',SexePatient='{3}' where CodePatient='{4}'", textBox2.Text, textBox3.Text, dateTimePicker1.Value,sexe, textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modifié avec succès");
                    Program.cn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Le Champ de Code est vide");
            }
            else
            {
                if (!Program.ExistePatient(textBox1.Text))
                {
                    MessageBox.Show("Patient n'existe pas ");
                }
                else
                {
                    Program.cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd.Connection = Program.cn;
                    cmd2.Connection = Program.cn;
                    //il faut d'abord supprimer le rendez-vous pour supprimer un patient 
                    cmd.CommandText = string.Format("delete  from RDV where CodePatient =  '{0}'", textBox1.Text);
                    cmd2.CommandText = string.Format("delete  from Patient where CodePatient = '{0}'", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Supprission avec succées");
                    Program.cn.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
