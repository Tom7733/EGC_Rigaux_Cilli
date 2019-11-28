﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using EGC_Technicien;
using Couche_Modele.Modele;
using Couche_Modele.Metier;

namespace EGC_Technicien.Databinding
{
    public class VueModele : INotifyPropertyChanged
    {
        protected Dbal _bdd;
        protected DAOxClients _clients;
        protected DAOxObstacles _obstacles;
        protected DAOxPartieObstacles _partieObstacles;
        protected DAOxParties _parties;
        protected DAOxSalle _salle;
        protected DAOxTheme _theme;
        protected DAOxTransactions _transactions;
        protected DAOxVille _ville;
        private ICommand updatecommande;

        protected List<DTOSalle> list_salle;

        public VueModele(Dbal dbal, DAOxClients dAOxClients, DAOxObstacles dAOxObstacles, DAOxPartieObstacles dAOxPartieObstacles, DAOxParties dAOxParties, DAOxSalle dAOxSalle, DAOxTheme dAOxTheme, DAOxTransactions dAOxTransactions, DAOxVille dAOxVille)
        {
            _bdd = dbal;
            _clients = dAOxClients;
            _obstacles = dAOxObstacles;
            _partieObstacles = dAOxPartieObstacles;
            _parties = dAOxParties;
            _salle = dAOxSalle;
            _theme = dAOxTheme;
            _transactions = dAOxTransactions;
            _ville = dAOxVille;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string caller = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}