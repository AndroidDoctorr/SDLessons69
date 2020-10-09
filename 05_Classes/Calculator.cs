using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        // Add
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        // Overloading  = making more than one version of a method
        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        // Challenge:

        // Subtract

        // Multiply

        // Divide

        // Power/Exponent x^y
        public int Power(int x, int y)
        {
            int result = x;
            for (int i = 1; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        // Calculate Remainder
    }
}
