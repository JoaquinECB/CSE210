using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter numbers (type 0 to stop):");

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The maximum is: {max}");
    }
}