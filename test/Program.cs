using System;

namespace Test
{

    class Program
    {
        static int vie = 3;
        static int or = 10;

        static void Main(string[] args)
        {
            ShowTitle();
            ShowRules();

            Console.WriteLine("Vous êtes dans une forêt. Aller à l'est ou à l'ouest ?");
            string dir = Console.ReadLine();

            Choix1(dir);

            dir = Console.ReadLine();

            Choix2(dir);

            dir = Console.ReadLine();

            Choix3(dir);
        }

        static void ShowTitle()
        {
            Console.WriteLine("         ______                                   __                                   ");
            Console.WriteLine("       /      \\                                 |  \\                                  ");
            Console.WriteLine("      |  $$$$$$\\ __     __   ______   _______  _| $$_    __    __   ______    ______  ");
            Console.WriteLine("      | $$__| $$|  \\   /  \\ /      \\ |       \\|   $$ \\  |  \\  |  \\ /      \\  /      \\ ");
            Console.WriteLine("      | $$    $$ \\$$\\ /  $$|  $$$$$$\\| $$$$$$$\\\\$$$$$$  | $$  | $$|  $$$$$$\\|  $$$$$$\\");
            Console.WriteLine("      | $$$$$$$$  \\$$\\  $$ | $$    $$| $$  | $$ | $$ __ | $$  | $$| $$   \\$$| $$    $$");
            Console.WriteLine("      | $$  | $$   \\$$ $$  | $$$$$$$$| $$  | $$ | $$|  \\| $$__/ $$| $$      | $$$$$$$$");
            Console.WriteLine("      | $$  | $$    \\$$$    \\$$     \\| $$  | $$  \\$$  $$ \\$$    $$| $$       \\$$     \\");
            Console.WriteLine("      \\$$   \\$$     \\$      \\$$$$$$$ \\$$   \\$$   \\$$$$   \\$$$$$$  \\$$        \\$$$$$$$");
        }

        static void ShowRules()
        {
            Console.WriteLine("Instructions du jeu :");
            Console.WriteLine("1. Vous commencez dans une forêt et devez choisir une direction (est ou ouest).");
            Console.WriteLine("2. Devant le château, choisissez d'entrer par la porte ou la fenêtre.");
            Console.WriteLine("3. Dans le couloir, choisissez la porte de gauche ou de droite.");
            Console.WriteLine("Bonne chance !");
        }

        static void Choix1(string dir)
        {
            while (dir != "est" && dir != "ouest")
            {
                Console.WriteLine("Entrez une destination correcte !");
                dir = Console.ReadLine();
            }

            if (dir == "est")
            {
                Console.WriteLine("Vous tombez d'une falaise. PERDU !");
                Environment.Exit(0);
            }
            else if (dir == "ouest")
            {
                Console.WriteLine("Vous allez à l'ouest. Vous trouvez un château. Entrer par la porte ou par la fenêtre ?");
            }
        }

        static void Choix2(string dir)
        {
            while (dir != "porte" && dir != "fenêtre")
            {
                Console.WriteLine("Entrez une option correcte (porte ou fenêtre) !");
                dir = Console.ReadLine();
            }

            if (dir == "porte")
            {
                Console.WriteLine("Le garde vous a vu. PERDU !");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Vous entrez dans le château. Vous êtes dans le couloir. Ouvrir la porte de gauche ou de droite ?");
            }
        }

        static void Choix3(string dir)
        {
            while (dir != "gauche" && dir != "droite")
            {
                Console.WriteLine("Entrez une option correcte (gauche ou droite) !");
                dir = Console.ReadLine();
            }

            if (dir == "gauche")
            {
                Console.WriteLine("Le garde vous a vu. PERDU !");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Vous trouvez la princesse, bravo !");
            }
        }

        static void ShowInfos()
        {
            Console.WriteLine("Vie = " + vie + " - Or = " + or);
        }
    }
}
