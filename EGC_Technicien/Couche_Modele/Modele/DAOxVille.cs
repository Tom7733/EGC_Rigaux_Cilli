using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Couche_Modele.Modele;
using Couche_Modele.Metier;
using System.IO;

namespace Couche_Modele.Modele
{
    public class DAOxVille
    {
        protected Dbal _dbal;

        public DAOxVille(Dbal dbal)
        {
            _dbal = dbal;
        }

        public DTOVille SelectByIdVille(int id)
        {
            string retour = " * from ville where id = " + id + ";";
            DataTable table = _dbal.Select(retour);

            DTOVille ville = new DTOVille(Convert.ToInt32(table.Rows[0]["id"]), Convert.ToString(table.Rows[0]["nom"]), Convert.ToString(table.Rows[0]["codepostal"]));
            return ville;
        }
    }
}
