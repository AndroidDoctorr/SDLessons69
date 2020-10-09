using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday };

        [TestMethod]
        public void SwitchCases()
        {
            WeekDay today = WeekDay.Friday;

            switch (today)
            {
                case WeekDay.Monday:
                    Console.WriteLine("Somebody got a case of the Mondays?");
                    break;
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                    Console.WriteLine("It's the middle of the week");
                    break;
                case WeekDay.Friday:
                    Console.WriteLine();
                    break;
            }


        }


        [TestMethod]
        public void SwitchExpressions()
        {
            string output;
            int action = 1;

            switch (action)
            {
                case 0:
                    output = "Case 0";
                    break;
                case 1:
                    output = "Case 1";
                    break;
                case 2:
                    output = "Case 2";
                    break;
                default:
                    output = "Default Case";
                    break;
            }

            Console.WriteLine(output);


            // Switch Expression (C# 8.0+ ONLY!!)
            //output = action switch
            //{
            //    0 => "Case 0",
            //    1 => "Case 1",
            //    _ => "Default Case"
            //}
        }
    }
}
