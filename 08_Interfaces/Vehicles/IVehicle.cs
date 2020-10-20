using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Vehicles
{
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        string Color { get; }
        void Start();
        void TurnOff();
        void Drive();
    }
}
