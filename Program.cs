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
            //Console.WriteLine("-----------------------------------------------------------");

            //Console.WriteLine($"Number of grades: {grades.Count}"); // Count
            //Console.WriteLine($"First grade: {grades.First()}");    // First grade
            //Console.WriteLine($"Last grade: {grades.Last()}");      // Last grade
            //Console.WriteLine("-----------------------------------------------------------");

            //grades.Sort();    // Sort the grades ascending
            //foreach (int grade in grades)
            //    Console.WriteLine(grade);
            //Console.WriteLine("-----------------------------------------------------------");

            //int above = grades.Find(grade => grade > 90);   //the first grade above 90
            //Console.WriteLine($"First grade above 90: {above}");
            //Console.WriteLine("-----------------------------------------------------------");

            //List<int> below = grades.FindAll(grade => grade < 75); //all grades below 75
            //foreach (int grade in below)
            //    Console.WriteLine(grade);

            //below.Clear(); // Remove all failing grades below 75
            //Console.WriteLine("-----------------------------------------------------------");

            //bool equals = grades.Contains(100); // Check if any grade equals 100
            //Console.WriteLine($"Contains 100: {equals}");
            //Console.WriteLine("-----------------------------------------------------------");

            //List<string> gradeStrings = grades.Select(grade => $"Grade: {grade}").ToList(); // List<string>
            #endregion
        }
    }
}
