using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class Salarie
    {
        
        private string nom;
        private string prenom;
        private string matricule;
        private string dateAmb;
        private string region;
        private string email;
        private string poste;
        private string identifiant;
        private string mot_passe;


        public Salarie( string nom, string prenom, string matricule, string dateAmb, string region, string email, string poste, string identifiant, string mot_passe)
        {
           
            this.nom = nom;
            this.prenom = prenom;
            this.matricule = matricule;
            this.dateAmb = dateAmb;
            this.region = region;
            this.email = email;
            this.poste = poste;
            this.identifiant = identifiant;
            this.mot_passe = mot_passe;
        }

       

        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }

        public string getMatricule()
        {
            return matricule;
        }
        public string getDateAmb()
        {
            return dateAmb;
        }
        public string getRegion()
        {
            return region;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPoste()
        {
            return poste;
        }
        public string getIdentifiant()
        {
            return identifiant;
        }
        public string getMot_passe()
        {
            return mot_passe;
        }

        public void setNom(string desNoms)
        {
            desNoms = nom;
        }
        public void setPrenom(string Prenom)
        {
            Prenom = prenom;
        }
        public void setMatricule(string matric)
        {
            matric = matricule;
        }
        public void setDateAmb(string date)
        {
            date = dateAmb;
        }
        public void setRegion(string reg)
        {
            reg = region;
        }
        public void setEmail(string em)
        {
            em = email;
        }
        public void setPoste(string post)
        {
            post = poste;
        }
        public void setIdentifiant(string ident)
        {
            ident = identifiant;
        }
        public void setMot_Passe(string mot)
        {
            mot = mot_passe;
        }
    }
}
