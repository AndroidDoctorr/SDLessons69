using _06_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContent_Repo _repo = new StreamingContent_Repo();



        public void FizzBuzz(int limit)
        {
            for (int index = 1; index <= limit; index++)
            {
                //Console.WriteLine((i%3 == 0
                //  ?
                //    (i%5 == 0 ? "FizzBuzz" : "Fizz")
                //  :
                //    (i%5 == 0 ? "Buzz" : i.ToString())));
                Thread.Sleep(50);

                if (index % 15 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Fizz");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Buzz\n");
                }
                else if (index % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Buzz");
                }
                else if (index % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(index);
                }
            }
        }





        public void Run()
        {
            SeedContent();
            Menu();
        }

        private void SeedContent()
        {
            StreamingContent futureWar = new StreamingContent(
                "Future War", 
                "a war in the future",
                10.0,
                Genre.SciFi,
                MaturityRating.G
            );
            StreamingContent theRoom = new StreamingContent(
                "The Room",
                "Everyone betrays Johnny and he's fed up with this world",
                10.0,
                Genre.Documentary,
                MaturityRating.G
            );
            _repo.AddContentToDirectory(futureWar);
            _repo.AddContentToDirectory(theRoom);
        }

        private void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Update existing streaming content\n" +
                    "5. Remove streaming content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Show all content
                        ShowAllContent();
                        break;
                    case "2":
                        //Get content by title
                        ShowContentByTitle();
                        break;
                    case "3":
                        //Create new streaming content
                        CreateNewContent();
                        break;
                    case "4":
                        // Update existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete existing content
                        DeleteContentByTitle();
                        break;
                    case "6":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void UpdateExistingContent()
        {
            // Finish this method
            Console.Clear();
            Console.WriteLine("Enter the title of the content you'd like to update.");
            string title = Console.ReadLine();
            StreamingContent oldItem = _repo.GetContentByTitle(title);

            if (oldItem == null)
            {
                Console.WriteLine("Content not found, press any key to continue...");
                Console.ReadKey();
                return;
            }

            StreamingContent newItem = new StreamingContent(
                oldItem.Title,
                oldItem.Description,
                oldItem.StarRating,
                oldItem.Genre,
                oldItem.MaturityRating
            );

            Console.WriteLine("Which property would you like to update:\n" +
                    "1. Title\n" +
                    "2. Description\n" +
                    "3. Star Rating\n" +
                    "4. Maturity Rating\n" +
                    "5. Genre\n" +
                    "6. Nevermind");

            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Enter a new title");
                    string newTitle = Console.ReadLine();
                    newItem.Title = newTitle;

                    bool wasSuccessful = _repo.UpdateExistingContent(title, newItem);

                    if (wasSuccessful)
                    {
                        Console.WriteLine("Item successfully updated");
                    } else
                    {
                        Console.WriteLine($"Error: Could not update {title}");
                    }
                    break;
                default:
                    break;
            }

        }

        private void ShowAllContent()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _repo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void CreateNewContent()
        {
            Console.Clear();

            StreamingContent newContent = new StreamingContent();

            Console.WriteLine("Please enter a title.");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("Please enter a description.");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("Please enter a star rating (1.0 - 10.0) for this content.");
            string ratingAsString = Console.ReadLine();
            double ratingAsDouble = double.Parse(ratingAsString);
            newContent.StarRating = ratingAsDouble;

            Console.WriteLine("Select a genre.");
            Console.WriteLine("1.Horror");
            Console.WriteLine("2.RomCom");
            Console.WriteLine("3.SciFi");
            Console.WriteLine("4.Action");
            Console.WriteLine("5.Documentary");
            Console.WriteLine("6.Musical");
            Console.WriteLine("7.Drama");
            Console.WriteLine("8.Mystery");

            string genreInput = Console.ReadLine();
            int genreAsInt = int.Parse(genreInput);
            newContent.Genre = (Genre)genreAsInt;


            bool stopRunning = false;
            while (!stopRunning)
            {

                Console.WriteLine("Select a maturity rating.");
                Console.WriteLine("1. G");
                Console.WriteLine("2. PG");
                Console.WriteLine("3. PG_13");
                Console.WriteLine("4. R");
                Console.WriteLine("5. NC_17");

                string maturityRating = Console.ReadLine();


                switch (maturityRating)
                {
                    case "1":
                        newContent.MaturityRating = MaturityRating.G;
                        stopRunning = true;
                        break;
                    case "2":
                        newContent.MaturityRating = MaturityRating.PG;
                        stopRunning = true;
                        break;
                    case "3":
                        newContent.MaturityRating = MaturityRating.PG_13;
                        stopRunning = true;
                        break;
                    case "4":
                        newContent.MaturityRating = MaturityRating.R;
                        stopRunning = true;
                        break;
                    case "5":
                        newContent.MaturityRating = MaturityRating.NC_17;
                        stopRunning = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        stopRunning = false;
                        break;
                }
            }
            bool wasAdded = _repo.AddContentToDirectory(newContent);
            if (wasAdded == true)
            {
                Console.WriteLine("Your content was succesfully added.");
            }
            else
            {
                Console.WriteLine("Oops something went wrong. Your content was not added.");
            }
        }

        private void ShowContentByTitle()
        {
            Console.Clear();

            Console.WriteLine("Enter the title of the content you'd like to see.");
            string title = Console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("That title doesn't exist.");
            }
                Console.ReadKey();
        }


        private void DeleteContentByTitle()
        {
            ShowAllContent();
            Console.WriteLine("Enter the title for the content you would like to delete.");
            string titleToDelete = Console.ReadLine();

            StreamingContent contentToDelete = _repo.GetContentByTitle(titleToDelete);
            bool wasDeleted = _repo.DeleteExistingContent(contentToDelete);

            if (wasDeleted)
            {
                Console.WriteLine("This content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Content could not be deleted");
            }
        }
        //Method that prompts user for which StreamingContent object they want to delete (use the title to find it)
        //remove it from the _contentDirectory.

        //Bonus: Display all the options for them to select from 

        //work until 2:15

        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title}");
            Console.WriteLine($"Description: {content.Description}");
            Console.WriteLine($"Star Rating: {content.StarRating}");
            Console.WriteLine($"Maturity Rating: {content.MaturityRating}");
            Console.WriteLine($"Genre: {content.Genre}");
            Console.WriteLine($"Is it family friendly? {content.IsFamilyFriendly}");
        }
    }
}
