using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class Materiel
    {
        
        private string typeMateriel;
        private string dateAchat;
        private string garantie;
        private string fournisseur;
        private string louer;

        public Materiel( string unTypeMateriel, string uneDateAchat, string unGarantie, string unForunisseur, string lalouer)
        {
            
            typeMateriel = unTypeMateriel;
            dateAchat = uneDateAchat;
            garantie = unGarantie;
            fournisseur = unForunisseur;
            louer = lalouer;
        }

        
        public string getTypeMateriel()
        {
            return typeMateriel;
        }
        public string getDateAchat()
        {
            return dateAchat;
        }
        public string getGarantie()
        {
            return garantie;
        }
        public string getFournisseur()
        {
            return fournisseur;
        }
        public string getLouer()
        {
            return louer;
        }
        
    }
}
