using System;

class Program
{
    static int totalActivities = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nChoose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                totalActivities++;
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
                totalActivities++;
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                totalActivities++;
            }

            if (choice != "4")
            {
                Console.WriteLine($"\nActivities completed this session: {totalActivities}");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}

/*
EXCEEDING REQUIREMENTS:

1. Added a session tracker (counts completed activities).
2. Improved spinner animation.
3. Clean reusable base class for shared logic.
4. Simple but effective user experience.

*/