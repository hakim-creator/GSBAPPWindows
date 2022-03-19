using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GSB
{
    public partial class Responsable : Form
    {
        public Responsable()
        {
            InitializeComponent();
        }

        
        
        private void Responsable_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonAjoutTechn_Click(object sender, EventArgs e)
        {


            Techniciens unTechnicien;
            


            unTechnicien = new Techniciens(textBoxNomTech.Text, textBoxPrenomTech.Text, textBoxMatriculeTech.Text, textBoxDateTech.Text, textBoxRegionTech.Text, textBoxEmailTech.Text, textBoxPosteTech.Text, textBoxIdentifTech.Text, textBoxMotPasseTech.Text, textBoxFormation.Text, textBoxNiveauIntervention.Text, textBoxCompetence.Text);

            BD.AjoutTech(unTechnicien);



            MessageBox.Show("Technicien enregistrer");
        }

        private void buttonAjouterUtil_Click(object sender, EventArgs e)
        {
            Visiteur unVisiteur;
            
            

            unVisiteur = new Visiteur(textBoxNomUtil.Text, textBoxPrenomUtil.Text,textBoxMatriculeUtil.Text, textBoxDateUtil.Text, textBoxRegionUtil.Text, textBoxEmailUtil.Text,textBoxPosteUtil.Text, textBoxIdentifUtil.Text, textBoxMotPasseUtil.Text);
           
            BD.AjoutUtil(unVisiteur);

            MessageBox.Show("Utilisateur enregistrer");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("logo");
        }

        private void buttonSuppTech_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAffichSalarie_Click(object sender, EventArgs e)
        {


            string Decl = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(Decl);

            conn.Open();



            MySqlDataAdapter Salarie = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            Salarie.SelectCommand = new MySqlCommand("SELECT * FROM salarie", conn);
            Salarie.Fill(ds);

            dataGridViewSupSalarie.DataSource = ds.Tables[0];
            dataGridViewSupSalarie.Refresh();





            conn.Close();



            

            

        }

        private void buttonState_Click(object sender, EventArgs e)
        {
            string Decl = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(Decl);

            conn.Open();



            MySqlDataAdapter Salarie = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            Salarie.SelectCommand = new MySqlCommand("SELECT * FROM salarie", conn);
            Salarie.Fill(ds);

            dataGridViewSalarie.DataSource = ds.Tables[0];
            dataGridViewSalarie.Refresh();

            



            conn.Close();



            
        }

        private void buttonAfficheIncident_Click(object sender, EventArgs e)
        {

            string Decl = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(Decl);

            conn.Open();



            MySqlDataAdapter Technicien = new MySqlDataAdapter();
            DataSet tech = new DataSet();

            Technicien.SelectCommand = new MySqlCommand("SELECT * FROM probleme", conn);
            Technicien.Fill(tech);

            dataGridViewIncident.DataSource = tech.Tables[0];
            dataGridViewIncident.Refresh();





            conn.Close();

            
        }
    }
}
