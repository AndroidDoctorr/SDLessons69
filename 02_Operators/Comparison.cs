using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 35;
            string name = "Andrew";
            bool isForty = age == 40;
            bool isAndrew = name.ToLower() == "andrew";
            // name = name.ToLower();

            Console.WriteLine("Am I exactly 40? " + isForty + " is my name andrew " + isAndrew);

            bool isNotEighteen = age != 18;

            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool isOverOneHunded = age > 100;

            bool trueValue = true;
            bool falseValue = false;

            bool andValue = trueValue && falseValue;
            bool orValue = trueValue || falseValue;

            bool isFive = 5 == Int32.Parse("5");


            // Arithmetic

            int remainder = 12 % 100;

            Console.WriteLine(remainder);
        }
    }
}
