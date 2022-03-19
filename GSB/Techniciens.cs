using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class Techniciens:Salarie
    {
        
        private string formation;
        private string nivIntervention;
        private string competence;

        public Techniciens( string nom, string prenom, string matricule, string dateAmb, string region, string email, string poste, string identifiant, string mot_passe, string uneformation, string unNivIntervention, string uneCompetence)
            : base(nom, prenom, matricule, dateAmb,region, email, poste, identifiant, mot_passe  )
        {
           
            formation = uneformation;
            nivIntervention = unNivIntervention;
            competence = uneCompetence;
        }
        
        
        public string getFormation()
        {
            return formation;
        }
        public string getNivIntervention()
        {
            return nivIntervention;
        }
        public string getCompetence()
        {
            return competence;
        }
    }
}
