using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOTransactions
    {
        #region Attributs
        protected int _id;
        protected string _typePaiement;
        protected int _creditTransaction;
        protected DateTime _date;
        protected string _reference;
        protected DTOClients _pseudo;
        protected DTOParties _partie;
        #endregion

        #region Constructeurs
        public DTOTransactions(int id, string typePaiement, int creditTransaction, DateTime date, string reference, DTOClients pseudo, DTOParties partie)
        {
            _id = id;
            _typePaiement = typePaiement;
            _creditTransaction = creditTransaction;
            _date = date;
            _reference = reference;
            _pseudo = pseudo;
            _partie = partie;
        }
        #endregion

        #region Accesseurs
        public int GetId()
        {
            return _id;
        }

        public string GetTypePaiement()
        {
            return _typePaiement;
        }

        public int GetCreditTransaction()
        {
            return _creditTransaction;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetReference()
        {
            return _reference;
        }

        public DTOClients GetPseudo()
        {
            return _pseudo;
        }

        public DTOParties GetPartie()
        {
            return _partie;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
