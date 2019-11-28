using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOTheme
    {
        #region Attributs
        protected int _id;
        protected string _nom;
        #endregion

        #region Constructeurs
        public DTOTheme(int id, string nom)
        {
            _id = id;
            _nom = nom;
        }
        #endregion

        #region Accesseurs
        public int GetId()
        {
            return _id;
        }

        public string GetNom()
        {
            return _nom;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
