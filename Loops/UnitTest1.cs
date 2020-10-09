using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total < 10)
            {
                Console.WriteLine(total);
                // total = total + 1;
                // total += 1;
                total++;

            }


            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached!");
                    break;
                }
                total++;
            }

            Random randy = new Random();
            int counter;
            bool keepLooping = true;

            while (keepLooping)
            {
                counter = randy.Next(0, 20);

                if (counter == 6 || counter == 10)
                {
                    continue;
                }

                Console.WriteLine(counter);

                if (counter == 15)
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 31;

            // LCV = loop control variable
            // 1 - Start/setup
            // 2 - "keep looping" condition
            // 3 - Do after each loop
            // 4 - Code executed each loop
            //       1              2          3
            for (int i = 0; i < studentCount; i++)
            {
                // 4
                Console.WriteLine(i);
            }


            // For loops can be weird!
            for (Random randy = new Random(); randy.Next(0, 10) != 8; Console.WriteLine("ahhh"))
            {

            }


            string[] instructors = { "Andrew", "Michael", "Josh", "Amanda" };
            for (int i = 0; i < instructors.Length; i++)
            {
                Console.WriteLine($"{instructors[i]} welcomes you!");
            }

        }


        [TestMethod]
        public void ForEachLoops()
        {
            string[] instructors = { "Andrew", "Michael", "Josh", "Amanda" };
            foreach (string instructor in instructors)
            {
                Console.WriteLine(instructor);
            }

            foreach (char letter in "Andrew Torr")
            {
                Console.WriteLine(letter);
                Console.WriteLine("Andrew Torr"[3]);
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;

            do
            {
                Console.WriteLine("Hello!");
                Console.WriteLine(iterator++);
            }
            while (iterator < 10);


            do
            {
                Console.WriteLine("Do this anyway");
            } while (false);

            while (false)
            {
                Console.WriteLine("This never happens");
            }
        }
    }
}
