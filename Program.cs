using System.Reflection.Metadata;

namespace AdvancedC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            /*
             * Create a program that manages student grades using One Of Collections
                Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
                Print the collection, Count, first and last grade
                Sort the grades ascending, then print
                Get the first grade above 90
                Get all grades below 75 (failing grades)
                Remove all failing grades (below 75)
                Check if any grade equals 100
                Create a List<string> where each grade becomes "Grade: X"
             */
            //List<int> grades = new List<int> {85, 92, 78, 95, 88, 70, 100, 65}; // Collection of list
            //foreach (int grade in grades)      // print the collection
            //{
            //    Console.WriteLine(grade);
            //}
            //Console.WriteLine("------------------------------");

            //Console.WriteLine($"Number of grades: {grades.Count}"); // Count
            //Console.WriteLine($"First grade: {grades.First()}");    // First grade
            //Console.WriteLine($"Last grade: {grades.Last()}");      // Last grade
            //Console.WriteLine("------------------------------");

            //grades.Sort();    // Sort the grades ascending
            //foreach (int grade in grades)
            //    Console.WriteLine(grade);
            //Console.WriteLine("------------------------------");

            //int above = grades.Find(grade => grade > 90);   //the first grade above 90
            //Console.WriteLine($"First grade above 90: {above}");
            //Console.WriteLine("------------------------------");

            //List<int> below = grades.FindAll(grade => grade < 75); //all grades below 75
            //foreach (int grade in below)
            //    Console.WriteLine(grade);

            //below.Clear(); // Remove all failing grades below 75
            //Console.WriteLine("------------------------------");

            //bool equals = grades.Contains(100); // Check if any grade equals 100
            //Console.WriteLine($"Contains 100: {equals}");
            //Console.WriteLine("------------------------------");

            //List<string> gradeStrings = grades.Select(grade => $"Grade: {grade}").ToList(); // List<string>
            #endregion

            #region Exercise 2: Leaderboard
            /*
             * Create a leaderboard that automatically sorts players by score.
                Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
                Print all entries (they should be sorted by score automatically)
                Access the first key and first value 
                Check if score 500 exists
                Safely get the player with score 999
                Remove the player with score 200 and print the updated list
             */
            //Dictionary<int, string> leaderboard = new Dictionary<int, string> // Collection of dictionary
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};

            //Console.WriteLine($"First key: {leaderboard.Keys.First()}, First value: {leaderboard.Values.First()}");
            //Console.WriteLine("------------------------------");

            //bool IsExists = leaderboard.ContainsKey(500);         // Check if score 500 exists
            //Console.WriteLine($"Contains score 500: {IsExists}");
            //Console.WriteLine("------------------------------");

            //if (leaderboard.TryGetValue(999, out string? player))  // Safely get the player with score 999
            //{
            //    Console.WriteLine($"Player with score 999: {player}");
            //}
            //else
            //{
            //    Console.WriteLine("Player with score 999 not found.");
            //}
            //Console.WriteLine("------------------------------");

            //leaderboard.Remove(200);    // Remove the player with score 200
            //foreach (var players in leaderboard)
            //{
            //    Console.WriteLine($"Score: {players.Key}, Player: {players.Value}");
            //}
            //Console.WriteLine("------------------------------");
            #endregion

            #region Exercise 3: Phone Book
            /*
             * Build a phone book application.
                Create a Collection  with 4 contacts (name → phone number)
                Add a new contact using [] syntax (add or update)
                Try adding a duplicate using .Add() — catch the exception and print the error
                Try adding a duplicate using .TryAdd() — print whether it succeeded
                Search for a contact that doesn’t exist
                Get a contact with a fallback of "Not Found"
                Print all Keys on one line, then all Values on another line
             */
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //    ["Ahmed"] = "01038047759",
            //    ["Sara"] = "01038047759",
            //    ["Menna"] = "01012840954",
            //    ["Mostafa"] = "01115936686"
            //};

            //phoneBook["Ali"] = "01038047759";  //using [] syntax add

            //Console.WriteLine("------------------------------");

            //try                                // Try adding a duplicate using .Add()
            //{
            //    phoneBook.Add("Mostafa", "01115936686");
            //}
            //catch (ArgumentException ex)       // catch the exception and print the error
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("------------------------------");

            //bool added =phoneBook.TryAdd("Mostafa", "01115936686"); // Try adding a duplicate using .TryAdd()
            //Console.WriteLine($"TryAdd succeeded: {added}");        // succeeded is added or not
            //Console.WriteLine("------------------------------");

            //bool IsExists = phoneBook.ContainsKey("Mona"); // Search for a contact that doesn’t exist
            //Console.WriteLine($"Contains contact 'Mona': {IsExists}");
            //Console.WriteLine("------------------------------");

            //string phoneNumber = phoneBook.GetValueOrDefault("Aya", "Not Found"); // Get a contact with a fallback of "Not Found"
            //Console.WriteLine($"Aya phone: {phoneNumber}");
            //Console.WriteLine("------------------------------");

            //foreach (var key in phoneBook.Keys)     // Print all Keys on one line
            //    Console.Write(key + ", ");

            //Console.WriteLine();

            //foreach (var value in phoneBook.Values) // Print all Values on another line
            //    Console.Write(value + ", ");
            #endregion
        }
    }
}
