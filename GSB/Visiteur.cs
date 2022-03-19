using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB
{
    class Visiteur: Salarie
    {
        
        

        public Visiteur( string nom, string prenom, string matricule, string dateAmb, string region, string email, string poste, string identifiant, string mot_passe)
            : base( nom, prenom, matricule, dateAmb, region, email, poste, identifiant, mot_passe)
        {
            
            ;
        }

        
        
    }
}
