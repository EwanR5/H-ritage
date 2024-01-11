using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{
    internal class Chat : Animal
    {
        public Chat(string nom, string date, int numPuce, int taille, bool concours) : base(nom, date, numPuce, taille, concours)
        {
            _nom = nom;
            _date = date;
            _numPuce = numPuce;
            _taille = taille;
            _concours = concours;
        }

        public string Miauler()
        {
            string chaine = _nom + " miaule UwU";
            return chaine;
        }

        public string Ronronner()
        {
            string chaine = _nom + " se met à ronronner";
            return chaine;
        }
    }
}
