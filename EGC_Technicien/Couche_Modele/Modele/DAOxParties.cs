using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Couche_Modele.Modele;
using Couche_Modele.Metier;
using System.IO;

namespace Couche_Modele.Modele
{
    public class DAOxParties
    {
        protected Dbal _dbal;

        public DAOxParties(Dbal dbal)
        {
            _dbal = dbal;
        }

        public List<DTOParties> SelectAllPartie()
        {
            DataTable table = _dbal.SelectAll("Parties");
            List<DTOParties> listpartie = new List<DTOParties>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DAOxClients dAOxClients = new DAOxClients(_dbal);
                DTOClients client = dAOxClients.SelectByIdClients(Convert.ToString(table.Rows[i]["pseudo_client"]));

                DAOxSalle dAOxSalle = new DAOxSalle(_dbal);
                DTOSalle salle = dAOxSalle.SelectByIdSalle(Convert.ToInt32(table.Rows[i]["idSalle"]));

                DataRow row = table.Rows[0];
                DTOParties partie = new DTOParties(Convert.ToInt32(table.Rows[i]["id"]), Convert.ToDateTime(table.Rows[i]["date"]), Convert.ToString(table.Rows[i]["heure"]), Convert.ToInt32(table.Rows[i]["nbjoueur"]), client, salle);
                listpartie.Add(partie);
            }
            return listpartie;
        }

        public DTOParties SelectByIdPartie(int id)
        {
            string retour = " * from parties where id = " + id + ";";
            DataTable table = _dbal.Select(retour);
            DTOParties partie = new DTOParties(Convert.ToInt32(table.Rows[0]["id"]), Convert.ToDateTime(table.Rows[0]["date"]), Convert.ToString(table.Rows[0]["heure"]), Convert.ToInt32(table.Rows[0]["nbjoueur"]));

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DAOxClients dAOxClients = new DAOxClients(_dbal);
                DTOClients clients = dAOxClients.SelectByIdClients(Convert.ToString(table.Rows[i]["pseudo_client"]));

                DAOxSalle dAOxSalle = new DAOxSalle(_dbal);
                DTOSalle salle = dAOxSalle.SelectByIdSalle(Convert.ToInt32(table.Rows[i]["idSalle"]));

                partie.SetClient(clients);
                partie.SetSalle(salle);
            }
            return partie;
        }

        public DTOParties SelectByDate(DateTime date)
        {
            string retour = " * from parties where date = " + date + ";";
            DataTable table = _dbal.Select(retour);
            DTOParties partie = new DTOParties(Convert.ToInt32(table.Rows[0]["id"]), Convert.ToDateTime(table.Rows[0]["date"]), Convert.ToString(table.Rows[0]["heure"]), Convert.ToInt32(table.Rows[0]["nbjoueur"]));

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DAOxClients dAOxClients = new DAOxClients(_dbal);
                DTOClients clients = dAOxClients.SelectByIdClients(Convert.ToString(table.Rows[i]["pseudo_client"]));

                DAOxSalle dAOxSalle = new DAOxSalle(_dbal);
                DTOSalle salle = dAOxSalle.SelectByIdSalle(Convert.ToInt32(table.Rows[i]["idSalle"]));

                partie.SetClient(clients);
                partie.SetSalle(salle);
            }
            return partie;
        }
    }
}
