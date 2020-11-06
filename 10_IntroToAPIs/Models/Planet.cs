using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPIs.Models
{
    public class Planet
    {
        public string Climate { get; set; }
        public string Name { get; set; }
        public double Diameter { get; set; }
        public double Gravity { get; set; }
        public double Orbital_Period { get; set; }
        public double Rotation_Period { get; set; }
        public bool Surface_Water { get; set; }
    }
}
