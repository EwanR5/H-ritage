using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    internal class Rectangle : Forme
    {
        public Rectangle(string couleur, int cote1, int cote2, int cote3, int cote4) : base(couleur, cote1, cote2, cote3, cote4)
        {
            _couleur = couleur;
            _cote1 = cote1;
            _cote2 = cote2;
            _cote3 = cote3;
            _cote4 = cote4;
        }


        public string AfficherCouleur()
        {
            string phrase = "Le rectangle est de couleur " + _couleur;
            return phrase;
        }
    }
}
