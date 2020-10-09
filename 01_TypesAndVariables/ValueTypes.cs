using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // ThisIsPascalCase
            // thisIsCamelCase
            // this-is-kebab-case
            // this_is_snake_case


            // declare a variable:
            bool IsDeclared;

            // initialize a variable (assign a value)
            IsDeclared = true;

        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char specialCharacter = '\n';
            // CR = Carriage Return
            // LF = Line Feed
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte signedByteExample = -128;
            short shortExample = 32767;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.0452313254768965432568763456456354645f;
            Console.WriteLine(1.2456789567634563764562576456462534765463456345643657567f);

            double doubleExample = 1.8764563524356345635463546d;
            Console.WriteLine(doubleExample);

            decimal decimalExample = 1.32543678956756354643562435634563567345674567m;
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake = 1, Croissant = 50 * 3, Cookie, Scone = 13, Danish, Baguette };

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            Console.WriteLine(myPastry);
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime birthday = new DateTime(1985, 9, 22);

            TimeSpan age = today - birthday;
        }
    }
}
