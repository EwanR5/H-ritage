using Vehicules;

internal class Program
{
    private static void Main(string[] args)
    {
        Voiture voiture1 = new Voiture("modele", "marque", "noir", 100, "moteur", true);
        Velo velo1 = new Velo("modele", "marque", "bleu", 10, "type", true);

        Console.WriteLine("Le vélo \n" + velo1.AfficherVelo());
        Console.WriteLine("----------------------");
        Console.WriteLine("La voiture \n" + voiture1.AfficherVoiture());
        Console.ReadLine();
    }
}