using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Andrew";
            string lastName = "Torr";

            // concatenation
            string concatenatedFullName = firstName + " " + lastName;

            Console.WriteLine(concatenatedFullName);

            // compositing
            string compositeName = string.Format("my name is {0} {1} {2}", firstName, lastName, "hi");
            Console.WriteLine(compositeName);

            // interpolation
            string interpolatedName = $"{firstName} {lastName}";
        }

        [TestMethod]
        public void Classes()
        {
            Random randy = new Random();
            // randy is now an Object of type/class Random
            int randomNumber = randy.Next(1, 11);
            Console.WriteLine(randomNumber);

            int otherRandomNumber = randy.Next(1, 11);
            Console.WriteLine(otherRandomNumber);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello world!";


            string[] stringArray = { "Hello", "world", "why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[0] = "hello there";
            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("hello");

            List<int> listOfInts = new List<int>();
            listOfInts.Add(456);

            int firstInt = listOfInts[0];

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next");
            string firstItem = firstInFirstOut.Dequeue();
            string nextItem = firstInFirstOut.Dequeue();
            // string noItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            Console.WriteLine(nextItem);
            // Console.WriteLine(noItem);

            Dictionary<string, string> keyAndValue = new Dictionary<string, string>();
            keyAndValue.Add("name", "Andrew");
            keyAndValue.Add("otherName", "Andrew");

            string name = keyAndValue["name"];
            Console.WriteLine(name);

            Dictionary<string, double> importantNumbers = new Dictionary<string, double>();
            importantNumbers.Add("pi", 3.14159265358979);
            importantNumbers.Add("e", 2.57);

            // SortedList
            // HashSet
            // Stack
        }
    }
}
