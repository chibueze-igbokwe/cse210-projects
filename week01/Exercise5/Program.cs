using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the welcome function
        DisplayWelcome();

        // Call function to get user's name
        string userName = PromptUserName();

        // Call function to get user's favorite number
        int userNumber = PromptUserNumber();

        // Call function to square the number
        int squaredNumber = SquareNumber(userNumber);

        // Call function to display the result
        DisplayResult(userName, squaredNumber);
    }

    // Displays the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Prompts the user for their name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Prompts the user for their favorite number and returns it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();

        int number = int.Parse(input);
        return number;
    }

    // Accepts a number and returns its square
    static int SquareNumber(int number)
    {
        int result = number * number;
        return result;
    }

    // Displays the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
