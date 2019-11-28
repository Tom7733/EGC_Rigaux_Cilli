using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Couche_Modele.Modele;
using Couche_Modele.Metier;
using System.IO;

namespace Couche_Modele.Modele
{
    public class DAOxOperateur
    {
        protected Dbal _dbal;

        public DAOxOperateur(Dbal dbal)
        {
            _dbal = dbal;
        }
    }
}
