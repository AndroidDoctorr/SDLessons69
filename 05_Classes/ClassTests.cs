using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Greeter greeter = new Greeter();
            greeter.SayHello("Aaron");
            string greeting = greeter.GetRandomGreeting().ToLower();
            greeting = "Random greeting: " + greeting;
            greeter.SaySomething(greeting);

            greeter.SaySomething(greeter.GetRandomGreeting());
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Calculator calculator = new Calculator();

            int thirtyTwoHopefully = calculator.Power(2, 5);
            Console.WriteLine(thirtyTwoHopefully);
        }

        [TestMethod]
        public void VehicleTest()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Make = "blah";
            vehicle.SetModel("blahblah 2.0");

            Console.WriteLine(vehicle.Make);
            Console.WriteLine(vehicle.GetModel());

            vehicle.TurnOn();
            vehicle.TurnOn();
            vehicle.TurnOff();
        }


        [TestMethod]
        public void LoopTest()
        {
            Greeter greeter = new Greeter();
            greeter.LoopChallenge();
        }

        [TestMethod]
        public void PersonTest()
        {
            Person andrew = new Person("Andrew", "Torr", new DateTime(1985, 9, 22));
            Vehicle car = new Vehicle(VehicleType.Car, "Journey");
            andrew.Transport = car;

            Console.WriteLine(andrew.FullName);
            Console.WriteLine(andrew.Age);
            Console.WriteLine(andrew.Transport.GetModel());
        }


        [TestMethod]
        public void UserTest()
        {
            DateTime birthdate = new DateTime(1985, 9, 22);
            User user = new User(1, "Andrew", "Torr", birthdate);

            Console.WriteLine(user.GetAgeInYears());
        }
    }
}
