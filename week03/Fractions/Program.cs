using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Crear fracciones usando los tres constructores
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(6); // 6/1
        Fraction fraction3 = new Fraction(3, 4); // 3/4

        // Mostrar las fracciones usando GetFractionString y GetDecimalValue
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        // Usar setters para cambiar los valores
        fraction3.SetTop(1);
        fraction3.SetBottom(3);

        // Mostrar los nuevos valores
        Console.WriteLine($"Updated Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");
    }
}