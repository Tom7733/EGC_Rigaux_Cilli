using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOObstacles
    {
        #region Attributs
        protected int _id;
        protected string _nom;
        protected string _type;
        protected string _description;
        #endregion

        #region Constructeurs
        public DTOObstacles(int id, string nom, string type, string description)
        {
            _id = id;
            _nom = nom;
            _type = type;
            _description = description;
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
        public string GetTYpe()
        {
            return _type;
        }
        public string GetDescription()
        {
            return _description;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
