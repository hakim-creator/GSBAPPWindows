using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Technicien : Form
    {
        public Technicien()
        {
            InitializeComponent();
        }
        
        private void Technicien_Load(object sender, EventArgs e)
        {
            
        }


        private void buttonEnregMat_Click(object sender, EventArgs e)
        {
            String garantie="", louer="";
            if (radioButtonOuiGarantie.Checked)
            {
                garantie = "Oui";
            }
            else
            {
                garantie = "Non";
            }
            if (radioButtonOuiLouer.Checked)
            {
                louer = "Oui";
            }
            else
            {
                louer = "Non";
            }

            Materiel unMateriel;

            unMateriel = new Materiel(textBoxTypeMateriel.Text, textBoxDateAchat.Text, garantie, textBoxForunisseur.Text, louer);

            BD.AjoutMateriel(unMateriel);

            

            MessageBox.Show("Materiel ajouter");
        }

        private void buttonPrendreCharge_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridViewIncident.SelectedRows[0].Cells[0].Value);
            string charge = "";
            string objet="", niv="", date="", zone="", etats="";
            if (radioButtonchargeOui.Checked)
            {
                charge = "Oui";
            }
            else
            {
                charge = "Non";
            }

            Probleme uneCharge;
            uneCharge = new Probleme(objet, niv, date, zone, etats,charge,textBoxMessage.Text);
            BD.PriseCharge(uneCharge);

            

            MessageBox.Show("Mise a jour des charge");
        }

        private void buttonModifEtat_Click(object sender, EventArgs e)
        {
            string traitement = "";
            string objet = "", niv = "", date = "", zone = "", charge = "", message = "";
            if (radioButtonResolu.Checked)
            {
                traitement = "Resolu";
            }
            else
                if (radioButtonEncoursTraitement.Checked)
            {
                traitement = "En cours de traitment";
            }
            else
            {
                traitement = "Non Resolu";
            }
            Traitement unTraitement;
            unTraitement = new Traitement(textBoxDateTraitement.Text, textBoxHeureDebut.Text, textBoxHeureFin.Text, textBoxTravEffectuer.Text);
            BD.Traitement(unTraitement);



            
            Probleme uneEtats;
            uneEtats = new Probleme(objet, niv, zone, date , traitement, charge, message);
            BD.PriseCharge(uneEtats);

            MessageBox.Show("Traitement Mise a jour");
        }

        private void buttonAfficherMateriel_Click(object sender, EventArgs e)
        {
            string Tech = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(Tech);

            conn.Open();

            MySqlDataAdapter Materiel = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            Materiel.SelectCommand = new MySqlCommand("SELECT * FROM materiel", conn);
            Materiel.Fill(ds);
            
            dataGridViewMateriel.DataSource = ds.Tables[0];
            dataGridViewMateriel.Refresh();



            conn.Close();
        }

        private void buttonAfficherIncident_Click(object sender, EventArgs e)
        {
            string Incid = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(Incid);

            conn.Open();

            MySqlDataAdapter Incident = new MySqlDataAdapter();
            DataSet affiche = new DataSet();

            Incident.SelectCommand = new MySqlCommand("SELECT * FROM probleme", conn);
            Incident.Fill(affiche);

            dataGridViewIncident.DataSource = affiche.Tables[0];
            dataGridViewIncident.Refresh();



            conn.Close();
        }

        private void buttonSupMat_Click(object sender, EventArgs e)
        {
           

            int id = Convert.ToInt16(dataGridViewSupprimerMateriel.SelectedRows[0].Cells[0].Value);

            BD.SupMateriel(id);
            MessageBox.Show("supprimer");
        }

        private void buttonAfficherMat_Click(object sender, EventArgs e)
        {
            
            string Incid = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(Incid);

            conn.Open();

            MySqlDataAdapter Incident = new MySqlDataAdapter();
            DataSet affiche = new DataSet();

            Incident.SelectCommand = new MySqlCommand("SELECT * FROM materiel", conn);
            Incident.Fill(affiche);

            dataGridViewSupprimerMateriel.DataSource = affiche.Tables[0];
            dataGridViewSupprimerMateriel.Refresh();

           



            conn.Close();

            MessageBox.Show("Afficher");
            
        }
    }
}
