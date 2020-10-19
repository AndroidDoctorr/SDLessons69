using _09_StreamingContent_UIRefactor.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            // RegularConsole console = new RegularConsole();
            FunConsole console = new FunConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.SayHello();
        }
    }
}
