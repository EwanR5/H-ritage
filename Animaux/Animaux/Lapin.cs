using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{
    internal class Lapin : Animal
    {
        private int _oreille;
        public Lapin(string nom, string date, int numPuce, int taille, bool concours, int oreille) : base(nom, date, numPuce, taille, concours)
        {
            _nom = nom;
            _date = date;
            _numPuce = numPuce;
            _taille = taille;
            _concours = concours;
            _oreille = oreille;
        }

        public string TailleOreille()
        {
            string chaine = _nom + " possède des oreilles de " + _oreille + " cm";
            return chaine;
        }
        public string Bondir()
        {
            string chaine = _nom + " s'en va, en bondissant gaiement";
            return chaine;
        }
        public string AfficherCaractéristiqueL()
        {
            string chaine = " nom : " + _nom + " \n date de naissance : " + _date + " \n numéro de puce : " + _numPuce + " \n taille : " + _taille + "cm \n fait des coucours : " + _concours + "taille des oreilles : " + _oreille + "cm";
            return chaine;
        }
    }
}
