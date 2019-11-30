using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Couche_Modele.Modele;
using Couche_Modele.Metier;
using System.IO;

namespace Couche_Modele.Modele
{
    public class DAOxClients
    {
        protected Dbal _dbal;

        public DAOxClients(Dbal dbal)
        {
            _dbal = dbal;
        }

        public DTOClients SelectByIdClients(string pseudo)
        {
            string retour = " * from clients where pseudo = \"" + pseudo + "\";";
            DataTable table = _dbal.Select(retour);
            DTOClients client = new DTOClients(Convert.ToString(table.Rows[0]["pseudo"]), Convert.ToString(table.Rows[0]["nom"]), Convert.ToString(table.Rows[0]["prenom"]), Convert.ToDateTime(table.Rows[0]["datenaissance"]), Convert.ToString(table.Rows[0]["adresse"]), Convert.ToString(table.Rows[0]["mail"]), Convert.ToString(table.Rows[0]["telephone"]), Convert.ToInt32(table.Rows[0]["credit"]), Convert.ToBoolean(table.Rows[0]["archiver"]));

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DAOxVille dAOxVille = new DAOxVille(_dbal);
                DTOVille ville = dAOxVille.SelectByIdVille(Convert.ToInt32(table.Rows[i]["idVille"]));

                client.SetVille(ville);
            }
            return client;
        }
    }
}
