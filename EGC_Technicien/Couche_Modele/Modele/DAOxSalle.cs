using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Couche_Modele.Modele;
using Couche_Modele.Metier;
using System.IO;

namespace Couche_Modele.Modele
{
    public class DAOxSalle
    {
        protected Dbal _dbal;

        public DAOxSalle(Dbal dbal)
        {
            _dbal = dbal;
        }

        public List<DTOSalle> SelectAllSalle()
        {
            DataTable table = _dbal.SelectAll("Salle");
            List<DTOSalle> listSalles = new List<DTOSalle>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DAOxTheme dAOxTheme = new DAOxTheme(_dbal);
                DTOTheme theme = dAOxTheme.SelectByIdTheme(Convert.ToInt32(table.Rows[i][0]));
                DAOxVille dAOxVille = new DAOxVille(_dbal);
                DTOVille ville = dAOxVille.SelectByIdVille(Convert.ToInt32(table.Rows[i][0]));
                DataRow row = table.Rows[0];
                DTOSalle salle = new DTOSalle(Convert.ToInt32(table.Rows[i]["id"]), Convert.ToString(table.Rows[i]["nom"]), theme, ville, Convert.ToString(table.Rows[i]["heure_ouverture"]), Convert.ToString(table.Rows[i]["heure_fermeture"]));
                listSalles.Add(salle);
            }
            return listSalles;
        }
        
        /**public DTOSalle SelectByIdSalle(int id)
        {
            string retour = " * from salle where id = " + id + ";";
            DataTable table = _dbal.Select(retour);
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DAOxTheme dAOxTheme = new DAOxTheme(_dbal);
                DTOTheme theme = dAOxTheme.SelectByIdTheme(Convert.ToInt32(table.Rows[i][3]));

                DAOxVille dAOxVille = new DAOxVille(_dbal);
                DTOVille ville = dAOxVille.SelectByIdVille(Convert.ToInt32(table.Rows[i][4]));

                DTOSalle salle = new DTOSalle(Convert.ToInt32(table.Rows[i]["id"]), Convert.ToString(table.Rows[i]["nom"]), theme, ville, Convert.ToDateTime(table.Rows[i]["heure_ouverture"]), Convert.ToDateTime(table.Rows[i]["heure_fermeture"]));
            }
            return salle;
        }**/
    }
}
