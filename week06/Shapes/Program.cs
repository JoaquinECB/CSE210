using System;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square("Red", 4);
        Shape rectangle = new Rectangle("Blue", 5, 3);
        Shape circle = new Circle("Green", 2.5);

        Console.WriteLine($"Square (Color: {square.GetColor()}): Area = {square.GetArea()}");
        Console.WriteLine($"Rectangle (Color: {rectangle.GetColor()}): Area = {rectangle.GetArea()}");
        Console.WriteLine($"Circle (Color: {circle.GetColor()}): Area = {circle.GetArea()}");
    }
}