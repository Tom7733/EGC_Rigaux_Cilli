using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Couche_Modele.Modele;
using Couche_Modele.Metier;
using System.IO;

namespace Couche_Modele.Modele
{
    public class DAOxObstacles
    {
        protected Dbal _dbal;

        public DAOxObstacles(Dbal dbal)
        {
            _dbal = dbal;
        }
    }
}
