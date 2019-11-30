using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOParties
    {
        #region Attributs
        protected int _id;
        protected DateTime _dateHeure;
        protected string _heure;
        protected int _nbjoueur;
        protected DTOClients _client;
        protected DTOSalle _salle;
        #endregion

        #region Constructeurs
        public DTOParties(int id, DateTime dateHeure, string heure, int nbjoueur, DTOClients client, DTOSalle salle)
        {
            _id = id;
            _dateHeure = dateHeure;
            _heure = heure;
            _nbjoueur = nbjoueur;
            _client = client;
            _salle = salle;
        }

        public DTOParties(int id, DateTime dateHeure, string heure, int nbjoueur)
        {
            _id = id;
            _dateHeure = dateHeure;
            _heure = heure;
            _nbjoueur = nbjoueur;
        }
        #endregion

        #region Accesseurs
        public int GetId()
        {
            return _id;
        }

        public DateTime GetDateHeure()
        {
            return _dateHeure;
        }

        public string GetHeure()
        {
            return _heure;
        }

        public int GetNbJoueur()
        {
            return _nbjoueur;
        }

        public DTOClients GetClient()
        {
            return _client;
        }

        public void SetClient(DTOClients dTOClients)
        {
            _client = dTOClients;
        }
        
        public DTOSalle GetSalle()
        {
            return _salle;
        }

        public void SetSalle(DTOSalle dTOSalle)
        {
            _salle = dTOSalle;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
