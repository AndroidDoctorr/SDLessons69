using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 200;

            string isAdult = (age >= 18) ? "yes" : "no";

            Console.WriteLine((age >= 100) ? "how does it feel to be a century old?" : "hi");
            Console.WriteLine((age >= 100) ? ((age >= 200) ? "wow!" : "100! yay!") : "hi");
        }
    }
}
