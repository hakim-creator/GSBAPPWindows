using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class Probleme
    {
       
        
        private string objet;
        private string nivUrgence;
        private string dateIncid;
        private string ZoneInterv;
        private string etats;
        private string priseCharge;
        private string message;


        public Probleme( string unObjet, string unNivUrgence, string uneDateIncid, string uneZoneInterv, string unEtats, string unePriseCharge, string unMessage)
        {
            
            objet = unObjet;
            nivUrgence = unNivUrgence;
            dateIncid = uneDateIncid;
            ZoneInterv = uneZoneInterv;
            etats = unEtats;
            priseCharge = unePriseCharge;
            message = unMessage;
        }

        
        public string getObjet()
        {
            return objet;
        }
        public string getNivUrgence()
        {
            return nivUrgence;
        }
        public string getDateIncid()
        {
            return dateIncid;
        }
        public string getZoneInterv()
        {
            return ZoneInterv;
        }
        public string getEtats()
        {
            return etats;
        }
        public string getPriseCharge()
        {
            return priseCharge;
        }
        public string getMessage()
        {
            return message;
        }
    }
}
