using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _estElectrique;
        public Velo(string modele, string marque, string couleur, decimal prix, string type, bool estElectrique) : base(modele, marque, couleur, prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
            _type = type;
            _estElectrique = estElectrique;
        }
        public string AfficherVelo()
        {
            string chaine = " modele : " + _modele + " \n marque : " + _marque + " \n couleur : " + _couleur + " \n prix : " + _prix + " \n type : " + _type + " \n Electrique : " + _estElectrique;
            return chaine;
        }
    }
}
