using System;

/*
CREATIVITY / EXCEEDING REQUIREMENTS

This program exceeds the basic requirements by adding:

1. Mood Tracking
Each journal entry asks the user how they felt (Happy, Sad, Excited, etc.)
This mood is stored and displayed with each entry.

2. Entry Statistics
The program displays how many entries exist in the journal.

3. Additional Prompts
More than the required five prompts are included.

These features improve the journaling experience and demonstrate
additional abstraction and data storage beyond the core requirements.
*/

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How did you feel today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}