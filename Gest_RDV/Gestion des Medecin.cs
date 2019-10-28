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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Cardiologie", "Chirurgie", "Dermatologie", "Gériatrie", "Oncologie", "Pediatrie", "psychiatrie", "Allergologie" });
        }

        private void ViderChamp()
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
            comboBox1.Text = " ";/*A la retour*/
            maskedTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViderChamp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Le champ de Code est vide");
            }
            else
            {
                if (Program.ExisteMedecin(textBox1.Text) == false)
                {
                    MessageBox.Show("Medecin n'existe pas");
                    textBox2.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox1.SelectedText="";/*A la retour*/
                    maskedTextBox1.Text = "";
                }
                else
                {
                    Program.cn.Open();
                    SqlCommand cmd = new SqlCommand(string.Format("select * from Medecin where CodeMedecin='{0}'", textBox1.Text), Program.cn);
                    cmd.Connection = Program.cn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    maskedTextBox1.Text = dr[2].ToString();
                    dateTimePicker1.Value = DateTime.Parse(dr[3].ToString());
                    comboBox1.Text = dr[4].ToString();
                    dr.Close();
                    Program.cn.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // pas complet
            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text.Length < 10 || comboBox1.SelectedIndex == -1 || dateTimePicker1.Value == DateTime.Now)
            {
                MessageBox.Show("Vérifier le remplisage de tout les champs");
            }
            else
            {
                if (Program.ExisteMedecin(textBox1.Text))
                {
                    MessageBox.Show("Medecin existe déja");
                }
                else
                {
                    Program.cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.cn;
                    cmd.CommandText = string.Format("insert into Medecin values('{0}', '{1}', '{2}','{3}','{4}')", textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, comboBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajouter avec succées");
                    Program.cn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text.Length < 10 || comboBox1.SelectedIndex == -1/* || dateTimePicker1.Value == DateTime.Now*/)
            {
                MessageBox.Show("Vérifier le remplisage de tout les champ");
            }
            else
            {
                if (Program.ExisteMedecin(textBox1.Text) == false)
                {
                    MessageBox.Show("Medecin n'existe pas");
                }
                else
                {
                    Program.cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.cn;
                    cmd.CommandText = string.Format("update  Medecin  set NomMedecin='{0}',TelMedecin='{1}',DateEmbauche='{2}',SpecialiteMedecin='{3}' where CodeMedecin='{4}'", textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value,comboBox1.Text, textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modifié avec succès");
                    Program.cn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Le Champ de Code est vide");
            }
            else
            {
                if (!Program.ExisteMedecin(textBox1.Text))
                {
                    MessageBox.Show("Medecin n'existe pas ");
                }
                else
                {

                    if (MessageBox.Show("Voulez-vous vraiment supprimer??", "Message de confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Program.cn.Open();
                        SqlCommand cmd = new SqlCommand();
                        SqlCommand cmd2 = new SqlCommand();
                        cmd.Connection = Program.cn;
                        cmd2.Connection = Program.cn;
                        cmd.CommandText = string.Format("delete  from RDV where CodeMedecin = '{0}'", textBox1.Text);
                        cmd2.CommandText = string.Format("delete  from Medecin where CodeMedecin = '{0}'", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Supprission avec succées");
                        Program.cn.Close();
                        textBox2.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        comboBox1.SelectedText = "";/*A la retour*/
                        maskedTextBox1.Text = "";
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
