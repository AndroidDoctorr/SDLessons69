using _10_IntroToAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapiService swapiService = new SwapiService();
            Person luke = swapiService.GetPersonAsync(1).Result;

            Console.WriteLine(luke.Name);
            Console.WriteLine(luke.Hair_Color);
            Console.ReadKey();
        }
    }
}
