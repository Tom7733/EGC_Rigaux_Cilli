using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Couche_Modele.Modele
{
    public class Dbal
    {
        private string server;
        private string database;
        private string uid;
        private string pass;
        private String ConnectionString;
        private MySqlConnection Connect;

        public Dbal(string server, string database, string uid, string pass)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.pass = pass;
            ConnectionString = "SERVER = " + this.server + ";" + "DATABASE = " + this.database + ";" + "UID = " + this.uid + ";" + "PASSWORD = " + this.pass + ";";
            this.Connect = new MySqlConnection(ConnectionString);
        }
        //public Dbal(string serveur,string db,string userid,string passw)
        //{
        //    ConnectionString = "SERVER = " + serveur + ";" + "DATABASE = " + db + ";" + "UID = " + userid + ";" + "PASSWORD = " + passw + ";";
        //    this.Connect = new MySqlConnection(ConnectionString);
        //}

        public void openConnexion()
        {
            try
            {
                this.Connect.Open();
            }
            catch (MySqlException ex1)
            {
                Console.WriteLine(ex1.Message);
            }

        }

        public void closeConnexion()
        {
            try
            {
                this.Connect.Close();
            }
            catch (MySqlException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
        }

        public void excRequete(string query)
        {
            openConnexion();
            MySqlCommand cmd = new MySqlCommand(query, this.Connect);
            cmd.ExecuteNonQuery();
            closeConnexion();
        }
        public void Insert(string valeur)
        {
            string req = "Insert Into " + valeur;
            excRequete(req);
        }

        public void Delete(string condition)
        {
            string req = "Delete From " + condition;
            excRequete(req);
        }

        public void Uptade(string champs_condition)
        {
            string req = "Update " + champs_condition;
            excRequete(req);
        }

        public DataTable Select(string choix)
        {
            DataSet p = new DataSet();
            string req = "Select " + choix;
            openConnexion();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(req, Connect);
            adapter.Fill(p);
            DataTable table = p.Tables[0];
            closeConnexion();
            return table;
        }

        public DataTable SelectAll(string tables)
        {
            DataSet p = new DataSet();
            string req = "Select * From " + tables + ";";
            openConnexion();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(req, Connect);
            adapter.Fill(p);
            DataTable table = p.Tables[0];
            closeConnexion();
            return table;
        }
    }
}
