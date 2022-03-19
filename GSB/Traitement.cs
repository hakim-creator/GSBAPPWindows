using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class Traitement
    {
        
        private string dateTraitemant;
        private string heureDebut;
        private string heureFin;
        private string travRealiser;


        public Traitement( string uneDateTraitement, string uneHeureDebut, string uneHeureFin, string unTravRealis)
        {
            
            dateTraitemant = uneDateTraitement;
            heureDebut = uneHeureDebut;
            heureFin = uneHeureFin;
            travRealiser = unTravRealis;
        }

        
        public string getDateTraitement()
        {
            return dateTraitemant;
        }
        public string getHeureDebut()
        {
            return heureDebut;
        }

        public string getHeureFin()
        {
            return heureFin;
        }
        public string getTravRealis()
        {
            return travRealiser;
        }
    }
}
