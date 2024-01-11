namespace Animaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien chien1 = new Chien("Cerbère", "1 Janvier 2000", 12, 25, false);
            Chat chat1 = new Chat("Bidule", "23 avril 2005", 23, 20, true);
            Lapin lapin1 = new Lapin("Moumou", "Je ne sais pas", 15, 24, true, 4);


            Console.WriteLine(chien1.AfficherCaractéristique);
            Console.WriteLine(chat1.AfficherCaractéristique);
            Console.WriteLine(lapin1.AfficherCaractéristiqueL);
            Console.ReadLine();
        }
    }
}