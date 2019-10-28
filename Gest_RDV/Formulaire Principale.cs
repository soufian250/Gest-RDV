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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        

        private void gestionDesPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 FR = new Form3();
            //FR.MdiParent = this;
            FR.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void gestionDesMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FR = new Form2();

            // FR.MdiParent = this;
             FR.ShowDialog();
            //FR.Show();
           
        }

        private void gestionDesRDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 FR = new Form4();
            //FR.MdiParent = this;
            FR.ShowDialog();
        }

        private void afficherToutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form5 FR = new Form5();
            //FR.MdiParent = this;
            FR.ShowDialog();
        }

        private void rechercherRDVParDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 FR = new Form6();
            //FR.MdiParent = this;
            FR.ShowDialog();
        }

        private void afficherLesRDVDunPatienrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 FR = new Form7();
            //FR.MdiParent = this;
            FR.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
