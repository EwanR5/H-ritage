using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{
    internal class Animal
    {
        protected string _nom;
        protected DateTime _date;
        protected int _numPuce;
        protected int _taille;
        protected bool _concours; 

        public Animal(string nom, DateTime date, int numPuce, int taille, bool concours) 
        {
            _nom = nom;
            _date = date;
            _numPuce = numPuce;
            _taille = taille;
            _concours = concours;
        }

        public string Dormir()
        {
            string chaine = _nom + " commence à s'endormir";
            return chaine;
        }
        public string Mange()
        {
            string chaine = _nom + " va se nourrir";
            return chaine;
        }

        public virtual string AfficherCaracteristique()
        {
            string chaine = " nom : " + _nom + " \n date de naissance : " + _date + " \n numéro de puce : " + _numPuce + " \n taille : " + _taille + "cm \n fait des coucours : " + _concours;
            return chaine;
        }
    }
}
