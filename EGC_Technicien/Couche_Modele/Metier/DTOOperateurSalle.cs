using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOOperateurSalle
    {
        #region Attributs
        protected DTOOperateur _operateur;
        protected DTOVille _ville;
        #endregion

        #region Constructeurs
        public DTOOperateurSalle(DTOOperateur operateur, DTOVille ville)
        {
            _operateur = operateur;
            _ville = ville;
        }
        #endregion

        #region Accesseurs
        public DTOOperateur GetOperateur()
        {
            return _operateur;
        }

        public DTOVille GetVille()
        {
            return _ville;
        }
        #endregion

        #region Autres méthodes

        #endregion

    }
}
