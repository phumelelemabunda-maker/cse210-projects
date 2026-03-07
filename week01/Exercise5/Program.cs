using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptName();
        int number = PromptNumber();

        int square = SquareNumber(number);

        DisplayResult(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int PromptNumber()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square is {square}");
    }
}