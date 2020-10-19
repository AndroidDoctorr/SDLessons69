using _09_StreamingContent_UIRefactor.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor
{
    public class ProgramUI
    {
        private IConsole _console;
        // Dependency injection - an IConsole object must be passed in when this is created
        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        // Everything this class does (or at least some of what it does) DEPENDS on an IConsole object
        public void SayHello()
        {
            _console.WriteLine("What is your name?");
            string name = _console.ReadLine();
            _console.WriteLine($"Hey, {name}, how are you doing?");
            string reply = _console.ReadLine();
            _console.WriteLine(reply);
            _console.ReadKey();
        }
    }
}
