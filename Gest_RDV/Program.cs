using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gest_RDV
{

    static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public SqlConnection cn = new SqlConnection("Data Source=SOUFIAN-PC\\SQLEXPRESS_HAB;initial catalog=Gest_RDV;Integrated Security=True");

        static public bool ExisteMedecin(string codeMedecin)
        {
            bool existe = false;
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = string.Format("select * from Medecin where CodeMedecin='{0}'", codeMedecin);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                existe = true;
            }
            dr.Close();
            cn.Close();
            return existe;

        }
        static public bool ExistePatient(string codePatient)
        {
            bool existe = false;
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = string.Format("select * from Patient where CodePatient='{0}'", codePatient);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                existe = true;
            }
            dr.Close();
            cn.Close();
            return existe;

        }
    }
}
