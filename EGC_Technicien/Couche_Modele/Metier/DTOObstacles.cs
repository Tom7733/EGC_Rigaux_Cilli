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
        protected decimal _prix;
        #endregion

        #region Constructeurs
        public DTOObstacles(int id, string nom, string type, string description, decimal prix)
        {
            _id = id;
            _nom = nom;
            _type = type;
            _description = description;
            _prix = prix;
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
        public decimal GetPrix()
        {
            return _prix;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
