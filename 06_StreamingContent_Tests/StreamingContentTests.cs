using System;
using _06_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldReturnCorrectString()
        {
            //Arrange
            StreamingContent content = new StreamingContent();

            //Act
            content.Title = "Toy Story";


            //Assert
            Assert.AreEqual(content.Title, "Toy Story");
        }
    }
}
