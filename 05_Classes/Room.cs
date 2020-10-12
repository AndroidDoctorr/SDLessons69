using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Room
    {
        /*
         *  Create a Room class that has three properties:
                one each for the length, width, and height.
         *  Create a method that calculates total square footage.
         *  We also would like to include some constants that the
            define a minimum and maximum length, width, and height.
         *  When setting the properties, make sure to compare
            the values to the min/max and only set them if the
            value is valid.

        Bonus:
         *  Create a method that calculates total lateral surface area.
        Only allow the properties to be set from inside the class itself.
        Throw an exception if the given value is outside the permitted range.
        Test the code like we did with the Vehicle tests.
         */
        private double _minLength = 1.0d;
        private double _minWidth = 1.0d;
        private double _minHeight = 1.0d;
        private double _maxLength = 999.0d;
        private double _maxWidth = 999.0d;
        private double _maxHeight = 999.0d;

        private double _length;
        private double _width;
        private double _height;
        public double Length {
            get { return _length; }
            set
            {
                if (value > _minLength && value < _maxLength)
                {
                    _length = value;
                } else
                {
                    // throw new ArgumentException("Length is outside of valid range");
                }
            }
        }
        public double Width { get; set; }
        public double Height { get; set; }
        // Access modifier, return type, signature
        // 1     2           3
        public double GetSurfaceArea()
        {
            // 4 - body
            return 2 * Length + Height + 2 * Length * Width + 2 * Width * Height;
        }


    }
}
