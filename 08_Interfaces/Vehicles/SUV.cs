using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Vehicles
{
    public class SUV : IVehicle
    {
        // field
        private bool _isRunning = false;
        // properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        
        public void Start()
        {
            if (_isRunning)
            {
                Console.WriteLine("*AWFUL NOISE*");
            }
            else
            {
                _isRunning = true;
                Console.WriteLine("The SUV starts up");
            }
        }

        public void TurnOff()
        {

        }

        public void Drive()
        {

        }
    }
}
