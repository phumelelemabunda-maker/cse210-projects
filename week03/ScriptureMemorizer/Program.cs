// EXCEEDING REQUIREMENTS:
// - I added multiple scriptures stored in a list instead of just one
// - The program randomly selects a scripture each time it runs
// - Words are only hidden if they are not already hidden
// - The program hides multiple words at once to make memorizing more challenging

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of scriptures to choose from
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"),

            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding")
        };

        // Pick a random scripture
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        string userInput = "";

        // Keep running until user quits or everything is hidden
        while (userInput != "quit")
        {
            Console.Clear();

            // Display scripture
            Console.WriteLine(selectedScripture.GetDisplayText());

            // Stop if everything is hidden
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Good job!");
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            userInput = Console.ReadLine().ToLower();

            if (userInput != "quit")
            {
                // Hide a few random words each time
                selectedScripture.HideRandomWords(3);
            }
        }
    }
}