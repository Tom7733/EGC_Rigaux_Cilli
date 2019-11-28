using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Couche_Modele.Modele;
using Couche_Modele.Metier;
using System.IO;

namespace Couche_Modele.Modele
{
    public class DAOxTheme
    {
        protected Dbal _dbal;

        public DAOxTheme(Dbal dbal)
        {
            _dbal = dbal;
        }

        public DTOTheme SelectByIdTheme(int id)
        {
            string retour = " * from theme where id = " + id + ";";
            DataTable table = _dbal.Select(retour);

            DTOTheme theme = new DTOTheme(Convert.ToInt32(table.Rows[0]["id"]), Convert.ToString(table.Rows[0]["nom"]));
            return theme;
        }
    }
}
