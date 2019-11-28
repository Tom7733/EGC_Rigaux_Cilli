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
        protected int _nbjoueur;
        protected DTOClients _client;
        protected DTOSalle _salle;
        #endregion

        #region Constructeurs
        public DTOParties(int id, DateTime dateHeure, int nbjoueur, DTOClients client, DTOSalle salle)
        {
            _id = id;
            _dateHeure = dateHeure;
            _nbjoueur = nbjoueur;
            _client = client;
            _salle = salle;
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

        public int GetNbJoueur()
        {
            return _nbjoueur;
        }

        public DTOClients GetClient()
        {
            return _client;
        }

        public DTOSalle GetSalle()
        {
            return _salle;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
