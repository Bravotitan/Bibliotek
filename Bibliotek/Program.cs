using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            //opretter min stack og min list
            Stack<Bog> deck = new Stack<Bog>();
            List<Bog> collection = new List<Bog>();

            //opretter objekter
            Bog intet = new Bog();
            Bog Granny = new Bog();
            Bog road = new Bog();

            //tilføjer bøger til mit library
            intet.Navn = "intet";
            intet.Pages = 200;
            intet.Author = "Jane teller";
            collection.Add(intet);
           
            Granny.Navn = "Gangsta granny";
            Granny.Pages = 150;
            Granny.Author = "david walliams";
            collection.Add(Granny);

            road.Navn = "On The Road ";
            road.Author = "jack kerouac";
            road.Pages = 50;

            collection.Add(road);
        
            Console.WriteLine("Velkommen til Biblioteket!");
            Console.WriteLine($"Her er de bøger du kan låne:\r\n");

            //loop til at udskrive alle mine bøger
            int tal = 1;
            foreach ( Bog saml in collection) 
            {
                Console.WriteLine($" {tal++} Titel: {saml.Navn}  Forfatter: {saml.Author} Sider: {saml.Pages}");

            }
            Console.WriteLine("4  færdig med at vælge");

           
            //switch til at håndtere user inputs fra readline
            bool power = true;
            while (power)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        if (deck.Contains(intet))
                        {
                            Console.WriteLine("Du har allerede lånt denne bog vælg en anden");
                            break;
                        }
                        
                            Console.WriteLine("Du har valgt bogen");
                            deck.Push(intet);
                        
                        break;

                    case "2":
                        if (deck.Contains(Granny))
                        {
                            Console.WriteLine("Du har allerede lånt denne bog vælg en anden");
                            break;
                        }
                        Console.WriteLine("Du har lånt bogen");
                        deck.Push(Granny);
                        break;

                    case "3":
                        if (deck.Contains(road))
                        {
                            Console.WriteLine("Du har allerede lånt denne bog vælg en anden");
                            break;

                        }

                        Console.WriteLine("Du har lånt bogen");
                        deck.Push(road);
                        break;

                    case "4":
                        Console.WriteLine("Du skal nu låne bøgerne");
                        power = false;
                        break;

                }
            }
            Console.WriteLine("");

            //Udskriver hvor mange bøger der er valgt
            Console.WriteLine(deck.Count());

            //udskriver mine bøger
            foreach (Bog result in deck)
            {
                Console.WriteLine(result.Navn);
            }

            //laver mellemrum og laver en variable til count
            Console.WriteLine("");

            int counts = deck.Count;

            //For loop til at poppe
            for (int i = 0; i < counts; i++)
            {

                Bog popper=deck.Pop();

                Console.WriteLine(popper.Navn);
            }

            Console.ReadKey();
        }
    }
}
