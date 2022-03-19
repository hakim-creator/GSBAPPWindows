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
    public partial class Utilisateur : Form
    {
        public Utilisateur()
        {
            InitializeComponent();
        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeclIncident_Click(object sender, EventArgs e)
        {
            string etats="", charge="", message="";
            Probleme unProbleme;



            unProbleme = new Probleme(textBoxObjet.Text, textBoxNivUrg.Text, textBoxDateInterv.Text, textBoxZoneInterv.Text, etats, charge, message);
            BD.DeclarIncid(unProbleme);



            MessageBox.Show("Incident déclarer");
        }

        private void buttonAfficherMessage_Click(object sender, EventArgs e)
        {
            string Incid = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(Incid);

            conn.Open();

            MySqlDataAdapter Incident = new MySqlDataAdapter();
            DataSet affiche = new DataSet();

            Incident.SelectCommand = new MySqlCommand("SELECT objet, Message FROM probleme", conn);
            Incident.Fill(affiche);

            dataGridViewMessage.DataSource = affiche.Tables[0];
            dataGridViewMessage.Refresh();



            conn.Close();
        }
    }
}
