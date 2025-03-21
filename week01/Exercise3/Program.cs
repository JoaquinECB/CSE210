using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;

        Console.WriteLine("Welcome to 'Guess My Number'!");
        Console.WriteLine("I have chosen a number between 1 and 100. Can you guess what it is?");

        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
        }
    }
}