using System;

// The Program class contains the main entry point of the application
class Program
{
    // Main method: this is where the program starts executing
    static void Main(string[] args)
    {
        // Ask the user for their first name
        Console.Write("What is your first name? ");

        // Read the user's input and store it in the variable firstName
        string firstName = Console.ReadLine();

        // Ask the user for their last name
        Console.Write("What is your last name? ");

        // Read the user's input and store it in the variable lastName
        string lastName = Console.ReadLine();

        // Print a blank line for formatting (to match the example output)
        Console.WriteLine();

        // Display the formatted result using C# string interpolation
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
