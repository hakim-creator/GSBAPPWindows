using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB
{
    class BD
    {
        public static void AjoutTech(Techniciens unTechnicien )
        {
            string Tech = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Respconn = new MySqlConnection(Tech);

            Respconn.Open();



            MySqlCommand technicien = Respconn.CreateCommand();
            technicien.CommandText = "INSERT INTO salarie(nom, Prenom, Matricule, dateAmb, Region, email, poste, identifiant, Mot_Passe) VALUES (@nom, @prenom, @Matricule, @dateAmb, @Region, @email, @poste, @identifiant, @Mot_Passe )";
            technicien.Parameters.AddWithValue("@nom", unTechnicien.getNom());
            technicien.Parameters.AddWithValue("@prenom", unTechnicien.getPrenom());
            technicien.Parameters.AddWithValue("@Matricule", unTechnicien.getMatricule());
            technicien.Parameters.AddWithValue("@dateAmb", unTechnicien.getDateAmb());
            technicien.Parameters.AddWithValue("@Region", unTechnicien.getRegion());
            technicien.Parameters.AddWithValue("@email", unTechnicien.getEmail());
            technicien.Parameters.AddWithValue("@poste", unTechnicien.getPoste());
            technicien.Parameters.AddWithValue("@identifiant", unTechnicien.getIdentifiant());
            technicien.Parameters.AddWithValue("@Mot_Passe", unTechnicien.getMot_passe());



            technicien.ExecuteNonQuery();

            Respconn.Close();

            string Respons = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Responsconn = new MySqlConnection(Respons);

            Respconn.Open();

            technicien.CommandText = "INSERT INTO technicien(formation, NivIntervention, competence) VALUES (@formation, @NivIntervention, @competence )";
            technicien.Parameters.AddWithValue("@formation", unTechnicien.getFormation());
            technicien.Parameters.AddWithValue("@NivIntervention", unTechnicien.getNivIntervention());
            technicien.Parameters.AddWithValue("@competence", unTechnicien.getCompetence());

            technicien.ExecuteNonQuery();

            Responsconn.Close();
        }


        public static void AjoutUtil(Visiteur unUtilisateur )
        {

            string Util = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Respconn = new MySqlConnection(Util);

            Respconn.Open();



            MySqlCommand utilisateur = Respconn.CreateCommand();
            utilisateur.CommandText = "INSERT INTO salarie(nom, Prenom, Matricule, dateAmb, Region, email, poste, identifiant, Mot_Passe) VALUES (@nom, @prenom, @Matricule, @dateAmb, @Region, @email, @poste, @identifiant, @Mot_Passe )";
            utilisateur.Parameters.AddWithValue("@nom", unUtilisateur.getNom());
            utilisateur.Parameters.AddWithValue("@prenom", unUtilisateur.getPrenom());
            utilisateur.Parameters.AddWithValue("@Matricule", unUtilisateur.getMatricule());
            utilisateur.Parameters.AddWithValue("@dateAmb", unUtilisateur.getDateAmb());
            utilisateur.Parameters.AddWithValue("@Region", unUtilisateur.getRegion());
            utilisateur.Parameters.AddWithValue("@email", unUtilisateur.getEmail());
            utilisateur.Parameters.AddWithValue("@poste", unUtilisateur.getPoste());
            utilisateur.Parameters.AddWithValue("@identifiant", unUtilisateur.getIdentifiant());
            utilisateur.Parameters.AddWithValue("@Mot_Passe", unUtilisateur.getMot_passe());



            utilisateur.ExecuteNonQuery();

            Respconn.Close();

            


        }

   

        public static void AjoutResp(Responsables unResponsable)
        {

            string Resp = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Respconn = new MySqlConnection(Resp);

            Respconn.Open();



            MySqlCommand responsable = Respconn.CreateCommand();
            responsable.CommandText = "INSERT INTO salarie(nom, Prenom, Matricule, dateAmb, Region, email, poste, identifiant, Mot_Passe) VALUES (@nom, @prenom, @Matricule, @dateAmb, @Region, @email, @poste, @identifiant, @Mot_Passe )";
            responsable.Parameters.AddWithValue("@nom", unResponsable.getNom());
            responsable.Parameters.AddWithValue("@prenom", unResponsable.getPrenom());
            responsable.Parameters.AddWithValue("@Matricule", unResponsable.getMatricule());
            responsable.Parameters.AddWithValue("@dateAmb", unResponsable.getDateAmb());
            responsable.Parameters.AddWithValue("@Region", unResponsable.getRegion());
            responsable.Parameters.AddWithValue("@email", unResponsable.getEmail());
            responsable.Parameters.AddWithValue("@poste", unResponsable.getPoste());
            responsable.Parameters.AddWithValue("@identifiant", unResponsable.getIdentifiant());
            responsable.Parameters.AddWithValue("@Mot_Passe", unResponsable.getMot_passe());

            

            responsable.ExecuteNonQuery();

            Respconn.Close();



        }

        public static void AjoutMateriel(Materiel unMateriel)
        {

            string Mater = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Matconn = new MySqlConnection(Mater);

            Matconn.Open();



            MySqlCommand materiel = Matconn.CreateCommand();
            materiel.CommandText = "INSERT INTO materiel(typeMateriel, dateAchat, garantie, fourni, louer) VALUES (@typeMateriel, @dateAchat, @garantie, @fourni, @louer )";
            materiel.Parameters.AddWithValue("@typeMateriel", unMateriel.getTypeMateriel());
            materiel.Parameters.AddWithValue("@dateAchat", unMateriel.getDateAchat());
            materiel.Parameters.AddWithValue("@garantie", unMateriel.getGarantie());
            materiel.Parameters.AddWithValue("@fourni", unMateriel.getFournisseur());
            materiel.Parameters.AddWithValue("@louer", unMateriel.getLouer());
            



            materiel.ExecuteNonQuery();

            Matconn.Close();



        }

        public static void SupMateriel(int unIdMateriel)
        {

            string Mater = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Matconn = new MySqlConnection(Mater);

            Matconn.Open();



            MySqlCommand materiel = Matconn.CreateCommand();
            materiel.CommandText = "DELETE FROM materiel WHERE Id_Materiel= @id ";
          
            materiel.Parameters.AddWithValue("@id", unIdMateriel);




            materiel.ExecuteNonQuery();

            Matconn.Close();



        }

        public static void PriseCharge(Probleme uneCharge)
        {

            string Char = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Charconn = new MySqlConnection(Char);

            Charconn.Open();



            MySqlCommand charge = Charconn.CreateCommand();
            charge.CommandText = "INSERT INTO probleme( priseCharge, etats, Message) VALUES (  @priseCharge,  @etats, @Message )";
            charge.Parameters.AddWithValue("@priseCharge", uneCharge.getPriseCharge());
            
            charge.Parameters.AddWithValue("@etats", uneCharge.getEtats());
            charge.Parameters.AddWithValue("@Message", uneCharge.getMessage());






            charge.ExecuteNonQuery();

            Charconn.Close();



        }

        public static void Traitement(Traitement unTraitement)
        {

            string Trait = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Traitconn = new MySqlConnection(Trait);

            Traitconn.Open();



            MySqlCommand traitement = Traitconn.CreateCommand();
            traitement.CommandText = "INSERT INTO traitement(dateTrait, heureDebut, heureFin, travRealis) VALUES ( @dateTrait, @heureDebut, @heureFin, @travRealis )";
            traitement.Parameters.AddWithValue("@dateTrait", unTraitement.getDateTraitement());
            traitement.Parameters.AddWithValue("@heureDebut", unTraitement.getHeureDebut());
            traitement.Parameters.AddWithValue("@heureFin", unTraitement.getHeureFin());
            traitement.Parameters.AddWithValue("@travRealis", unTraitement.getTravRealis());





            traitement.ExecuteNonQuery();

            Traitconn.Close();

            

        }

        

        public static void DeclarIncid(Probleme uneDeclaration)
        {

            string Decl = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Decconn = new MySqlConnection(Decl);

            Decconn.Open();



            MySqlCommand declaration = Decconn.CreateCommand();
            declaration.CommandText = "INSERT INTO probleme(objet, NivUrgence, dateIncid, zoneInter) VALUES (@objet, @NivUrgence, @dateIncid, @zoneInter )";
            declaration.Parameters.AddWithValue("@objet", uneDeclaration.getObjet());
            declaration.Parameters.AddWithValue("@nivUrgence", uneDeclaration.getNivUrgence());
            declaration.Parameters.AddWithValue("@dateIncid", uneDeclaration.getDateIncid());
            declaration.Parameters.AddWithValue("@zoneInter", uneDeclaration.getZoneInterv());





            declaration.ExecuteNonQuery();

            Decconn.Close();



        }

        

        /*
        public static  AffichSalarie()
        {

            List<Salarie> lesSalaries
            lesSalaries = new List<Salarie>();

            string Decl = "Server = 127.0.0.1; Database = gsb; Uid = root; Passeword =;SslMode = none;";
            MySqlConnection Decconn = new MySqlConnection(Decl);

            Decconn.Open();



            MySqlCommand declaration = Decconn.CreateCommand();
            declaration.CommandText = "SELECT nom = nom, Prenom, Matricule, dateAmb, Region, email, poste, identifiant, Mot_Passe FORM salarie";
            MySqlDataReader dataReader = declaration.ExecuteReader();
            while (dataReader.Read())
            {
                Salarie unSalarie = new Salarie(dataReader["nom"], dataReader[Prenom], dataReader[Matricule], dataReader[dateAmb], dataReader[Region], dataReader[email], dataReader[poste], dataReader[ientifiant], dataReader[Mot_Passe]);
                lesSalaries.Add(unSalarie);
            }





            declaration.ExecuteNonQuery();

            Decconn.Close();

            return lesSalaries ;

        }*/


    }
}

        
  
