using _10_IntroToAPIs.Models;
using _10_IntroToAPIs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    class Program
    {
        static void Main(string[] args)
        {
            // SwapiService swapiService = new SwapiService();

            MySwapiService swapiService = new MySwapiService();

            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter a homeworld ID");
            int homeworld = Convert.ToInt32(Console.ReadLine());

            Character newCharacter = new Character()
            {
                Name = name,
                Gender = gender,
                Homeworld = homeworld
            };

            Console.Clear();
            Console.WriteLine("\n\nSaving new character...");

            int statusCode = (int) swapiService.PostCharacterAsync(newCharacter).Result;

            Console.Clear();
            if (statusCode == 200)
            {
                Console.WriteLine("\n\nNew character created!");
            }
            else
            {
                Console.WriteLine("\n\nError saving character: " + statusCode);
            }

            Console.ReadKey();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a character ID:");
                int id = Int32.Parse(Console.ReadLine());

                if (id == 0)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine("\n\nLoading...");

                CharacterWithHomeworld character = swapiService.GetCharacterWithHomeworldAsync(id).Result;

                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine(character.Name);
                Console.WriteLine("\n\n");
                Console.WriteLine(character.Homeworld.Name);
                // Console.WriteLine(luke.Hair_Color);
                Console.ReadKey();
            }
        }
    }
}
