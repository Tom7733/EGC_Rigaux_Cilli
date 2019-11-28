using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOClients
    {
        #region Attributs
        protected string _pseudo;
        protected string _nom;
        protected string _prenom;
        protected DateTime _datenaissance;
        protected string _adresse;
        protected DTOVille _ville;
        protected string _mail;
        protected string _telephone;
        protected bool _archiver;
        #endregion

        #region Constructeurs
        public DTOClients(string pseudo, string nom, string prenom, DateTime datenaissance, string adresse, DTOVille ville, string mail, string telephone, bool archiver)
        {
            _pseudo = pseudo;
            _nom = nom;
            _prenom = prenom;
            _datenaissance = datenaissance;
            _adresse = adresse;
            _ville = ville;
            _mail = mail;
            _telephone = telephone;
            _archiver = archiver;
        }
        #endregion

        #region Accesseurs
        public string GetPseudo()
        {
            return _pseudo;
        }
        public string GetNom()
        {
            return _nom;
        }
        public string GetPrenom()
        {
            return _prenom;
        }
        public DateTime GetDateNaissance()
        {
            return _datenaissance;
        }
        public string GetAdresse()
        {
            return _adresse;
        }
        public DTOVille GetVille()
        {
            return _ville;
        }
        public string GetMail()
        {
            return _mail;
        }
        public string GetTelephone()
        {
            return _telephone;
        }
        public bool GetArchiver()
        {
            return _archiver;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
