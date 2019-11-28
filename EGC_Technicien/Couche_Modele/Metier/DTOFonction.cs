using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOFonction
    {
        #region Attributs
        protected string _categorie;
        protected string _nom;
        #endregion

        #region Constructeurs
        public DTOFonction(string categorie, string nom)
        {
            _categorie = categorie;
            _nom = nom;
        }
        #endregion

        #region Accesseurs
        public string GetCategorie()
        {
            return _categorie;
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
