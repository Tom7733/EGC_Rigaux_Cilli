﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Couche_Modele.Metier
{
    public class DTOOperateur
    {
        #region Attributs
        protected int _id;
        protected string _nom;
        protected DTOFonction _fontion;
        protected DTOVille _ville;
        #endregion

        #region Constructeurs
        public DTOOperateur(int id, string nom, DTOFonction fonction,DTOVille ville)
        {
            _id = id;
            _nom = nom;
            _ville = ville;
            _fontion = fonction;
        }
        #endregion

        #region Accesseurs
        public int GetId()
        {
            return _id;
        }

        public string GetNom()
        {
            return _nom;
        }

        public DTOFonction GetFonction()
        {
            return _fontion;
        }

        public DTOVille GetVille()
        {
            return _ville;
        }
        #endregion

        #region Autres méthodes

        #endregion
    }
}
