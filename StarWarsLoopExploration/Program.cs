using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLoopExploration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rebel X-Wing Squadron Launch Countdown:");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"Launching X-Wing in {i}...");
            }
            Console.WriteLine("All X-Wings launched! May the Force be with you!");

            string[] starWarsCharacters = { "Luke Skywalker", "Leia Organa", "Han Solo", "Chewbacca", "Obi-Wan Kenobi", "Yoda", "Darth Vader", "Emperor Palpatine", "Boba Fett", "Jabba the Hutt" };

            Console.WriteLine("Star Wars Characters:");
            foreach (string character in starWarsCharacters)
            {
                Console.WriteLine(character);
            }

            string password = "";
            string correctPassword = "MayTheForceBeWithYou";

            while (password != correctPassword)
            {
                Console.WriteLine("Enter the password to access the Death Star plans:");
                password = Console.ReadLine();

                if (password != correctPassword)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            Console.WriteLine("Access granted. Downloading Death Star plans...");

            int menuChoice = 0;

            do
            {
                Console.WriteLine("/nStarfighter Maintenacne Menu:");
                Console.WriteLine("1. Repair X-Wing");
                Console.WriteLine("2. Refuel A-Wing");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Repairing X-Wing...");
                            break;
                        case 2:
                            Console.WriteLine("Refueling A-Wing...");
                            break;
                        case 3:
                            Console.WriteLine("Exiting maintenance menu...");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                    }
                } while (menuChoice != 3);

                Console.WriteLine("May the Force be with you, always.");
        }
    }
}
