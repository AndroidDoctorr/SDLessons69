using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06_StreamingContent_Repository;

namespace _06_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContent_RepoTests
    {
        
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContent_Repo repository = new StreamingContent_Repo();

            //Act
            bool addResult = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContent_Repo repo = new StreamingContent_Repo();

            repo.AddContentToDirectory(content);

            //Act
            List<StreamingContent> contents = repo.GetContents();

            bool directoryHasContent = contents.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            StreamingContent_Repo repo = new StreamingContent_Repo();
            StreamingContent newContent = new StreamingContent("Toy Story", "Toys come to life", 10, Genre.Action, MaturityRating.PG);
            repo.AddContentToDirectory(newContent);
            string title = "Toy Story";
            
            //Act
            StreamingContent searchResult = repo.GetContentByTitle(title);
            //Assert
            Assert.AreEqual(searchResult.Title, title);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent_Repo repo = new StreamingContent_Repo();
            StreamingContent oldContent = new StreamingContent("Toy Story", "Toys come to life", 8, Genre.Drama, MaturityRating.PG);
            repo.AddContentToDirectory(oldContent);

            StreamingContent newContent = new StreamingContent("Toy Story", "Toys come to life", 10, Genre.Action, MaturityRating.PG);

            //Act
            bool updateResult = repo.UpdateExistingContent(oldContent.Title, newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent_Repo repo = new StreamingContent_Repo();
            StreamingContent content = new StreamingContent("Toy Story", "Toys come to life", 8, Genre.Drama, MaturityRating.PG);
            repo.AddContentToDirectory(content);

            //Act
            StreamingContent oldContent = repo.GetContentByTitle("Toy Story");

            bool removeResult = repo.DeleteExistingContent(oldContent);

            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
