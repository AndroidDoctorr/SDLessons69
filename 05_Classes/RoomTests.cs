using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Room room = new Room();
            room.Length = 5;
            room.Length = 64;

            Console.WriteLine(room.Length);
        }
    }
}
