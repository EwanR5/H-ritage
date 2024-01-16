using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formes
{
    internal class Forme
    {
        protected string _couleur;
        protected int _cote1;
        protected int _cote2;
        protected int _cote3;
        protected int _cote4;

        public Forme(string couleur, int cote1, int cote2, int cote3, int cote4)
        {
            _couleur = couleur;
            _cote1 = cote1;
            _cote2 = cote2;
            _cote3 = cote3;
            _cote4 = cote4;
        }

        public int CalculeSurface()
        {
            int aire = 0;
            if (_cote1 != _cote2)
            {
                aire = _cote1 * _cote2;
            }
            else
            {
                aire = _cote1 * _cote3;
            }
                
            return aire;
        }
        public int CalculePerimetre() 
        {
            int perimetre = _cote1 + _cote2 + _cote3 + _cote4;
            return perimetre;
        }
    }
}
