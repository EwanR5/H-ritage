using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    internal class Carre : Forme
    {
        private double _cote;
        public Carre(string couleur, double cote) : base(couleur)
        {
            _cote = cote;
        }

        public override double CalculePerimetre()
        {
            double perimetre = _cote * 4;
            return perimetre;
        }
        public override double CalculeSurface()
        {
            double aire = _cote * _cote;
            return aire;
        }
        public string AfficherCouleur()
        {
            string phrase = "Le carré est de couleur " + _couleur;
            return phrase;
        }
    }
}
