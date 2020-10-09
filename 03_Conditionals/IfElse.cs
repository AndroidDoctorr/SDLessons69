using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 35;

            if (age > 100)
            {
                Console.WriteLine("you are a super adult. congrats.");
            } else if (age >= 18)
            {
                Console.WriteLine("you are a regular adult. gj");
            } else
            {
                Console.WriteLine("you dumb kid, go away");
            }
        }
    }
}
