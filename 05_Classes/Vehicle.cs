using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Boat, Rocket, Hovercraft, Submarine };
    public class Vehicle
    {
        // Fields and Properties
        public string Make { get; set; }
        // field (private)
        private string _model;
        public void SetModel(string model)
        {
            if (model == model.ToLower())
            {
                // capitalize
            }
            _model = model;
        }
        public string GetModel()
        {
            return _model;
        }

        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool IsRunning { get; private set; }

        // Constructors
        // Empty constructor
        public Vehicle()
        {

        }
        // Full constructor
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            _model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }
        // Partial constructor
        public Vehicle(VehicleType type, string model)
        {
            TypeOfVehicle = type;
            _model = model;
        }

        // Methods
        public void TurnOn()
        {
            if (IsRunning)
            {
                Console.WriteLine("It's already on.");
            }
            else
            {
                IsRunning = true;
                Console.WriteLine("You turn the vehicle on.");
            }
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You shut off the vehicle.");
        }
    }
}
