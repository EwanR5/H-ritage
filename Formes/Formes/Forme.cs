using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    internal abstract class Forme
    {
        protected string _couleur;

        public Forme(string couleur)
        {
            _couleur = couleur;
        }

        public abstract double CalculeSurface();
        public abstract double CalculePerimetre();
    }
}
