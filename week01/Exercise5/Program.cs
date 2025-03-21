using System;

class Program
{
    static string userName;
    static int favoriteNumber;
    static int squaredNumber;

    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static void PromptUserName()
    {
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine(); 
    }

    static void PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        favoriteNumber = int.Parse(Console.ReadLine()); 
    }

    static void SquareNumber()
    {
        squaredNumber = favoriteNumber * favoriteNumber; 
    }

    static void DisplayResult()
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
    }
}