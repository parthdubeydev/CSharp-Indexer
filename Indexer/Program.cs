using System;

namespace Indexer
{
    // Class demonstrating how to use an indexer in C#
    public class TestIndexer
    {
        // Private array to store names, length 5
        string[] Names = new string[5];

    // Indexer to get or set values safely
    public string this[int index]
        {
            get
            {
                // Check if the index is within valid range
                if (index >= 0 && index < Names.Length)
                    return Names[index]; // Return the value at the specified index
                else
                    // Throw exception if index is invalid
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                // Check if the index is within valid range
                if (index >= 0 && index < Names.Length)
                    Names[index] = value; // Set the value at the specified index
                else
                    // Throw exception if index is invalid
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }

        // Public property to get the length of the array
        public int Lenght
        {
            get { return Names.Length; }
        }
    }

    // Program class to test the indexer
    internal class Program : TestIndexer
    {
        static void Main(string[] args)
        {
            // Create object of Program class
            Program obj = new Program();

            try
            {
                // Assign values to the array using the indexer
                obj[0] = "David";
                obj[1] = "Putin";
                obj[2] = "Pop";
                obj[3] = "Murli";
                obj[4] = "Tim";

                // Uncommenting the next line will trigger "Invalid index" exception
                // obj[5] = "Error"; 

                // Loop through array using the length property and display values
                for (int i = 0; i < obj.Lenght; i++)
                {
                    Console.Write(obj[i] + " "); // Access elements using indexer
                }
                Console.WriteLine(); // Move to the next line after printing all names
            }
            catch (IndexOutOfRangeException ex)
            {
                // Catch and display the exception message
                Console.WriteLine(ex.Message);
            }

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }

}
