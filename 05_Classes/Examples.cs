using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class Examples
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        // write a method that takes in a number and a string, and returns a combined result as a string

        public string AgfadgjyertTdfhgfjh(string name, int num, Vehicle vehicle)
        {
            // string sdagfhdjgfdsh = $"Hi I'm {name} and I have {num} guinea pigs";
            // return sdagfhdjgfdsh;
            return "Hi I'm " + name + " and I have " + num + " guinea pigs";
        }



        // Write a method that takes a number and writes to the console if it's odd or even


        public void IsEven(int someNum)
        {
            int remainder = someNum % 2;

            if (remainder == 0)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }



        public enum Flavor { Vanilla, Chocolate, Skunks, Strawberry, Pistachio, Sewage, Bubblegum, Snozberry };

        public bool DoesAndrewLikeTheIceCreamFlavor(Flavor flav)
        {
            switch (flav)
            {
                case Flavor.Vanilla:
                case Flavor.Strawberry:
                case Flavor.Chocolate:
                case Flavor.Pistachio:
                    return true;
                default:
                    return false;
            }
        }

        // BAD NO DON'T
        //public string GetLetterGrade(double percentage)
        //{
        //    switch (percentage)
        //    {
        //        case 0:
        //        case 0.1:
        //        case 0.2:
        //            ...
        //            case 99.9:
        //    }
        //}

    }
}
