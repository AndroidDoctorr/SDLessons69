using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs.Models
{
    public class CharacterWithHomeworld
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int HomeworldId { get; set; }
        public Planet Homeworld { get; set; }
    }
}
