using System;

namespace Raad_het_getal
{
    class Program
    {
        public static void JuisteAntwoord()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("Je hebt gelijk! Het juiste antwoord is {0}", teRadenGetal);
            Console.WriteLine("");
            Console.ReadKey();
        }


        public static void DrukOpEenToets()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.ReadKey();
        }

        public static int teRadenGetal = 0;

        static void Main(string[] args)
        {
            Console.Title = "Raad het spel";



            int ingevoerdGetal = 0;
            int aantalPogingen = 0;

            //Willekeurig getal maken
            Random willekeurig = new Random();
            teRadenGetal = willekeurig.Next(1, 100);

            Console.WriteLine("Raad het getal spel 1.0");
            Console.WriteLine("");
            DrukOpEenToets();
            Console.Clear();

            while (ingevoerdGetal != teRadenGetal && aantalPogingen <4)
            {
                Console.Write("Raad een getal tussen de 0 en 100: ");
                int.TryParse(Console.ReadLine(), out ingevoerdGetal);

                aantalPogingen = aantalPogingen + 1;
                
                if (ingevoerdGetal > teRadenGetal)
                {
                    Console.WriteLine($"{ingevoerdGetal} getal is te hoog");
                    
                }
                else if (ingevoerdGetal < teRadenGetal)
                {
                    Console.WriteLine($"{ingevoerdGetal} getal is te laag");
                  
                }
                else
                {
                    int reactieOptie = 0;
                    reactieOptie = willekeurig.Next(1, 5);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    //switch (reactieOptie)
                    //{
                    //    case 0:
                    //        Console.WriteLine("Je bent een kampioen!");
                    //        JuisteAntwoord();
                    //        break;
                    //    case 1:
                    //        Console.WriteLine("Jij kan echt gedachten lezen");
                    //        JuisteAntwoord();
                    //        break;
                    //    case 2:
                    //        Console.WriteLine("Hoe heb je het geraden!");
                    //        JuisteAntwoord();
                    //        break;
                    //    case 3:
                    //        Console.WriteLine("Oké, je bent eng GOED!");
                    //        JuisteAntwoord();
                    //        break;
                    //    case 4:
                    //        Console.WriteLine("Heb je afgekeken? Ongelooflijk!");
                    //        JuisteAntwoord();
                    //        break;
                    //    default:
                    //        break;
                    //}

                    string[] reacties = { "Je bent een kampioen!", "Super goed gedaan", "Heb je afgekeken? Ongelooflijk!" };

                   // Console.WriteLine(reacties[1]);
                    Console.WriteLine(reacties[willekeurig.Next(0,3)]);
                    JuisteAntwoord();
                    Console.ReadKey();


                }
            }
        }
    }
}
