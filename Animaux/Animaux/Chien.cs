using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{
    internal class Chien : Animal
    {
        public Chien(string nom, DateTime date, int numPuce, int taille, bool concours) : base(nom, date, numPuce, taille, concours)
        {
            _nom = nom;
            _date = date;
            _numPuce = numPuce;
            _taille = taille;
            _concours = concours;
        }

        public string Aboyer()
        {
            string chaine = _nom + " aboie";
            return chaine;
        }
    }
}
