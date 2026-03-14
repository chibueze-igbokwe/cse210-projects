using System;

// Main program class
class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Create a random number generator
        Random randomGenerator = new Random();

        // Generate a random number between 1 and 100
        int magicNumber = randomGenerator.Next(1, 101);

        // Variable to store the user's guess
        int guess = -1;

        // Loop until the user guesses correctly
        while (guess != magicNumber)
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");

            // Read the input and convert it to an integer
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            // Compare the guess with the magic number
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
