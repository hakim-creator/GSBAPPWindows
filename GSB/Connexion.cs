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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            
                Utilisateur Util = new Utilisateur();
                Util.ShowDialog();
            
        }

        private void buttonResponsable_Click(object sender, EventArgs e)
        {
            Responsable Resp = new Responsable();
            Resp.ShowDialog();
        }

        private void buttonTechnicien_Click(object sender, EventArgs e)
        {
            Technicien Tech = new Technicien();
            Tech.ShowDialog();
        }
    }
}
