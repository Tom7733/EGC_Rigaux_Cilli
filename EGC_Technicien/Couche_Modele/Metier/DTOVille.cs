using System;
using System.Collections.Generic;
using System.Text;


namespace Couche_Modele.Metier
{
    public class DTOVille
    {
        #region Attributs
        protected int _id;
        protected string _nom;
        protected string _cp;
        #endregion

        #region Constructeurs
        public DTOVille(int id, string nom, string cp)
        {
            _id = id;
            _nom = nom;
            _cp = cp;
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

        public string GetCp()
        {
            return _cp;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
