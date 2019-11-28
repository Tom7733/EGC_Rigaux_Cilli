using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOSalle
    {
        #region Attributs
        protected int _id;
        protected string _nom;
        protected DTOTheme _theme;
        protected DTOVille _ville;
        protected string _heure_ouverture;
        protected string _heure_fermeture;
        #endregion

        #region Constructeurs
        public DTOSalle(int id, string nom, DTOTheme theme, DTOVille ville, string heure_ouverture, string heure_fermeture)
        {
            _id = id;
            _nom = nom;
            _theme = theme;
            _ville = ville;
            _heure_ouverture = heure_ouverture;
            _heure_fermeture = heure_fermeture;
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

        public DTOTheme GetTheme()
        {
            return _theme;
        }

        public DTOVille GetVille()
        {
            return _ville;
        }

        public string GetHeureOuverture()
        {
            return _heure_ouverture;
        }

        public string GetHeureFermeture()
        {
            return _heure_fermeture;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
