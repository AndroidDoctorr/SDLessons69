using System;
using System.Collections.Generic;
using _07_Inheritance.Animals;
using _07_Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonTests()
        {
            Person me = new Person();
            me.FirstName = "Andrew";
            me.LastName = "Gorg";
            Console.WriteLine(me.Name);

            Employee dwight = new Employee(12345);
            dwight.FirstName = "Dwight";
            dwight.LastName = "Schrute";
            Console.WriteLine(dwight.Name);
            Console.WriteLine(dwight.EmployeeNumber);

            SalaryEmployee jim = new SalaryEmployee(12333, 60000);
            jim.FirstName = "Jim";
            Console.WriteLine(jim.FirstName);
            Console.WriteLine(jim.EmployeeNumber);
            Console.WriteLine(jim.Salary);

            List<Person> ListOfPeople = new List<Person>();
            ListOfPeople.Add(jim);
            ListOfPeople.Add(dwight);
            ListOfPeople.Add(me);
        }

        [TestMethod]
        public void AnimalTest()
        {
            // Animal animal = new Animal();
            Sloth sloth = new Sloth();
            Console.WriteLine(sloth.IsSlow);
            sloth.Move();
            sloth.SayFurColor();
        }
    }
}
