using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public Voiture(string modele, string marque, string couleur, decimal prix, string motorisation, bool gps) : base(modele, marque, couleur, prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
            _motorisation = motorisation;
            _gps = gps;
        }
        public string AfficherVoiture()
        {
            string chaine = " modele : " + _modele + " \n marque : " + _marque + " \n couleur : " + _couleur + " \n prix : " + _prix + " \n motorisation : " + _motorisation + " \n gps : " + _gps;
            return chaine;
        }
    }
}
