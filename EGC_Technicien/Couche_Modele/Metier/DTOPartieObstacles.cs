using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOPartieObstacles
    {
        #region Attributs
        protected DTOParties _partie;
        protected DTOObstacles _obstacle;
        protected Int16 _position;
        protected int _qte;
        protected int _prix;
        #endregion

        #region Constructeurs
        public DTOPartieObstacles(DTOParties partie, DTOObstacles obstacle, Int16 position, int qte, int prix)
        {
            _partie = partie;
            _obstacle = obstacle;
            _position = position;
            _qte = qte;
            _prix = prix;
        }
        #endregion

        #region Accesseurs
        public DTOParties GetPartie()
        {
            return _partie;
        }

        public DTOObstacles GetObstacle()
        {
            return _obstacle;
        }

        public Int16 GetPosition()
        {
            return _position;
        }

        public int GetQte()
        {
            return _qte;
        }

        public int GetPrix()
        {
            return _prix;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
