namespace Animaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animaux = new Animal[3];

            animaux[0] = new Chien("Cerbère", DateTime.Parse("01/01/2000"), 12, 25, false);
            animaux[1]= new Chat("Bidule", DateTime.Parse("23/04/2015"), 23, 20, true);
            animaux[2] = new Lapin("Lapin", DateTime.Parse("01/01/2000"), 15, 24, true, 4);


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(animaux[i].AfficherCaracteristique());
                Console.WriteLine(animaux[i].Dormir());

                if (animaux[i] is Chat chat)
                {
                    Console.WriteLine(chat.Miauler());
                }
                else if (animaux[i] is Chien chien)
                {
                    Console.WriteLine(chien.Aboyer());
                } 
                else if (animaux[i] is  Lapin lapin)
                {
                    Console.WriteLine(lapin.Bondir());
                }

                Console.WriteLine("-----------------");
            }
        }
    }
}