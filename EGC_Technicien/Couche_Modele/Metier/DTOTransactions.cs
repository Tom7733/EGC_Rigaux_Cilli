using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOTransactions
    {
        #region Attributs
        protected int _id;
        protected char _typePaiement;
        protected decimal _creditTransaction;
        protected DateTime _date;
        protected string _reference;
        protected DTOClients _pseudo;
        protected DTOParties _partie;
        #endregion

        #region Constructeurs
        public DTOTransactions(int id, char typePaiement, decimal creditTransaction, DateTime date, string reference, DTOClients pseudo, DTOParties partie)
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

        public char GetTypePaiement()
        {
            return _typePaiement;
        }

        public decimal GetCreditTransaction()
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
