using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class FunConsole : IConsole
    {
        private Random _random = new Random();

        public void Clear()
        {
            Console.Clear();
        }
        public string ReadLine()
        {
            Console.WriteLine("Idiot says:");
            string input = Console.ReadLine();
            string newInput = "";

            bool capitalize = false;
            foreach (char letter in input)
            {
                if (capitalize)
                {
                    newInput += letter.ToString().ToUpper();
                    capitalize = false;
                } else
                {
                    newInput += letter.ToString().ToLower();
                    capitalize = true;
                }
            }
            return newInput;
        }
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
        public void WriteLine(string s)
        {
            int colorPicker = _random.Next(0, 6);
            switch (colorPicker)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
            }
            Console.WriteLine("Simon says:");
            Console.WriteLine(s);
        }
        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
        public void Write(string s)
        {
            Console.Write(s);
        }
    }
}
