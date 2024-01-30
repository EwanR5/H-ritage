using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    internal class Rectangle : Forme
    {
        private double _cote1;
        private double _cote2;

        public Rectangle(string couleur, double cote1, double cote2) : base(couleur)
        {
            _cote1 = cote1;
            _cote2 = cote2;
        }
        public override double CalculePerimetre()
        {
            double perimetre = _cote1 * 2 + _cote2 * 2;
            return perimetre;
        }
        public override double CalculeSurface()
        {
            double aire = _cote1 * _cote2;
            return aire;
        }

        public string AfficherCouleur()
        {
            string phrase = "Le rectangle est de couleur " + _couleur;
            return phrase;
        }
    }
}
