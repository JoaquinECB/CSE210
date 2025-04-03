using System;

class Program
{
    static void Main(string[] args)
    {
    
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(6); // 6/1
        Fraction fraction3 = new Fraction(3, 4); // 3/4

        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        fraction3.SetTop(1);
        fraction3.SetBottom(3);

        Console.WriteLine($"Updated Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");
    }
}