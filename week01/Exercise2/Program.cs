using System;

// Main program class
class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");

        // Read the input (Console.ReadLine always returns a string)
        string userInput = Console.ReadLine();

        // Convert the string input into an integer
        int grade = int.Parse(userInput);

        // Create a variable to store the letter grade
        string letter = "";

        // Determine the letter grade using if / else if / else
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade
        Console.WriteLine($"Your grade is: {letter}");

        // Determine if the user passed or failed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do better next time.");
        }
    }
}
