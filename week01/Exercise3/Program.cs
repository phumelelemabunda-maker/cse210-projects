using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 11);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
                Console.WriteLine("Higher");
            else if (guess > magicNumber)
                Console.WriteLine("Lower");
            else
                Console.WriteLine("You guessed it!");
        }
    }
}