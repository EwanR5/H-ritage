using System;

namespace Formes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme[] formes = new Forme[4];

            formes[0] = new Carre("Bleu", 4, 4, 4, 4);
            formes[1] = new Rectangle("Rouge", 5, 6, 5, 6);
            formes[2] = new Rectangle("Mauve", 1, 1, 3, 3);
            formes[3] = new Carre("Noir", 3, 3, 3, 3);


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(formes[i].CalculeSurface());
                Console.WriteLine(formes[i].CalculePerimetre());

                if (formes[i] is Carre carre)
                {
                    Console.WriteLine(carre.AfficherCouleur());
                }
                else if (formes[i] is Rectangle rectangle)
                {
                    Console.WriteLine(rectangle.AfficherCouleur());
                }

                Console.WriteLine("-----------------");
            }
        }
    }
}